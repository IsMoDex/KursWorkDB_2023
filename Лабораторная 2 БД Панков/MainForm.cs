using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Npgsql;
using Лабораторная_2_БД_Панков.Forms;
using Лабораторная_2_БД_Панков.Forms.Cities_List;
using Лабораторная_2_БД_Панков.Forms.GardenPlots_Table;
using Лабораторная_2_БД_Панков.Forms.HistoryPP_Table;
using Лабораторная_2_БД_Панков.Forms.TypesOwnership_List;

namespace Лабораторная_2_БД_Панков
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ///Таблицы
        public const string Gardens = "Сады";
        public const string Stuff = "Сотрудники";
        public const string GardenPlots = "Участки";
        public const string Plants = "Растения";
        public const string CareHistory = "История ухода";
        public const string PlantCatalog = "Каталог";
        ///Справочники
        public const string Cities = "Города";
        public const string Types_oweship = "Типы собственности";
        public const string Positions = "Должности";
        public const string PlantSpecies = "Виды";
        public const string Fertilizers = "Средства ухода";
        public const string PlantFamilies = "Семейства";

        //public struct Garden
        //{
        //    /// <summary>
        //    /// Возвращает название таблицы
        //    /// </summary>
        //    public static string Name { get { return "\"Сады\""; } }
        //    /// <summary>
        //    /// Возвращает столбец таблицы + ее название
        //    /// </summary>
        //    public static string registration_id { get { return Name + " \"регистрационный_номер\""; } }
        //    public override string ToString()
        //    {
        //        return "Сады";
        //    }
        //}

        static NpgsqlConnection Connection;
        public static NpgsqlCommand cmd;
        string UsingSQL = "";
        static private bool Establish_connection()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                return true;

            const string ConnectData = "" +
                "Host=localhost;" + //127.0.0.1
                "Port=5432;" +
                "Username=postgres;" +
                "Password=1234;" +
                "Database=Botanica_Gardens;" +  //Botanica_Gardens
                "CommandTimeout=300";    

            byte CountConnect = 7;

            Repeat_connection:
            Connection = new NpgsqlConnection(ConnectData);

            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                CountConnect--;

                if (CountConnect > 0) 
                    goto Repeat_connection;

                MessageBox.Show("Ошибка подключения к базе данных!\nКоличество попыток: " + CountConnect,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        } //Подключение к базе данных

        /// <summary>
        /// Загрузка компонентов формы и присваивание к ее элементов поведения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ///---ComboBox---Data------------------------------------------
            SetTableComboBox.DataSource = new List<string>()
            {
                Gardens,
                Stuff,
                GardenPlots,
                Plants,
                CareHistory,
                PlantCatalog
            };
            SetListComboBox.DataSource = new List<string>()
            {
                Cities,
                Types_oweship,
                Positions,
                PlantSpecies,
                Fertilizers,
                PlantFamilies
            };
            SetTableComboBox.Text = SetListComboBox.Text = string.Empty;

            ///---ComboBox---Selections-------------------------------------
            SetTableComboBox.SelectedIndexChanged += (sen, ev) => SetListComboBox.Text = "";
            SetListComboBox.SelectedIndexChanged += (sen, ev) => SetTableComboBox.Text = "";

            SetTableComboBox.SelectedIndexChanged += Set_Table_Or_List_ComboBox_SelectedIndexChanged;
            SetListComboBox.SelectedIndexChanged += Set_Table_Or_List_ComboBox_SelectedIndexChanged;

            ///---IgnoreKeyPress-------------------------------------------
            SetTableComboBox.KeyPress += (sen, ev) => ev.Handled = true;
            SetListComboBox.KeyPress += (sen, ev) => ev.Handled = true;
            ColumnDBTableComboBox.KeyPress += (sen, ev) => ev.Handled = true;

            ///---dataGridView_DB_Table------------------------------------
            dataGridView_DB_Table.MouseWheel += (sen, ev) =>
            {
                DataGridView gv = sen as DataGridView;
                if (Control.ModifierKeys == Keys.Control)
                {
                    if (ev.Delta > 0)
                        gv.Font = new Font(gv.Font.Name, gv.Font.Size + 1);
                    else if(gv.Font.Size - 1 > 1)
                        gv.Font = new Font(gv.Font.Name, gv.Font.Size - 1);
                }
            };
            dataGridView_DB_Table.SelectionChanged += (sen, ev) =>
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
            dataGridView_DB_Table.KeyPress += (sen, ev) =>
            {
                DataGridView gv = sen as DataGridView;
                if (ev.KeyChar == (char)Keys.Escape)
                {
                    foreach(DataGridViewRow row in gv.SelectedRows)
                    {
                        gv.Rows[row.Index].Selected = false;
                    }
                }
            };
            dataGridView_DB_Table.DataError += (sen, anError) => anError.Cancel = true;
            dataGridView_DB_Table.CellDoubleClick += EditEntryButton_Click;
            ///---MenuStrip-------------------------------------------------
            генерацияToolStripMenuItem.Click += (sen, ev) => new GenerationEntryFrom().ShowDialog();
            //---RequestForm
            простыеToolStripMenuItem.Click += (sen, ev) => new RequestForm(RequestForm.RequestLevel.Essy).ShowDialog();
            сложныеToolStripMenuItem.Click += (sen, ev) => new RequestForm(RequestForm.RequestLevel.Hard).ShowDialog();
            техничесикеToolStripMenuItem.Click += (sen, ev) => new RequestForm(RequestForm.RequestLevel.Technical).ShowDialog();
            курсовыеToolStripMenuItem.Click += (sen, ev) => new RequestForm(RequestForm.RequestLevel.Individual).ShowDialog();
            //---ChartsForm
            количествоРастенийToolStripMenuItem.Click += (sen, ev) => new ChartsForm(ChartsForm.ChartType.FirstGardens_On_CountPlants).ShowDialog();
            среднийВозрастToolStripMenuItem.Click += (sen, ev) => new ChartsForm(ChartsForm.ChartType.FirstGardens_On_AgeEmployees).ShowDialog();
            количествоУчастковToolStripMenuItem.Click += (sen, ev) => new ChartsForm(ChartsForm.ChartType.FirstGarndes_On_CountGardenPlots).ShowDialog();
            всегоРастенийToolStripMenuItem.Click += (sen, ev) => new ChartsForm(ChartsForm.ChartType.FirstPlants_On_CountPlants).ShowDialog();
            количествоСотрудниковToolStripMenuItem.Click += (sen, ev) => new ChartsForm(ChartsForm.ChartType.FirstGarndes_On_CountEmployess).ShowDialog();
            //---ModifiableViewForm
            модПредставлениеToolStripMenuItem.Click += (sen, ev) => new ModifiableViewForm().ShowDialog();
            ///---ContexMenuStric---dataGridView_DB_Table-------------------
            dataGridView_DB_Table.ContextMenuStrip = dt_contextMenuStrip;
            обновитьToolStripMenuItem.Click += (sen, ev) => Set_Table_Or_List_ComboBox_SelectedIndexChanged(sender, EventArgs.Empty);
            корректироватьРазмерToolStripMenuItem.Click += (sen, ev) =>
            {
                DataTable dt = dataGridView_DB_Table.DataSource as DataTable;
                using (var gfx = dataGridView_DB_Table.CreateGraphics())
                {
                    for (int i = 0; i < dataGridView_DB_Table.Columns.Count; i++)
                    {
                        dataGridView_DB_Table.Columns[i].Width = 0;

                        string[] colStringCollection = dt.AsEnumerable().Where(r => r.Field<object>(i) != null).Select(r => r.Field<object>(i).ToString()).Concat(new string[] { dt.Columns[i].ColumnName }).ToArray();

                        colStringCollection = colStringCollection.OrderBy((x) => x.Length).ToArray();
                        string longestColString = colStringCollection.Last();
                        var colWidth = gfx.MeasureString(longestColString, dataGridView_DB_Table.Font);
                        if (colWidth.Width > dataGridView_DB_Table.Columns[i].HeaderCell.Size.Width)
                        {
                            dataGridView_DB_Table.Columns[i].Width = (int)colWidth.Width + 10;
                        }
                        else
                        {
                            dataGridView_DB_Table.Columns[i].Width = dataGridView_DB_Table.Columns[i].HeaderCell.Size.Width;
                        }
                    }
                }
            };
            изменитьЗаписьToolStripMenuItem.Click += EditEntryButton_Click;
        }
        
        /// <summary>
        /// Получение данных тип DataTable из sql запросса
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        static public DataTable getDataTable(string sql)
        {
            if (!Establish_connection())
            {
                return new DataTable();
            }

            return getDataTable(new NpgsqlCommand(sql, Connection));
        }
        static public DataTable getDataTable(NpgsqlCommand comand)
        {
            DataTable dt = new DataTable();

            if (!Establish_connection())
            {
                return dt;
            }

            cmd = comand;

            NpgsqlDataReader dr = null;

            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }

            dt.Load(dr);

            return dt;
        }
        static public NpgsqlDataReader getData(string SQL)
        {
            NpgsqlDataReader dr = null;

            if (!Establish_connection())
            {
                return dr;
            }

            cmd = new NpgsqlCommand(SQL, Connection);

            dr = cmd.ExecuteReader();

            return dr;
        }

        /// <summary>
        /// Отправить запрос на базу данных
        /// </summary>
        /// <param name="SQL"></param>
        public static void put_sql(string SQL)
        {
            cmd = new NpgsqlCommand(SQL, Connection);
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Отправить запрос на базу данных с массивом параметров
        /// </summary>
        /// <param name="SQL"></param>
        public static void put_sql(string SQL, params NpgsqlParameter[] parameters)
        {
            cmd = new NpgsqlCommand(SQL, Connection);

            foreach(NpgsqlParameter parameter in parameters)
                cmd.Parameters.Add(parameter);

            cmd.ExecuteNonQuery();
        }
        ///---Действия при выборе из compobox---------------------------
        private string getSelectedTable()
        {
            if (SetTableComboBox.Text.Length != 0)
                return SetTableComboBox.Text;
            else if (SetListComboBox.Text.Length != 0)
                return SetListComboBox.Text;
            else 
                return null;
        }
        private void Set_Table_Or_List_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedTable = getSelectedTable();

            if (SelectedTable == null) return;

            if(SelectedTable.Equals(PlantCatalog) || SelectedTable.Equals(Fertilizers))
                CompositeButton.BackColor = Color.White;
            else
                CompositeButton.BackColor = Color.LightSlateGray;

            string SQL_SELECTED = "";

            switch (SelectedTable)
            {
                ///Таблицы
                case Gardens:
                    SQL_SELECTED = $"SELECT \"регистрационный_номер\", \"название_сада\", \"название_города\", \"тип_собственности\", \"год_открытия\", \"телефон\", \"доп_источники_финансирования\" FROM \"{Gardens}\" " +
                        $"JOIN \"{Cities}\" ON \"{Cities}\".\"код_города\" = \"{Gardens}\".\"код_города\" " +
                        $"JOIN \"{Types_oweship}\" ON \"{Types_oweship}\".\"код_собственности\" = \"{Gardens}\".\"код_типа_собственности\" ";
                    break;

                case Stuff:
                    SQL_SELECTED = $"SELECT \"код_сотрудника\", \"регистрационный_номер_сада\", \"фамилия\", \"имя\", \"отчество\", \"дата_рождения\", \"название_должности\", \"оклад\", \"стаж_работы\" FROM \"{Stuff}\" " +
                        $"JOIN \"{Positions}\" ON \"{Positions}\".\"код_должности\" = \"{Stuff}\".\"номер_должности\" ";
                    break;

                case GardenPlots:
                    SQL_SELECTED = $"SELECT * FROM \"{GardenPlots}\" ";
                    break;

                case Plants:
                    SQL_SELECTED = $"SELECT \"код_растения\", \"номер_участка_в_саду\", \"регистрационный_номер_сада\", \"название_растения\", \"номер_в_каталоге\", \"срок_жизни_растения\", \"однолетнее\", \"фото_растения\", \"дата_посадки\", \"дата_гибели\", \"стоимость_саженца\", \"условия_ухода_и_содержания\" FROM \"{Plants}\" " +
                        $"JOIN \"{GardenPlots}\" ON \"{GardenPlots}\".\"код_участка\" = \"{Plants}\".\"код_участка\" " +
                        $"JOIN \"{PlantCatalog}\" ON \"{PlantCatalog}\".\"номер_растения_в_каталоге\" = \"{Plants}\".\"номер_в_каталоге\" ";
                    break;

                case CareHistory:
                    SQL_SELECTED = $"SELECT \"код_записи\", \"{CareHistory}\".\"код_растения\", \"название_растения\", \"дата_обработки\", \"{CareHistory}\".\"код_средства\", \"название_средства\", \"количество_упоковок\", \"{CareHistory}\".\"код_сотрудника\", \"фамилия\", \"имя\", \"отчество\" FROM \"{CareHistory}\" " +
                        $"JOIN \"{Plants}\" ON \"{Plants}\".\"код_растения\" = \"{CareHistory}\".\"код_растения\" " +
                        $"JOIN \"{PlantCatalog}\" ON \"{PlantCatalog}\".\"номер_растения_в_каталоге\" = \"{Plants}\".\"номер_в_каталоге\" " +
                        $"JOIN \"{Fertilizers}\" ON \"{Fertilizers}\".\"код_средства\" = \"{CareHistory}\".\"код_средства\" " +
                        $"JOIN \"{Stuff}\" ON \"{Stuff}\".\"код_сотрудника\" = \"{CareHistory}\".\"код_сотрудника\" "; 
                    break;

                case PlantCatalog:
                    SQL_SELECTED = $"SELECT \"номер_растения_в_каталоге\", \"название_растения\", \"срок_жизни_растения\", \"название_вида\", \"однолетнее\", \"название_семейства\" FROM \"{PlantCatalog}\" " +
                        $"JOIN \"{PlantSpecies}\" ON \"{PlantSpecies}\".\"код_вида\" = \"{PlantCatalog}\".\"код_вида\" " +
                        $"JOIN \"{PlantFamilies}\" ON \"{PlantFamilies}\".\"код_семейства\" = \"{PlantSpecies}\".\"код_семейства\" "; //JOIN \"{}\" ON \"{}\".\"\" = \"{}\".\"\" 
                    break;

                ///Справочники
                case Cities:
                    SQL_SELECTED = $"SELECT * FROM \"{Cities}\" ";
                    break;

                case Types_oweship:
                    SQL_SELECTED = $"SELECT * FROM \"{Types_oweship}\" ";
                    break;

                case Positions:
                    SQL_SELECTED = $"SELECT * FROM \"{Positions}\" ";
                    break;

                case PlantSpecies:
                    SQL_SELECTED = $"SELECT * FROM \"{PlantSpecies}\" ";
                    break;

                case Fertilizers:
                    SQL_SELECTED = $"SELECT * FROM \"{Fertilizers}\" ";
                    break;

                case PlantFamilies:
                    SQL_SELECTED = $"SELECT * FROM \"{PlantFamilies}\" ";
                    break;
            }

            Console.WriteLine(SQL_SELECTED);

            dataGridView_DB_Table.DataSource = getDataTable(SQL_SELECTED);

            if (dataGridView_DB_Table.Rows.Count > 0)
                dataGridView_DB_Table.Rows[0].Selected = false;

            CountRecordsLable.Text = $"Записей: {dataGridView_DB_Table.Rows.Count}";

            ColumnDBTableComboBox.Items.Clear();
            ColumnDBTableComboBox.Text = "";

            foreach (DataGridViewColumn column in dataGridView_DB_Table.Columns)
                ColumnDBTableComboBox.Items.Add(column.HeaderText);

            UsingSQL = SQL_SELECTED;
        }

        ///---Кнопки----------------------------------------------------
        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            string SelectedTable = getSelectedTable();

            if (SelectedTable == null) return;

            switch(SelectedTable)
            {
                ///Таблицы
                case Gardens:
                    new AddOrChangeEntryForm_IAG().ShowDialog();
                    break;

                case Stuff:
                    new AddOrChangeEntryForm_Staff().ShowDialog();
                    break;

                case GardenPlots:
                    new AddOrChangeEntryForm_GardenPlots().ShowDialog();
                    break;

                case Plants:
                    new AddOrChangeEntryForm_PlantedPlants().ShowDialog();
                    break;

                case CareHistory:
                    new AddOrChangeEntryForm_CareHistory().ShowDialog();
                    break;

                case PlantCatalog:
                    new AddOrChangeEntryForm_PlantСatalog().ShowDialog();
                    break;

                ///Справочники
                case Cities:
                    new AddOrChangeEntryForm_Cities().ShowDialog();
                    break;

                case Types_oweship:
                    new AddOrChangeEntryForm_TypesOwnership().ShowDialog();
                    break;

                case Positions:
                    new AddOrChangeEntryForm_Positions().ShowDialog();
                    break;

                case PlantSpecies:
                    new AddOrChangeEntryForm_PlantSpecies().ShowDialog();
                    break;

                case Fertilizers:
                    new AddOrChangeEntryForm_TreatmentСP().ShowDialog();
                    break;

                case PlantFamilies:
                    new AddOrChangeEntryForm_PlantFamilies().ShowDialog();
                    break;
            }

            Set_Table_Or_List_ComboBox_SelectedIndexChanged(sender, EventArgs.Empty);
        }
        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            string SelectedTable = getSelectedTable();

            if (SelectedTable == null) return;

            long Record_ID = 0;

            try
            {
                Record_ID = Convert.ToInt64(((DataGridViewRow)(dataGridView_DB_Table.SelectedRows[0])).Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException) 
            {
                MessageBox.Show("Выбирите строку для редактирования.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

            switch (SelectedTable)
            {
                ///Таблицы
                case Gardens:
                    new AddOrChangeEntryForm_IAG(Record_ID).ShowDialog();
                    break;

                case Stuff:
                    new AddOrChangeEntryForm_Staff(Record_ID).ShowDialog();
                    break;

                case GardenPlots:
                    new AddOrChangeEntryForm_GardenPlots(Record_ID).ShowDialog();
                    break;

                case Plants:
                    new AddOrChangeEntryForm_PlantedPlants(Record_ID).ShowDialog();
                    break;

                case CareHistory:
                    new AddOrChangeEntryForm_CareHistory(Record_ID).ShowDialog();
                    break;

                case PlantCatalog:
                    new AddOrChangeEntryForm_PlantСatalog(Record_ID).ShowDialog();
                    break;

                ///Справочники
                case Cities:
                    new AddOrChangeEntryForm_Cities(Record_ID).ShowDialog();
                    break;

                case Types_oweship:
                    new AddOrChangeEntryForm_TypesOwnership(Record_ID).ShowDialog();
                    break;

                case Positions:
                    new AddOrChangeEntryForm_Positions(Record_ID).ShowDialog();
                    break;

                case PlantSpecies:
                    new AddOrChangeEntryForm_PlantSpecies(Record_ID).ShowDialog();
                    break;

                case Fertilizers:
                    new AddOrChangeEntryForm_TreatmentСP(Record_ID).ShowDialog();
                    break;

                case PlantFamilies:
                    new AddOrChangeEntryForm_PlantFamilies(Record_ID).ShowDialog();
                    break;
            }

            Set_Table_Or_List_ComboBox_SelectedIndexChanged(sender, EventArgs.Empty);
        }
        private async void SearchEntryButton_Click(object sender, EventArgs e)
        {
            string SelectedTable = getSelectedTable();

            if(SelectedTable == null) return;

            if (ColumnDBTableComboBox.Text.Length == 0)
            {
                MessageBox.Show("Вы не выбрали колонку для поиска!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (SearchEntryTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле для поиска соотвествий пустое!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //string SQL_SELECTED = $"{UsingSQL} WHERE \"{ColumnDBTableComboBox.Text}\" = '{SearchEntryTextBox.Text}' ";

            //dataGridView_DB_Table.DataSource = getData(SQL_SELECTED);

            try
            {
                string ColumnName = ColumnDBTableComboBox.Text;
                string Value = SearchEntryTextBox.Text;

                await Task.Run(() =>
                {
                    try
                    {
                        DataTable dt = getDataTable(UsingSQL).Select($"{ColumnName} = '{Value}'").CopyToDataTable();

                        dataGridView_DB_Table.Invoke((MethodInvoker)delegate ()
                        {
                            dataGridView_DB_Table.DataSource = dt;
                        });
                    } catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                });

                CountRecordsLable.Text = $"Записей: {dataGridView_DB_Table.Rows.Count}";

            } catch(EvaluateException ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
        private async void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            string SelectedTable = getSelectedTable();

            if (SelectedTable == null) return;

            if (ColumnDBTableComboBox.Text.Length == 0)
            {
                MessageBox.Show("Вы не выбрали колонку для удаления!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (SearchEntryTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле для поиска соотвествий пустое!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Message = "Все данные данные соответствующие значению будут удалены из таблицы!\n" +
                "Все свазанные данные так-же будут удалены!\n" +
                "Вы уверены?";

            int CountDeleteData = 0;

            if (MessageBox.Show(Message, "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string ColumnName = ColumnDBTableComboBox.Text;
                string Value = SearchEntryTextBox.Text;

                await Task.Run(() =>
                {
                    DataTable dt = getDataTable(UsingSQL);

                    string HeaderColumnName = dt.Columns[0].ColumnName;

                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        if (Convert.ToString(row[ColumnName]).Equals(Value))
                        {
                            string Record_ID = Convert.ToString(row[0]);

                            string SQL = $"DELETE FROM \"{SelectedTable}\" " +
                            $"WHERE \"{HeaderColumnName}\" = '{Record_ID}'";

                            CountDeleteData++;

                            put_sql(SQL);
                            dt.Rows.Remove(row);
                        }
                    }

                    try
                    {
                        dataGridView_DB_Table.Invoke((MethodInvoker)delegate ()
                        {
                            dataGridView_DB_Table.DataSource = dt;
                            CountRecordsLable.Text = $"Записей: {dataGridView_DB_Table.Rows.Count}";
                        });
                    } catch { return; };
                });

                MessageBox.Show($"Соответсвующие данные успешно удалены!\nВсего удалено: {CountDeleteData} строк.", 
                    "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CompositeButton_Click(object sender, EventArgs e)
        {
            string SelectedTable = getSelectedTable();

            if (SelectedTable == null) return;

            if (SelectedTable.Equals(PlantCatalog) || SelectedTable.Equals(Fertilizers))
                new CompositeForm(SelectedTable).Show();
        }

        ///---ContexMenuStric---dataGridView_DB_Table-------------------
        private async void удалитьВыбранноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SelectedTable = getSelectedTable();

            if (SelectedTable == null) return;

            if (dataGridView_DB_Table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одну строку для удаления!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Message = "Все выбранные вами данные из таблицы будут удалены!\n" +
                "Все свазанные данные так-же будут удалены!\n" +
                "Вы уверены?";

            if (MessageBox.Show(Message, "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection selected_rows = dataGridView_DB_Table.SelectedRows;

                string HeaderColumnName = dataGridView_DB_Table.Columns[0].HeaderText;

                await Task.Run(() =>
                {
                    for (int i = 0; i < selected_rows.Count; ++i)
                    {
                        string Record_ID = Convert.ToString(selected_rows[i].Cells[0].Value);

                        string SQL = $"DELETE FROM \"{SelectedTable}\" " +
                            $"WHERE \"{HeaderColumnName}\" = '{Record_ID}'";

                        put_sql(SQL);
                        try
                        {
                            dataGridView_DB_Table.Invoke((MethodInvoker)delegate ()
                            {
                                dataGridView_DB_Table.Rows.RemoveAt(selected_rows[i].Index);
                            });
                        }
                        catch { return; }
                    }
                });

                CountRecordsLable.Text = $"Записей: {dataGridView_DB_Table.Rows.Count}";

                MessageBox.Show("Выбранные данные успешно удалены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}