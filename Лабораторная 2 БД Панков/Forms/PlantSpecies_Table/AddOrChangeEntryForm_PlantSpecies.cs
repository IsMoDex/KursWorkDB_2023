using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms
{
    public partial class AddOrChangeEntryForm_PlantSpecies : Form
    {
        /// <summary>
        /// Форма добавления/изменения записей в таблицу "Виды растений"
        /// </summary>
        public AddOrChangeEntryForm_PlantSpecies()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_PlantSpecies(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;

        //long CodeFamilyOriginal = 0;
        //List<long> CodesFamalys = new List<long>();
        string OldName = "";
        private void AddEntryFormForm_PlantSpecies_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = "";
                SQL = $"SELECT \"название_вида\", \"{MainForm.PlantSpecies}\".\"код_семейства\", \"название_семейства\" FROM \"{MainForm.PlantSpecies}\" " +
                    $"JOIN \"{MainForm.PlantFamilies}\" ON \"{MainForm.PlantFamilies}\".\"код_семейства\" = \"{MainForm.PlantSpecies}\".\"код_семейства\" " +
                    $"WHERE \"код_вида\" = {Record_ID}";

                DataTable dt = MainForm.getDataTable(SQL);

                OldName = название_вида_textBox.Text = Convert.ToString(dt.Rows[0][0]);

                //CodeFamilyOriginal = Convert.ToInt64(dt.Rows[0][1]);
                название_семейства_comboBox.Text = Convert.ToString(dt.Rows[0][2]);

            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Виды растений\"";

            getData();
        }

        private async void getData()
        {
            await Task.Run(() =>
            {
                string SQL = "";
                SQL = $"SELECT \"код_семейства\", \"название_семейства\" FROM \"{MainForm.PlantFamilies}\"";

                //CodesFamalys = MainForm.getDataTable(SQL).AsEnumerable().Select(r => r.Field<Int64>("код_семейства")).ToList();
                var List = MainForm.getDataTable(SQL).AsEnumerable().Select(r => r.Field<string>("название_семейства")).ToList();

                foreach(var item in List)
                {
                    try
                    {
                        название_семейства_comboBox.Invoke((MethodInvoker)delegate
                        {
                            название_семейства_comboBox.Items.Add(item);
                        });
                    } catch { return; }
                }

            });
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";
            //string SelectFamily = "";//название_должности_comboBox.SelectedIndex == -1 ? PositionOriginal.ToString() : PositionsID[название_должности_comboBox.SelectedIndex].ToString();

            if (ToAddForm)
            {
                //SelectFamily = название_семейства_comboBox.SelectedIndex == -1 ? "NULL" : CodesFamalys[название_семейства_comboBox.SelectedIndex].ToString();
                //SQL = $"INSERT INTO \"{MainForm.PlantSpecies}\" ( \"название_вида\", \"код_семейства\" ) VALUES " +
                //    $"( '{название_вида_textBox.Text}', '{SelectFamily}' )";
                SQL = $"INSERT INTO plant_species_view VALUES( '{название_вида_textBox.Text}', '{название_семейства_comboBox.Text}' );";
            }
            else
            {
                //SelectFamily = название_семейства_comboBox.SelectedIndex == -1 ? CodeFamilyOriginal.ToString() : CodesFamalys[название_семейства_comboBox.SelectedIndex].ToString();
                //SQL = $"UPDATE \"{MainForm.PlantSpecies}\" SET " +
                //    $"\"название_вида\" = '{название_вида_textBox.Text}', \"код_семейства\" = '{SelectFamily}' " +
                //    $"WHERE \"код_вида\" = {Record_ID}";
                SQL = $"UPDATE plant_species_view SET " +
                    $"\"Название вида\" = '{название_вида_textBox.Text}', " +
                    $"\"Название семейства\" = '{название_семейства_comboBox.Text}'" +
                    $"WHERE \"Название вида\" = '{OldName}';";
            }

            try
            {
                MainForm.put_sql(SQL);

                if (ToAddForm)
                    MessageBox.Show("Данные успешно добавлены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Данные успешно изменены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}