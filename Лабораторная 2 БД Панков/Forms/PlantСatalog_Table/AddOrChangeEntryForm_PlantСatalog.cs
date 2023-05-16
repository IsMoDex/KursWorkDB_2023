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
    /// Форма добавления в таблицу "Каталог растений"
    /// </summary>
    public partial class AddOrChangeEntryForm_PlantСatalog : Form
    {
        public AddOrChangeEntryForm_PlantСatalog()
        {
            InitializeComponent();
        }
        public AddOrChangeEntryForm_PlantСatalog(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (long)value;
        }

        bool ToAddForm = true;
        long Record_ID = 0;

        int SpeciesOrginal = 0;
        List<long> SpeciesID = new List<long>();
        private void AddEntryForm_PlantСatalog_Load(object sender, EventArgs e)
        {
            if (ToAddForm)
                this.AddOrChangeEntryButton.Text = "Добавить";
            else
            {
                this.AddOrChangeEntryButton.Text = "Изменить";

                string SQL = "";
                SQL = $"SELECT \"название_растения\", \"{MainForm.PlantCatalog}\".\"код_вида\", \"название_вида\", \"срок_жизни_растения\", \"однолетнее\" FROM {MainForm.PlantCatalog} " +
                    $"JOIN \"{MainForm.PlantSpecies}\" ON \"{MainForm.PlantSpecies}\".\"код_вида\" = \"{MainForm.PlantCatalog}\".\"код_вида\" " +
                    $"WHERE \"номер_растения_в_каталоге\" = {Record_ID}";

                DataTable dt = MainForm.getDataTable(SQL);

                название_растения_textBox.Text = Convert.ToString(dt.Rows[0][0]);

                SpeciesOrginal = Convert.ToInt32(dt.Rows[0][1]);
                название_вида_comboBox.Text = Convert.ToString(dt.Rows[0][2]);

                срок_жизни_растения_numericUpDown.Value = Convert.ToDecimal(dt.Rows[0][3]);
                однолетнее_checkBox.Checked = Convert.ToBoolean(dt.Rows[0][4]);

            }

            this.Text = "Форма добавления/изменения записей в таблицу \"Сотрудники\"";

            getData();
        }

        private async void getData()
        {
            await Task.Run(() =>
            {
                string SQL = "";
                SQL = $"SELECT \"код_вида\", \"название_вида\" FROM \"{MainForm.PlantSpecies}\"";
                DataTable dt = MainForm.getDataTable(SQL);

                SpeciesID = dt.AsEnumerable().Select(r => r.Field<Int64>("код_вида")).ToList();

                var List = dt.AsEnumerable().Select(r => r.Field<string>("название_вида")).ToList();

                foreach (var item in List)
                {
                    try
                    {
                        название_вида_comboBox.Invoke((MethodInvoker)delegate
                        {
                            название_вида_comboBox.Items.Add(item);
                        });
                    }
                    catch { return; }
                }
            });
        }

        private void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";
            string SelectSpecies = "";//название_должности_comboBox.SelectedIndex == -1 ? PositionOriginal.ToString() : PositionsID[название_должности_comboBox.SelectedIndex].ToString();

            if (ToAddForm)
            {
                SelectSpecies = название_вида_comboBox.SelectedIndex == -1 ? "NULL" : SpeciesID[название_вида_comboBox.SelectedIndex].ToString();
                SQL = $"INSERT INTO \"{MainForm.PlantCatalog}\" ( \"название_растения\", \"код_вида\", \"срок_жизни_растения\", \"однолетнее\" ) VALUES " +
                    $"( '{название_растения_textBox.Text}', '{SelectSpecies}', '{срок_жизни_растения_numericUpDown.Value}', '{однолетнее_checkBox.Checked}' )";
            }
            else
            {
                SelectSpecies = название_вида_comboBox.SelectedIndex == -1 ? SpeciesOrginal.ToString() : SpeciesID[название_вида_comboBox.SelectedIndex].ToString();
                SQL = $"UPDATE \"{MainForm.PlantCatalog}\" SET " +
                    $"\"название_растения\" = '{название_растения_textBox.Text}',  \"код_вида\" = '{SelectSpecies}',  \"срок_жизни_растения\" = '{срок_жизни_растения_numericUpDown.Value}',  \"однолетнее\" = '{однолетнее_checkBox.Checked}' " +
                    $"WHERE \"номер_растения_в_каталоге\" = {Record_ID}";
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
