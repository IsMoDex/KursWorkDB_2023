using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков.Forms.HistoryPP_Table
{
    /// <summary>
    /// Форма изменения записей таблицы "Участки садов"
    /// </summary>
    public partial class ChangeEntryFormForm_TreatmentСP : Form
    {
        string ID;
        public ChangeEntryFormForm_TreatmentСP(string _ID)
        {
            ID = _ID;
            InitializeComponent();
        }

        private void ChangeEntryFormForm_HistoryPP_Load(object sender, EventArgs e)
        {
            CenselButton.Select();

            var data = MainForm.getDataTable($"SELECT * FROM \"Средства ухода\" WHERE \"код_средства\" = {ID}");

            NameTool.Text = data.Rows[0][1].ToString();
            UnitMeasurement.Text = data.Rows[0][2].ToString();
            CostTool.Text = data.Rows[0][3].ToString();

            dataGridView1.DataSource = MainForm.getDataTable($"SELECT * FROM \"История ухода\" WHERE \"код_средства\" = {ID}");
        }
    }
}
