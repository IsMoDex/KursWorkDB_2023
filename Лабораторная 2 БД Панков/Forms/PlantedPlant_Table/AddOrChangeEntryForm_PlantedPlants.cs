using Npgsql;
using Npgsql.Internal.TypeHandlers.DateTimeHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms
{
    public partial class AddOrChangeEntryForm_PlantedPlants : Form
    {
        /// <summary>
        /// Форма добавления/изменения записей в таблицу "Посаженные растения"
        /// </summary>
        public AddOrChangeEntryForm_PlantedPlants()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_PlantedPlants(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;

        private void AddEntryForm_PlantedPlants_Load(object sender, EventArgs e)
        {

            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = "";
                SQL = $"SELECT * FROM \"{MainForm.Plants}\" WHERE \"код_растения\" = {Record_ID}";

                DataTable dt = MainForm.getDataTable(SQL);

                код_участка_comboBox.Text = Convert.ToString(dt.Rows[0][1]);
                номер_в_каталоге_comboBox.Text = Convert.ToString(dt.Rows[0][2]);

                //pictureBox1.Image = (Bitmap)dt.Rows[0][3];

                дата_посадки_dateTimePicker.Value = DateTime.Parse(Convert.ToString(dt.Rows[0][4]));//new DateTime(ArrayDate[2], ArrayDate[1], ArrayDate[0]);


                try
                {
                    дата_гибели_dateTimePicker.Value = DateTime.Parse(Convert.ToString(dt.Rows[0][5]));//new DateTime(ArrayDate[2], ArrayDate[1], ArrayDate[0]);
                }
                catch 
                {
                    NotDeadDataCheckBox.Checked = true;
                };

                стоимность_саженца_numericUpDown.Value = Convert.ToDecimal(dt.Rows[0][6]);
                условия_ухода_и_содержания_textBox.Text = Convert.ToString(dt.Rows[0][7]);
                
            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Посаженные растения\"";
            getData();
        }

        private async void getData()
        {
            await Task.Run(() =>
            {
                string SQL = "";

                SQL = $"SELECT \"номер_растения_в_каталоге\" FROM \"{MainForm.PlantCatalog}\"";
                var CodesPlantsInCatalog = MainForm.getDataTable(SQL).AsEnumerable().Select(r => r.Field<Int64>("номер_растения_в_каталоге")).ToList();

                foreach (long code in CodesPlantsInCatalog)
                {
                    try
                    {
                        номер_в_каталоге_comboBox.Invoke((MethodInvoker)delegate
                        {
                            номер_в_каталоге_comboBox.Items.Add(code);
                            return;
                        });
                    }
                    catch { return; };
                }

                SQL = $"SELECT \"код_участка\" FROM \"{MainForm.GardenPlots}\"";
                var ListCodePlots = MainForm.getDataTable(SQL).AsEnumerable().Select(r => r.Field<Int64>("код_участка")).ToList();

                foreach (long code in ListCodePlots)
                {
                    try
                    {
                        код_участка_comboBox.Invoke((MethodInvoker)delegate
                        {
                            код_участка_comboBox.Items.Add(code);
                        });
                    }
                    catch { return; };
                }
            });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            дата_гибели_dateTimePicker.Visible = !NotDeadDataCheckBox.Checked;
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";

            if(ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.Plants}\" ( \"код_участка\", \"номер_в_каталоге\", \"фото_растения\", \"дата_посадки\", \"дата_гибели\", \"стоимость_саженца\", \"условия_ухода_и_содержания\" ) VALUES " +
                    $"( \'{код_участка_comboBox.Text}\', \'{номер_в_каталоге_comboBox.Text}\', @Image, \'{дата_посадки_dateTimePicker.Value.ToString("dd-MM-yyyy")}\', @DeadDate, \'{стоимность_саженца_numericUpDown.Value}\', \'{условия_ухода_и_содержания_textBox.Text}\' )";
            }
            else
            {
                SQL = $"UPDATE \"{MainForm.Plants}\" SET " +
                    $"\"код_участка\" = \'{код_участка_comboBox.Text}\', \"номер_в_каталоге\" = \'{номер_в_каталоге_comboBox.Text}\', \"фото_растения\" = \'@Image\', \"дата_посадки\" = \'{дата_посадки_dateTimePicker.Value.ToString("dd-MM-yyyy")}\', \"дата_гибели\" = @DeadDate, \"стоимость_саженца\" = \'{стоимность_саженца_numericUpDown.Value}\', \"условия_ухода_и_содержания\" = \'{условия_ухода_и_содержания_textBox.Text}\' " +
                    $"WHERE \"код_растения\" = \'{Record_ID}\'";
            }

            NpgsqlParameter image_param = MainForm.cmd.CreateParameter();
            image_param.ParameterName = "@Image";
            image_param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
            image_param.Value = DBNull.Value;

            if(pictureBox1.Image != null)
            {
                using(MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    image_param.Value = ms.ToArray();
                }
            }

            NpgsqlParameter dead_date = MainForm.cmd.CreateParameter();
            dead_date.ParameterName = "@DeadDate";
            dead_date.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Date;
            dead_date.Value = DBNull.Value;

            if (!NotDeadDataCheckBox.Checked)
            {
                dead_date.Value = дата_гибели_dateTimePicker.Value;
            }

            try
            {
                MainForm.put_sql(SQL, image_param, dead_date);

                if (ToAddForm)
                    MessageBox.Show("Данные успешно добавлены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Данные успешно изменены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Данные не корректны!\nПроверте правильность ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

    }
}
