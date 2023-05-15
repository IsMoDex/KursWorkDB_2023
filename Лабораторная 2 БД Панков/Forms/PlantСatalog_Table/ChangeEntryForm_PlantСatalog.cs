using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms.PlantСatalog_Table
{
    /// <summary>
    /// Форма изменения записей таблицы "Каталог растений"
    /// </summary>
    public partial class ChangeEntryForm_PlantСatalog : Form
    {
        string ID;
        public ChangeEntryForm_PlantСatalog(string _ID)
        {
            ID = _ID;
            InitializeComponent();
        }

        private void ChangeEntryForm_PlantСatalog_Load(object sender, EventArgs e)
        {
            CenselButton.Select();

            var data = MainForm.getDataTable($"SELECT * FROM \"Каталог\" WHERE \"номер_растения_в_каталоге\" = {ID}");

            NamePlant.Text = data.Rows[0][1].ToString();
            NumberPlantSpecies.Text = data.Rows[0][2].ToString();
            PlantLifeSpan.Text = data.Rows[0][3].ToString();

            Annual.Checked = data.Rows[0][4].ToString().Equals("True") ? true : false;

            dataGridView1.DataSource = MainForm.getDataTable($"SELECT * FROM \"Растения\" WHERE \"номер_в_каталоге\" = {ID}");
        }
    }
}
