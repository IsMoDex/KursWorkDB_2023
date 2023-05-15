using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms.TypesOwnership_List
{
    /// <summary>
    /// Форма добавления/изменения записей в таблицу "Типы собственности"
    /// </summary>
    public partial class AddOrChangeEntryForm_TypesOwnership : Form
    {
        public AddOrChangeEntryForm_TypesOwnership()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_TypesOwnership(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;
        private void AddEntryForm_TypesOwnership_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = $"SELECT \"тип_собственности\" FROM \"{MainForm.Types_oweship}\" " +
                    $"WHERE \"код_собственности\" = {Record_ID}";

                тип_собственности_textBox.Text = Convert.ToString(MainForm.getDataTable(SQL).Rows[0][0]);

            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Типы собственности\"";
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";

            if (ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.Types_oweship}\" ( \"тип_собственности\" ) VALUES " +
                    $"( '{тип_собственности_textBox.Text}' )";
            }
            else
            {
                SQL = $"UPDATE \"{MainForm.Types_oweship}\" SET " +
                    $"\"тип_собственности\" = '{тип_собственности_textBox.Text}' " +
                    $"WHERE \"код_собственности\" = {Record_ID}";
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
