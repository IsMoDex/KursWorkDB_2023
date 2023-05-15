using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2_БД_Панков
{
    public partial class CompositeForm : Form
    {
        string TableName;
        public CompositeForm(string _TableName)
        {
            InitializeComponent();
            TableName = _TableName;
        }

        private void CompositeForm_Load(object sender, EventArgs e)
        {
            string SQL_SELECTED = "";

            if(TableName != null && TableName.Equals(MainForm.PlantCatalog))
            {
                SQL_SELECTED = $"SELECT \"номер_растения_в_каталоге\", \"название_растения\", \"срок_жизни_растения\", \"название_вида\", \"однолетнее\", \"название_семейства\" FROM \"{MainForm.PlantCatalog}\" " +
                        $"JOIN \"{MainForm.PlantSpecies}\" ON \"{MainForm.PlantSpecies}\".\"код_вида\" = \"{MainForm.PlantCatalog}\".\"код_вида\" " +
                        $"JOIN \"{MainForm.PlantFamilies}\" ON \"{MainForm.PlantFamilies}\".\"код_семейства\" = \"{MainForm.PlantSpecies}\".\"код_семейства\" "; //JOIN \"{}\" ON \"{}\".\"\" = \"{}\".\"\" 
            }
            else if(TableName != null && TableName.Equals(MainForm.Fertilizers))
            {
                SQL_SELECTED = $"SELECT * FROM \"{MainForm.Fertilizers}\" ";
            }
            else
            {
                this.Close();
                this.Dispose();
                MessageBox.Show("Не верный параметр!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView_main.DataSource = MainForm.getDataTable(SQL_SELECTED);
            dataGridView_main.Columns[0].Name = "ID";

            this.Text = $"Композитная форма для таблицы \"{TableName}\"";

            CountEntryLable.Text = "| Записей: " + dataGridView_main.Rows.Count;

            SetTableBehavior(dataGridView_main);
            SetTableBehavior(dataGridView_sub);
        }

        private void SetTableBehavior(DataGridView dataGridView)
        {
            if (dataGridView == null) return;

            dataGridView.MouseWheel += (sen, ev) =>
            {
                DataGridView gv = sen as DataGridView;
                if (Control.ModifierKeys == Keys.Control)
                {
                    if (ev.Delta > 0)
                        gv.Font = new Font(gv.Font.Name, gv.Font.Size + 1);
                    else if (gv.Font.Size - 1 > 1)
                        gv.Font = new Font(gv.Font.Name, gv.Font.Size - 1);
                }
            };
            dataGridView.SelectionChanged += (sen, ev) =>
            {
                DataGridView gv = sen as DataGridView;
                if (gv != null && gv.SelectedCells.Count > 0)
                {
                    foreach (DataGridViewCell cell in gv.SelectedCells)
                    {
                        gv.Rows[cell.RowIndex].Selected = true;
                    }
                }
            };
            dataGridView.KeyPress += (sen, ev) =>
            {
                DataGridView gv = sen as DataGridView;
                if (ev.KeyChar == (char)Keys.Escape)
                {
                    foreach (DataGridViewRow row in gv.SelectedRows)
                    {
                        gv.Rows[row.Index].Selected = false;
                    }
                }
            };
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            
            ToolStripMenuItem CorrectWidth = new ToolStripMenuItem();
            CorrectWidth.Text = "Корректировать размер";
            CorrectWidth.Click += (sen, ev) =>
            {
                DataTable dt = dataGridView.DataSource as DataTable;
                using (var gfx = dataGridView.CreateGraphics())
                {
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        dataGridView.Columns[i].Width = 0;

                        string[] colStringCollection = dt.AsEnumerable().Where(r => r.Field<object>(i) != null).Select(r => r.Field<object>(i).ToString()).Concat(new string[] { dt.Columns[i].ColumnName }).ToArray();

                        colStringCollection = colStringCollection.OrderBy((x) => x.Length).ToArray();
                        string longestColString = colStringCollection.Last();
                        var colWidth = gfx.MeasureString(longestColString, dataGridView.Font);
                        if (colWidth.Width > dataGridView.Columns[i].HeaderCell.Size.Width)
                        {
                            dataGridView.Columns[i].Width = (int)colWidth.Width + 10;
                        }
                        else
                        {
                            dataGridView.Columns[i].Width = dataGridView.Columns[i].HeaderCell.Size.Width;
                        }
                    }
                }
            };
            contextMenu.Items.Add(CorrectWidth);

            dataGridView.ContextMenuStrip = contextMenu;
        }

        private void dataGridView_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                string SQL_SELECTED = "";

                dataGridView_main.Rows[e.RowIndex].Selected = true;
                string Value = dataGridView_main.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                if (TableName.Equals(MainForm.PlantCatalog))
                {
                    //dataGridView_sub.DataSource = MainForm.getData($"SELECT * FROM \"Растения\" WHERE \"номер_в_каталоге\" = {Value}");
                    SQL_SELECTED = $"SELECT \"код_растения\", \"номер_участка_в_саду\", \"регистрационный_номер_сада\", \"название_растения\", \"номер_в_каталоге\", \"срок_жизни_растения\", \"однолетнее\", \"фото_растения\", \"дата_посадки\", \"дата_гибели\", \"стоимость_саженца\", \"условия_ухода_и_содержания\" FROM \"{MainForm.Plants}\" " +
                       $"JOIN \"{MainForm.GardenPlots}\" ON \"{MainForm.GardenPlots}\".\"код_участка\" = \"{MainForm.Plants}\".\"код_участка\" " +
                       $"JOIN \"{MainForm.PlantCatalog}\" ON \"{MainForm.PlantCatalog}\".\"номер_растения_в_каталоге\" = \"{MainForm.Plants}\".\"номер_в_каталоге\" " +
                       $"WHERE \"номер_в_каталоге\" = {Value}";

                }
                else if (TableName.Equals(MainForm.Fertilizers))
                {
                    //dataGridView_sub.DataSource = MainForm.getData($"SELECT * FROM \"История ухода\" WHERE \"код_средства\" = {Value}");
                    SQL_SELECTED = $"SELECT \"код_записи\", \"{MainForm.CareHistory}\".\"код_растения\", \"название_растения\", \"дата_обработки\", \"{MainForm.CareHistory}\".\"код_средства\", \"название_средства\", \"количество_упоковок\", \"{MainForm.CareHistory}\".\"код_сотрудника\", \"фамилия\", \"имя\", \"отчество\" FROM \"{MainForm.CareHistory}\" " +
                        $"JOIN \"{MainForm.Plants}\" ON \"{MainForm.Plants}\".\"код_растения\" = \"{MainForm.CareHistory}\".\"код_растения\" " +
                        $"JOIN \"{MainForm.PlantCatalog}\" ON \"{MainForm.PlantCatalog}\".\"номер_растения_в_каталоге\" = \"{MainForm.Plants}\".\"номер_в_каталоге\" " +
                        $"JOIN \"{MainForm.Fertilizers}\" ON \"{MainForm.Fertilizers}\".\"код_средства\" = \"{MainForm.CareHistory}\".\"код_средства\" " +
                        $"JOIN \"{MainForm.Stuff}\" ON \"{MainForm.Stuff}\".\"код_сотрудника\" = \"{MainForm.CareHistory}\".\"код_сотрудника\" ";
                }

                dataGridView_sub.DataSource = MainForm.getDataTable(SQL_SELECTED);
                CountEntry_2_Lable.Text = "| Записей: " + dataGridView_sub.Rows.Count;
            }
        }

        private void CompositeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dataGridView_main.Dispose();
            this.dataGridView_sub.Dispose();
            this.Dispose();
        }
    }
}
