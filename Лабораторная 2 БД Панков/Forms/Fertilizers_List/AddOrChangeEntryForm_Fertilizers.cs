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
    /// <summary>
    /// Форма добавления/изменения записей в таблицу "Средства обработки"
    /// </summary>
    public partial class AddOrChangeEntryForm_TreatmentСP : Form
    {
        public AddOrChangeEntryForm_TreatmentСP()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_TreatmentСP(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;

        private void AddEntryFormForm_HistoryPP_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = "";
                SQL = $"SELECT \"название_средства\", \"единица_измерения_средства\", \"стоимость_средства\" FROM \"{MainForm.Fertilizers}\" " +
                    $"WHERE \"код_средства\" = {Record_ID}";

                DataTable dt = MainForm.getDataTable(SQL);

                название_средства_textBox.Text = Convert.ToString(dt.Rows[0][0]);
                единица_измерения_средства_comboBox.Text = Convert.ToString(dt.Rows[0][1]);
                стоимость_средства_numericUpDown.Value = Convert.ToDecimal(dt.Rows[0][2]);

            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Средства обработки\"";

            единица_измерения_средства_comboBox.KeyPress += (sen, ev) => ev.Handled = true;

            getData();
        }

        private async void getData()
        {
            единица_измерения_средства_comboBox.DataSource = new List<string>() { "Кг", "Мг", "Т" };
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";

            if (ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.Fertilizers}\" ( \"название_средства\", \"единица_измерения_средства\", \"стоимость_средства\" ) VALUES " +
                    $"( '{название_средства_textBox.Text}', '{единица_измерения_средства_comboBox.Text}', '{стоимость_средства_numericUpDown.Value}' )";
            }
            else
            {
                SQL = $"UPDATE \"{MainForm.Fertilizers}\" SET " +
                    $"\"название_средства\" = '{название_средства_textBox.Text}', \"единица_измерения_средства\" = '{единица_измерения_средства_comboBox.Text}', \"стоимость_средства\" = '{стоимость_средства_numericUpDown.Value}' " +
                    $"WHERE \"код_средства\" = {Record_ID}";
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
