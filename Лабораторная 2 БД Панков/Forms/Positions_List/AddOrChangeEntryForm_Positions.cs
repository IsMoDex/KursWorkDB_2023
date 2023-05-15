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
    /// Форма добавления/изменения записей в таблицу "Должности"
    /// </summary>
    public partial class AddOrChangeEntryForm_Positions : Form
    {
        public AddOrChangeEntryForm_Positions()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_Positions(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;
        private void AddOrChangeEntryForm_Positions_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = $"SELECT \"название_должности\" FROM \"{MainForm.Positions}\" " +
                    $"WHERE \"код_должности\" = {Record_ID}";

                название_должности_textBox.Text = Convert.ToString(MainForm.getDataTable(SQL).Rows[0][0]);

            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Должности\"";
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";

            if (ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.Positions}\" ( \"название_должности\" ) VALUES " +
                    $"( '{название_должности_textBox.Text}' )";
            }
            else
            {
                SQL = $"UPDATE \"{MainForm.Positions}\" SET " +
                    $"\"название_должности\" = '{название_должности_textBox.Text}' " +
                    $"WHERE \"код_должности\" = {Record_ID}";
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
