using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms.PlantedPlant_Table
{
    public partial class ChangeEntryForm_PlantedPlant : Form
    {
        /// <summary>
        /// Форма изменения записей таблицы "Посаженные растения"
        /// </summary>
        public ChangeEntryForm_PlantedPlant()
        {
            InitializeComponent();
        }

        private void ChangeEntryForm_PlantedPlant_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = !checkBox1.Checked;
        }
    }
}
