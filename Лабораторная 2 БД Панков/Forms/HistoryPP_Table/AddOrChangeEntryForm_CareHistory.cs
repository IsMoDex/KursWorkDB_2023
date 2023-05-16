using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms.HistoryPP_Table
{
    public partial class AddOrChangeEntryForm_CareHistory : Form
    {
        /// <summary>
        /// Форма добавления/изменения записей в таблицу "История обработки растений"
        /// </summary>
        public AddOrChangeEntryForm_CareHistory()
        {
            InitializeComponent();
        }

        public AddOrChangeEntryForm_CareHistory(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;

        int FretilizerOriginal = 0;
        int StuffOriginal = 0;
        volatile List<long> StuffID = new List<long>();
        volatile List<long> FertilizerID = new List<long>();
        private void AddEntryForm_HistoryPP_Load(object sender, EventArgs e)
        {
            string SQL = "";

            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                SQL = $"SELECT \"код_растения\", \"дата_обработки\", \"название_средства\",  \"фамилия\", \"имя\", \"отчество\", \"количество_упоковок\", \"{MainForm.CareHistory}\".\"код_средства\", \"{MainForm.CareHistory}\".\"код_сотрудника\" FROM \"{MainForm.CareHistory}\" " +
                        $"JOIN \"{MainForm.Fertilizers}\" ON \"{MainForm.Fertilizers}\".\"код_средства\" = \"{MainForm.CareHistory}\".\"код_средства\" " +
                        $"JOIN \"{MainForm.Stuff}\" ON \"{MainForm.Stuff}\".\"код_сотрудника\" = \"{MainForm.CareHistory}\".\"код_сотрудника\" " +
                        $"WHERE \"код_записи\" = {Record_ID}";

                DataTable dt = MainForm.getDataTable(SQL);

                код_растения_comboBox.Text = Convert.ToString(dt.Rows[0][0]);

                //int[] ArrayDate = Regex.Replace(Convert.ToString(dt.Rows[0][1]), @"\s.+", "").Split('.').Select(x => Convert.ToInt32(x)).ToArray();
                //дата_обработки_dateTimePicker.Value = new DateTime(ArrayDate[2], ArrayDate[1], ArrayDate[0]);

                дата_обработки_dateTimePicker.Value = DateTime.Parse(Convert.ToString(dt.Rows[0][1]));

                название_средства_comboBox.Text = Convert.ToString(dt.Rows[0][2]);
                фио_сотрудника_comboBox.Text = $"{Convert.ToString(dt.Rows[0][3])} {Convert.ToString(dt.Rows[0][4])} {Convert.ToString(dt.Rows[0][5])}";

                количество_упоковок_numericUpDown.Value = Convert.ToDecimal(dt.Rows[0][6]);

                FretilizerOriginal = Convert.ToInt32(dt.Rows[0][7]);
                StuffOriginal = Convert.ToInt32(dt.Rows[0][8]);
                
            }

            this.Text = "Форма добавления/изменения записей в таблицу \"История обработки растений\"";

            getData();
        }

        private async void getData() 
        {
            await Task.Run(() =>
            {
                string SQL = "";

                SQL = $"SELECT \"код_средства\", \"название_средства\" FROM \"{MainForm.Fertilizers}\"";
                DataTable dt = MainForm.getDataTable(SQL);

                FertilizerID = dt.AsEnumerable().Select(r => r.Field<Int64>("код_средства")).ToList();
                var NameFetilizers = dt.AsEnumerable().Select(r => r.Field<String>("название_средства")).ToList();

                foreach (String name in NameFetilizers)
                {
                    try
                    {
                        название_средства_comboBox.Invoke((MethodInvoker)delegate
                        {
                            название_средства_comboBox.Items.Add(name);
                        });
                    }
                    catch (Exception) { return; }
                }

                SQL = $"SELECT \"код_растения\" FROM {MainForm.Plants}";

                var CodePlants = MainForm.getDataTable(SQL).AsEnumerable().Select(r => r.Field<Int64>("код_растения")).ToList();

                foreach (long code in CodePlants)
                {
                    try
                    {
                        код_растения_comboBox.Invoke((MethodInvoker)delegate
                        {
                            код_растения_comboBox.Items.Add(code);
                        });
                    }
                    catch { return; }
                }

                SQL = $"SELECT \"код_сотрудника\", \"фамилия\", \"имя\", \"отчество\" FROM \"{MainForm.Stuff}\"";
                dt = MainForm.getDataTable(SQL);

                StuffID = dt.AsEnumerable().Select(r => r.Field<Int64>("код_сотрудника")).ToList();
                var FirstNames = dt.AsEnumerable().Select(r => r.Field<String>("фамилия")).ToList();
                var Names = dt.AsEnumerable().Select(r => r.Field<String>("имя")).ToList();
                var Patronymics = dt.AsEnumerable().Select(r => r.Field<String>("отчество")).ToList();

                for(int i = 0; i < FirstNames.Count; ++i)
                {
                    try
                    {
                        фио_сотрудника_comboBox.Invoke((MethodInvoker)delegate
                        {
                            фио_сотрудника_comboBox.Items.Add($"{FirstNames[i]} {Names[i]} {Patronymics[i]}");
                        });
                    }
                    catch { return; }
                }

            });
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            int StuffSelect = фио_сотрудника_comboBox.SelectedIndex;
            int FirtilizerSelect = название_средства_comboBox.SelectedIndex;

            string SQL = "";

            if (ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.CareHistory}\" ( \"код_растения\",  \"дата_обработки\", \"код_средства\", \"код_сотрудника\", \"количество_упоковок\" ) VALUES " +
                    $"( {код_растения_comboBox.Text}, \'{дата_обработки_dateTimePicker.Value.ToString("dd-MM-yyyy")}\', {(FirtilizerSelect == -1 ? "NULL" : FertilizerID[FirtilizerSelect].ToString())}, {(StuffSelect == -1 ? "NULL" : StuffID[StuffSelect].ToString())}, {количество_упоковок_numericUpDown.Value} );";
            }
            else
            {
                
                SQL = $"UPDATE \"{MainForm.CareHistory}\" SET " +
                    $"\"код_растения\" = \'{код_растения_comboBox.Text}\', \"дата_обработки\" = \'{дата_обработки_dateTimePicker.Value.ToString("dd-MM-yyyy")}\', \"код_средства\" = \'{(FirtilizerSelect == -1 ? FretilizerOriginal : FertilizerID[FirtilizerSelect])}\', \"код_сотрудника\" = \'{(StuffSelect == -1 ? StuffOriginal : StuffID[StuffSelect])}\', \"количество_упоковок\" = \'{количество_упоковок_numericUpDown.Value}\' " +
                    $"WHERE \"код_записи\" = {Record_ID}";

                //{(FirtilizerSelect == -1 ? SelectedFretilizer : FertilizerID[FirtilizerSelect])}, {(StuffSelect == -1 ? SelectedStuff : StuffID[StuffSelect])}
            }

            try
            {
                MainForm.put_sql(SQL);

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
