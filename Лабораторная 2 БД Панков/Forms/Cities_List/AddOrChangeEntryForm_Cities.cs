using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms.Cities_List
{
    public partial class AddOrChangeEntryForm_Cities : Form
    {
        /// <summary>
        /// Форма добавления/изменения записей в таблицу "Города"
        /// </summary>
        public AddOrChangeEntryForm_Cities()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_Cities(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;
        private void AddOrChangeEntryForm_Cities_2_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = $"SELECT \"название_города\" FROM \"{MainForm.Cities}\" " +
                    $"WHERE \"код_города\" = {Record_ID}";

                название_города_textBox.Text = Convert.ToString(MainForm.getDataTable(SQL).Rows[0][0]);

            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Города\"";
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";

            if (ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.Cities}\" ( \"название_города\" ) VALUES " +
                    $"( '{название_города_textBox.Text}' )";
            }
            else
            {
                SQL = $"UPDATE \"{MainForm.Cities}\" SET " +
                    $"\"название_города\" = '{название_города_textBox.Text}' " +
                    $"WHERE \"код_города\" = {Record_ID}";
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
