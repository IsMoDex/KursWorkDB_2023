using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков
{
    /// <summary>
    /// "Форма добавления/изменения записей в таблицу "Информация о садах";
    /// </summary>
    public partial class AddOrChangeEntryForm_IAG : Form
    {
        public AddOrChangeEntryForm_IAG()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_IAG(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;

        int CityCodeOriginal = 0;
        int TypeOwnershipOriginal = 0;
        List<long> CityCodes = new List<long>();
        List<long> TypeOwnershipCodes = new List<long>();
        private void AddOrChangeEntryForm_IAG_Load(object sender, EventArgs e)
        {
            год_открытия_numericUpDown.Maximum = DateTime.Now.Year;

            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = "";
                SQL = $"SELECT \"регистрационный_номер\", \"название_сада\", \"{MainForm.Gardens}\".\"код_города\", \"название_города\", \"код_типа_собственности\", \"тип_собственности\", \"год_открытия\", \"телефон\", \"доп_источники_финансирования\" FROM \"{MainForm.Gardens}\" " +
                    $"JOIN \"{MainForm.Cities}\" ON \"{MainForm.Cities}\".\"код_города\" = \"{MainForm.Gardens}\".\"код_города\" " +
                    $"JOIN \"{MainForm.Types_oweship}\" ON \"{MainForm.Types_oweship}\".\"код_собственности\" = \"{MainForm.Gardens}\".\"код_типа_собственности\" " +
                    $"WHERE \"регистрационный_номер\" = {Record_ID}";

                DataTable dt = MainForm.getDataTable(SQL);

                регистрационный_номер_textBox.Text = Convert.ToString(dt.Rows[0][0]);
                название_сада_textBox.Text = Convert.ToString(dt.Rows[0][1]);

                CityCodeOriginal = Convert.ToInt32(dt.Rows[0][2]);
                название_города_comboBox.Text = Convert.ToString(dt.Rows[0][3]);

                TypeOwnershipOriginal = Convert.ToInt32(dt.Rows[0][4]);
                тип_собственности_comboBox.Text = Convert.ToString(dt.Rows[0][5]);

                год_открытия_numericUpDown.Value = Convert.ToDecimal(dt.Rows[0][6]);

                телефон_textBox.Text = Convert.ToString(dt.Rows[0][7]);
                доп_источники_финансирования_checkBox.Checked = Convert.ToBoolean(dt.Rows[0][8]);


            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Информация о садах\"";

            getData();
        }

        private async void getData()
        {
            await Task.Run(() =>
            {
                string SQL = "";
                DataTable dt;

                SQL = $"SELECT \"код_собственности\", \"тип_собственности\" FROM \"{MainForm.Types_oweship}\"";
                dt = MainForm.getDataTable(SQL);

                TypeOwnershipCodes = dt.AsEnumerable().Select(r => r.Field<Int64>("код_собственности")).ToList();
                var TypesOwnership = dt.AsEnumerable().Select(r => r.Field<string>("тип_собственности")).ToList();

                foreach (var type in TypesOwnership)
                {
                    try
                    {
                        тип_собственности_comboBox.Invoke((MethodInvoker)delegate
                        {
                            тип_собственности_comboBox.Items.Add(type);
                        });
                    }
                    catch { return; };
                }
                //тип_собственности_comboBox.Items.Add();

                SQL = $"SELECT \"код_города\", \"название_города\" FROM \"{MainForm.Cities}\"";
                dt = MainForm.getDataTable(SQL);

                CityCodes = dt.AsEnumerable().Select(r => r.Field<Int64>("код_города")).ToList();
                var CitysNames = dt.AsEnumerable().Select(r => r.Field<string>("название_города")).ToList();

                foreach(var City in CitysNames)
                {
                    try
                    {
                        название_города_comboBox.Invoke((MethodInvoker)delegate
                        {
                            название_города_comboBox.Items.Add(City);
                        });
                    }
                    catch { return; };
                }
                //название_города_comboBox.Items.Add();

            });
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            int CitySelect = название_города_comboBox.SelectedIndex;
            int TypeOwnershipSelect = тип_собственности_comboBox.SelectedIndex;

            string SQL = "";

            if (ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.Gardens}\" VALUES " +
                    $"( \'{регистрационный_номер_textBox.Text}\', \'{название_сада_textBox.Text}\', \'{(CitySelect == -1 ? "NULL" : CityCodes[CitySelect].ToString())}\', \'{(TypeOwnershipSelect == -1 ? "NULL" : TypeOwnershipCodes[TypeOwnershipSelect].ToString())}\', \'{год_открытия_numericUpDown.Value}\', \'{телефон_textBox.Text}\', \'{доп_источники_финансирования_checkBox.Checked}\' );";
            }
            else
            {
                SQL = $"UPDATE \"{MainForm.Gardens}\" SET " +
                    $"\"регистрационный_номер\" = \'{регистрационный_номер_textBox.Text}\', \"название_сада\" = \'{название_сада_textBox.Text}\', \"код_города\" = '{(CitySelect == -1 ? CityCodeOriginal : CityCodes[CitySelect])}', \"код_типа_собственности\" = \'{(TypeOwnershipSelect == -1 ? TypeOwnershipOriginal : TypeOwnershipCodes[TypeOwnershipSelect])}\', \"год_открытия\" = \'{год_открытия_numericUpDown.Value}\', \"телефон\" = \'{телефон_textBox.Text}\', \"доп_источники_финансирования\" = \'{доп_источники_финансирования_checkBox.Checked}\' " +
                    $"WHERE \"регистрационный_номер\" = {Record_ID}";

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
