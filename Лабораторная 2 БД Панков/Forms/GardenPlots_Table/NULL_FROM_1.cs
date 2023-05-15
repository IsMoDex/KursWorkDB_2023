using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.AddEntrysForms
{
    /// <summary>
    /// Форма добавления/изменения записей в таблицу "Участки садов"
    /// </summary>
    public partial class NULL_FROM_1 : Form
    {
        public NULL_FROM_1()
        {
            InitializeComponent();
        }
        public NULL_FROM_1(object value) : this()
        {
            ToAddForm = false;
            Record_ID = (int)value;
        }

        bool ToAddForm = true;
        int Record_ID = 0;

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

                foreach(var number in List)
                {
                    регистрационный_номер_сада_comboBox.Invoke((MethodInvoker)delegate
                    {
                        регистрационный_номер_сада_comboBox.Items.Add(number);
                    });
                }

            });
        }
    }
}
