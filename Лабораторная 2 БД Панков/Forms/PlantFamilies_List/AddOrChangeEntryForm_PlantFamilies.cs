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
    public partial class AddOrChangeEntryForm_PlantFamilies : Form
    {
        /// <summary>
        /// Форма добавления/изменения записей в таблицу "Семейства растений"
        /// </summary>
        public AddOrChangeEntryForm_PlantFamilies()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_PlantFamilies(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;
        private void AddEntryForm_PlantFamilies_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = $"SELECT \"название_семейства\" FROM \"{MainForm.PlantFamilies}\" " +
                    $"WHERE \"код_семейства\" = {Record_ID}";

                название_семейства_textBox.Text = Convert.ToString(MainForm.getDataTable(SQL).Rows[0][0]);

            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Семейства растений\"";
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";

            if (ToAddForm)
            {
                SQL = $"INSERT INTO \"{MainForm.PlantFamilies}\" ( \"название_семейства\" ) VALUES " +
                    $"( '{название_семейства_textBox.Text}' )";       
            }
            else
            {
                SQL = $"UPDATE \"{MainForm.PlantFamilies}\" SET " +
                    $"\"название_семейства\" = '{название_семейства_textBox.Text}' " +
                    $"WHERE \"код_семейства\" = {Record_ID}";
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
