using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Лабораторная_2_БД_Панков.Forms
{
    public partial class AddOrChangeEntryForm_Staff : Form
    {
        /// <summary>
        /// Форма добавления/изменения записей в таблицу "Сотрудники"
        /// </summary>
        public AddOrChangeEntryForm_Staff()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_Staff(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;

        int PositionOriginal = 0;
        List<int> PositionsID = new List<int>();
        private void AddEntryForm_Staff_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = "";
                SQL = $"SELECT \"регистрационный_номер_сада\", \"фамилия\", \"имя\", \"отчество\", \"дата_рождения\", \"номер_должности\", \"название_должности\", \"оклад\", \"стаж_работы\" FROM \"{MainForm.Stuff}\" " +
                    $"JOIN \"{MainForm.Positions}\" ON \"{MainForm.Positions}\".\"код_должности\" = \"{MainForm.Stuff}\".\"номер_должности\" " +
                    $"WHERE \"код_сотрудника\" = {Record_ID}";

                DataTable dt = MainForm.getDataTable(SQL);

                регистрационный_номер_сада_comboBox.Text = Convert.ToString(dt.Rows[0][0]);
                фамилия_textBox.Text = Convert.ToString(dt.Rows[0][1]);
                имя_textBox.Text = Convert.ToString(dt.Rows[0][2]);
                отчество_textBox.Text = Convert.ToString(dt.Rows[0][3]);
                дата_рождения_dateTimePicker.Value = DateTime.Parse(Convert.ToString(dt.Rows[0][4]));

                PositionOriginal = Convert.ToInt32(dt.Rows[0][5]);
                название_должности_comboBox.Text = Convert.ToString(dt.Rows[0][6]);

                оклад_numericUpDown.Value = Convert.ToDecimal(dt.Rows[0][7]);
                стаж_работы_numericUpDown.Text = Convert.ToString(dt.Rows[0][8]);
            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Сотрудники\"";

            getData();
        }

        private async void getData()
        {
            await Task.Run(() =>
            {
                string SQL = "";
                SQL = $"SELECT \"код_должности\", \"название_должности\" FROM \"{MainForm.Positions}\"";
                DataTable dt = MainForm.getDataTable(SQL);

                PositionsID = dt.AsEnumerable().Select(r => r.Field<Int32>("код_должности")).ToList();

                var List2 = dt.AsEnumerable().Select(r => r.Field<string>("название_должности")).ToList();

                foreach (var item in List2)
                {
                    try
                    {
                        название_должности_comboBox.Invoke((MethodInvoker)delegate
                        {
                            название_должности_comboBox.Items.Add(item);
                        });
                    }
                    catch { return; }
                }

                SQL = $"SELECT \"регистрационный_номер\" FROM \"{MainForm.Gardens}\"";
                dt = MainForm.getDataTable(SQL);

                var List = dt.AsEnumerable().Select(r => r.Field<Int64>("регистрационный_номер")).ToArray();//dt.Rows[0].Field<string>("регистрационный_номер").ToList();

                foreach(var item in List )
                {
                    try
                    {
                        регистрационный_номер_сада_comboBox.Invoke((MethodInvoker)delegate
                        {
                            регистрационный_номер_сада_comboBox.Items.Add(item);
                        });
                    } catch { return; }
                }
            });
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";
            string SelectPosition = "";//название_должности_comboBox.SelectedIndex == -1 ? PositionOriginal.ToString() : PositionsID[название_должности_comboBox.SelectedIndex].ToString();

            if (ToAddForm)
            {
                SelectPosition = название_должности_comboBox.SelectedIndex == -1 ? "NULL" : PositionsID[название_должности_comboBox.SelectedIndex].ToString();
                SQL = $"INSERT INTO \"{MainForm.Stuff}\" ( \"регистрационный_номер_сада\", \"фамилия\", \"имя\", \"отчество\", \"дата_рождения\", \"номер_должности\", \"оклад\", \"стаж_работы\" ) VALUES " +
                    $"( '{регистрационный_номер_сада_comboBox.Text}', '{фамилия_textBox.Text}', '{имя_textBox.Text}', '{отчество_textBox.Text}', '{дата_рождения_dateTimePicker.Value.ToString("dd-MM-yyyy")}', '{SelectPosition}', '{оклад_numericUpDown.Value}', '{стаж_работы_numericUpDown.Value}' )";
            }
            else
            {
                SelectPosition = название_должности_comboBox.SelectedIndex == -1 ? PositionOriginal.ToString() : PositionsID[название_должности_comboBox.SelectedIndex].ToString();
                SQL = $"UPDATE \"{MainForm.Stuff}\" SET " +
                    $"\"фамилия\" = '{фамилия_textBox.Text}', \"имя\" = '{имя_textBox.Text}', \"отчество\" = '{отчество_textBox.Text}', \"дата_рождения\" = '{дата_рождения_dateTimePicker.Value.ToString("dd-MM-yyyy")}', \"номер_должности\" = '{SelectPosition}', \"оклад\" = '{оклад_numericUpDown.Value}', \"стаж_работы\" = '{стаж_работы_numericUpDown.Value}' " +
                    $"WHERE \"код_сотрудника\" = {Record_ID}"; //\"регистрационный_номер_сада\" = '{регистрационный_номер_сада_comboBox.Text}', 
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
