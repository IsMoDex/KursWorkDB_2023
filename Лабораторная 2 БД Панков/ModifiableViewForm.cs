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
    public partial class ModifiableViewForm : Form
    {
        public ModifiableViewForm()
        {
            InitializeComponent();
        }

        private void ModifiableViewForm_Load(object sender, EventArgs e)
        {
            getData();
            SetTableBehavior(dataGridView_DB_Table);
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
            dataGridView.KeyPress += (sen, ev) =>
            {
                DataGridView gv = sen as DataGridView;
                if (ev.KeyChar == (char)Keys.Escape)
                {
                    foreach (DataGridViewCell cell in gv.SelectedCells)
                    {
                        cell.Selected = false;
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

        private async void AddOrChangeEntryButton_Click(object sender, EventArgs e)
        {
            string SQL = "";

            SQL = $"INSERT INTO plant_species_view VALUES('{название_вида_textBox.Text}','{название_семейства_comboBox.Text}')";

            try
            {
                MainForm.put_sql(SQL);
                MessageBox.Show("Данные успешно добавлены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await Task.Run(() =>
                {
                    SQL = "SELECT * FROM plant_species_view";
                    DataTable dt = MainForm.getDataTable(SQL);
                    dataGridView_DB_Table.Invoke((MethodInvoker)delegate
                    {
                        dataGridView_DB_Table.DataSource = dt;
                        CountEtryLable.Text = "| Записей: " + dataGridView_DB_Table.Rows.Count;
                    });

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getData()
        {
            await Task.Run(() =>
            {
                string SQL = "";

                SQL = "SELECT * FROM plant_species_view";
                DataTable dt = MainForm.getDataTable(SQL);
                dataGridView_DB_Table.Invoke((MethodInvoker)delegate
                {
                    dataGridView_DB_Table.DataSource = dt;
                    CountEtryLable.Text = "| Записей: " + dataGridView_DB_Table.Rows.Count;
                });

                SQL = $"SELECT \"код_семейства\", \"название_семейства\" FROM \"{MainForm.PlantFamilies}\"";

                var List = MainForm.getDataTable(SQL).AsEnumerable().Select(r => r.Field<string>("название_семейства")).ToList();

                foreach (var item in List)
                {
                    try
                    {
                        название_семейства_comboBox.Invoke((MethodInvoker)delegate
                        {
                            название_семейства_comboBox.Items.Add(item);
                        });
                    }
                    catch { return; }
                }

            });
        }


    }
}
