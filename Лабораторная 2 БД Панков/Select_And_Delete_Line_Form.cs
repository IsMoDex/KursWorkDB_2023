using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков
{
    public partial class Select_And_Delete_Line_Form : Form
    {
        private string SelectedTable = null;
        public Select_And_Delete_Line_Form(string _SelectedTable)
        {
            if (_SelectedTable == null)
                throw new ArgumentNullException("Значения выбранной таблицы не могут быть null!");

            SelectedTable = _SelectedTable;
            InitializeComponent();
        }

        private void Select_And_Delete_Line_Form_Load(object sender, EventArgs e)
        {
            CurrentSelectTableLable.Text = $"Текущая таблица: {SelectedTable}";

            dataGridView1.DataSource = MainForm.getDataTable($"SELECT * FROM \"{SelectedTable}\"");
            CancelButton.Select();
        }

        private void DeleteLineButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Если нажмете Да, все выбранные вами данные из таблицы будут удалены!\nВсе свазанные данные так-же будут удалены!\nВы уверены?", "Вопрос",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ///
                MessageBox.Show("Выбранные данные успешно удалены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;

                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                DataGridViewSelectedRowCollection SelectedRows = dataGridView1.SelectedRows;
                SelectedRows[0].Cells[0].Value = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
