using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms.GardenPlots_Table
{
    public partial class AddOrChangeEntryForm_GardenPlots : Form
    {
        public AddOrChangeEntryForm_GardenPlots()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_GardenPlots(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;

        private void AddOrChangeEntryForm_GardenPlots_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = "";
                SQL = $"SELECT \"номер_участка_в_саду\", \"регистрационный_номер_сада\" FROM \"{MainForm.GardenPlots}\" " +
                    $"WHERE \"код_участка\" = {Record_ID}";

                DataTable dt = MainForm.getDataTable(SQL);

                номер_участка_в_саду_numericUpDown.Value = Convert.ToDecimal(dt.Rows[0][0]);
                регистрационный_номер_сада_comboBox.Text = Convert.ToString(dt.Rows[0][1]);
            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Участки садов\"";

            getData();
        }

        private async void getData()
        {
            await Task.Run(() =>
            {
                string SQL = "";
                SQL = $"SELECT \"регистрационный_номер\" FROM \"{MainForm.Gardens}\"";

                DataTable dt = MainForm.getDataTable(SQL);

                var List = dt.AsEnumerable().Select(r => r.Field<Int64>("регистрационный_номер")).ToList();

                foreach (var number in List)
                {
                    try
                    {
                        регистрационный_номер_сада_comboBox.Invoke((MethodInvoker)delegate
                        {
                            регистрационный_номер_сада_comboBox.Items.Add(number);
                        });
                    } catch { return; }
                }

            });
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";

            if (ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.GardenPlots}\" ( \"номер_участка_в_саду\", \"регистрационный_номер_сада\" ) VALUES " +
                    $"( '{номер_участка_в_саду_numericUpDown.Value}', '{регистрационный_номер_сада_comboBox.Text}' )";
            }
            else
            {
                SQL = $"UPDATE \"{MainForm.GardenPlots}\" SET " +
                    $"\"номер_участка_в_саду\" = '{номер_участка_в_саду_numericUpDown.Value}', \"регистрационный_номер_сада\" = '{регистрационный_номер_сада_comboBox.Text}' " +
                    $"WHERE \"код_участка\" = {Record_ID}";
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
