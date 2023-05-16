using LiveChartsCore;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static OpenTK.Graphics.OpenGL.GL;

namespace Лабораторная_2_БД_Панков
{
    public partial class ChartsForm : Form
    {
        public enum ChartType
        {
            FirstGardens_On_CountPlants,        //Первые 20 садов по количеству растений
            FirstGardens_On_AgeEmployees,       //Первые 20 садов по найменьшему среднему возрасту
            FirstGarndes_On_CountGardenPlots,   //Первые 20 садов по количеству участков
            FirstPlants_On_CountPlants,         //Первые 20 растений по количеству
            FirstGarndes_On_CountEmployess      //Первые 20 садов по количеству сотрудников

        }

        ChartType selected_type;
        
        public ChartsForm(ChartType _selected_type)
        {
            this.selected_type = _selected_type;
            InitializeComponent();
        }

        private async void ChartsForm_Load(object sender, EventArgs e)
        {
            количествоРастенийToolStripMenuItem.Click += (sen, ev) => getData(ChartType.FirstGardens_On_CountPlants);
            среднийВозрастToolStripMenuItem.Click += (sen, ev) => getData(ChartType.FirstGardens_On_AgeEmployees);
            количествоУчастковToolStripMenuItem.Click += (sen, ev) => getData(ChartType.FirstGarndes_On_CountGardenPlots);
            всегоРастенийToolStripMenuItem.Click += (sen, ev) => getData(ChartType.FirstPlants_On_CountPlants);
            количествоСотрудниковToolStripMenuItem.Click += (sen, ev) => getData(ChartType.FirstGarndes_On_CountEmployess);

            Loading_panel.Visible = false;

            getData(selected_type);
            

            ChartsForm_SizeChanged(sender, EventArgs.Empty);
        }

        private async void getData(ChartType type)
        {
            if(Loading_panel.Visible)
            {
                MessageBox.Show("Дождитесь коца выполнения запроса перед переключением!", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Loading_panel.Visible = true;
            
            string SQL = "";
            DataTable dt;
            ISeries[] series = new ISeries[0];
            List<string> labels;
            string NameSeriesText = "";
            string XNameText = "";
            string YNameText = "";


            switch (type)
            {
                case ChartType.FirstGardens_On_CountPlants:
                    await Task.Run(() =>
                    {
                        SQL = "SELECT \r\nCONCAT('№ ',\"Регистрационный номер сада\", ' | ', \"Название сада\") as \"Сад\", \r\n\"Количество растений в саду\" \r\nFROM count_plants_for_each_garden \r\nORDER BY count_plants_for_each_garden.\"Количество растений в саду\" DESC\r\nLIMIT 20;";
                        //Первые 20 садов по количеству растений

                        dt = MainForm.getDataTable(SQL);

                        labels = dt.AsEnumerable().Select(x => x.Field<string>("Сад")).ToList();
                        long[] array = dt.AsEnumerable().Select(x => x.Field<long>("Количество растений в саду")).ToArray();

                        series = new ISeries[]
                        {
                            new StackedAreaSeries<long>
                            {
                                Values = array,
                                TooltipLabelFormatter = (chartPoint) =>
                                {
                                    string label = labels[chartPoint.Context.Index];
                                    return $"{label}: {chartPoint.PrimaryValue}";
                                }
                            }
                        };

                        NameSeriesText = "Первые 20 садов по количеству растений";
                        YNameText = "Количество";
                        XNameText = "Номера садов в серии";
                    });
                    break;

                case ChartType.FirstGardens_On_AgeEmployees:
                    await Task.Run(() =>
                    {
                        SQL = "SELECT \r\nCONCAT('№ ',\"Код сада\", ' | ', \"Название сада\") as \"Сад\",  \r\n\"Средний возраст сотрудников\"::numeric\r\nFROM avf_age_employees_for_each_garden \r\nWHERE \"Средний возраст сотрудников\" != 'Сотрудники отсутствуют'\r\nORDER BY \"Средний возраст сотрудников\"::numeric ASC\r\nLIMIT 20;";
                        //Первые 20 садов у которых самый низкий возраст сотрудников

                        dt = MainForm.getDataTable(SQL);

                        labels = dt.AsEnumerable().Select(x => x.Field<string>("Сад")).ToList();
                        double[] array = dt.AsEnumerable().Select(x => Convert.ToDouble(x.Field<object>("Средний возраст сотрудников"))).ToArray();

                        series = new ISeries[]
                        {
                            new CandlesticksSeries<double>
                            {
                                Values = array,
                                TooltipLabelFormatter = (chartPoint) =>
                                {
                                    string label = labels[chartPoint.Context.Index];
                                    return $"{label}: {chartPoint.PrimaryValue}";
                                }
                            }
                        };

                        NameSeriesText = "Первые 20 садов с самый низким возрастом сотрудников";
                        YNameText = "Возраст";
                        XNameText = "Номера садов в серии";
                    });
                    break;

                case ChartType.FirstGarndes_On_CountGardenPlots:
                    await Task.Run(() =>
                    {
                        SQL = "SELECT \r\nCONCAT('№ ',\"регистрационный_номер\", ' | ', \"название_сада\") as \"Сад\",\r\nCOUNT(\"Участки\".*) as \"Участки\"\r\nFROM \"Сады\"\r\nINNER JOIN \"Участки\" ON \"Участки\".\"регистрационный_номер_сада\" = \"Сады\".\"регистрационный_номер\"\r\nGROUP BY \"регистрационный_номер\"\r\nORDER BY \"Участки\" DESC\r\nLIMIT 20;";
                        //Первые 20 садов по количеству участков

                        dt = MainForm.getDataTable(SQL);

                        labels = dt.AsEnumerable().Select(x => x.Field<string>("Сад")).ToList();
                        long[] array = dt.AsEnumerable().Select(x => x.Field<long>("Участки")).ToArray();

                        series = new ISeries[]
                        {
                            new StackedColumnSeries<long>
                            {
                                Values = array,
                                TooltipLabelFormatter = (chartPoint) =>
                                {
                                    string label = labels[chartPoint.Context.Index];
                                    return $"{label}: {chartPoint.PrimaryValue}";
                                }
                            }
                        };

                        NameSeriesText = "Первые 20 садов по количеству участков";
                        YNameText = "Количество";
                        XNameText = "Номера садов в серии";
                    });
                    break;

                case ChartType.FirstPlants_On_CountPlants:
                    await Task.Run(() =>
                    {
                        SQL = "SELECT \r\n\"название_растения\", \r\nCOUNT(\"Растения\".*) as \"Количество\"\r\nFROM \"Каталог\"\r\nINNER JOIN \"Растения\" ON \"Растения\".\"номер_в_каталоге\" = \"Каталог\".\"номер_растения_в_каталоге\"\r\nGROUP BY \"название_растения\"\r\nORDER BY \"Количество\" DESC\r\nLIMIT 20;";
                        //Первые 20 растений по количеству

                        dt = MainForm.getDataTable(SQL);

                        labels = dt.AsEnumerable().Select(x => x.Field<string>("название_растения")).ToList();
                        long[] array = dt.AsEnumerable().Select(x => x.Field<long>("Количество")).ToArray();

                        series = new ISeries[]
                        {
                            new ScatterSeries<long>
                            {
                                Values = array,
                                TooltipLabelFormatter = (chartPoint) =>
                                {
                                    string label = labels[chartPoint.Context.Index];
                                    return $"{label}: {chartPoint.PrimaryValue}";
                                }
                            }
                        };

                        NameSeriesText = "Первые 20 растений по количеству";
                        YNameText = "Количество";
                        XNameText = "Номера растений в серии";
                    });
                    break;

                case ChartType.FirstGarndes_On_CountEmployess:
                    await Task.Run(() =>
                    {
                        SQL = "SELECT \r\nCONCAT('№ ',\"регистрационный_номер\", ' | ', \"название_сада\") as \"Сад\",\r\nCOUNT(\"Сотрудники\".*) as \"Сотрудников\"\r\nFROM \"Сады\"\r\nINNER JOIN \"Сотрудники\" ON \"Сотрудники\".\"регистрационный_номер_сада\" = \"Сады\".\"регистрационный_номер\"\r\nGROUP BY \"регистрационный_номер\"\r\nORDER BY \"Сотрудников\" DESC\r\nLIMIT 20;";
                        //Первые 20 садов по количеству сотрудников

                        dt = MainForm.getDataTable(SQL);

                        labels = dt.AsEnumerable().Select(x => x.Field<string>("Сад")).ToList();
                        long[] array = dt.AsEnumerable().Select(x => x.Field<long>("Сотрудников")).ToArray();

                        series = new ISeries[]
                        {
                            new LineSeries<long>
                            {
                                Values = array,
                                TooltipLabelFormatter = (chartPoint) =>
                                {
                                    string label = labels[chartPoint.Context.Index];
                                    return $"{label}: {chartPoint.PrimaryValue}";
                                }
                            }
                        };

                        NameSeriesText = "Первые 20 садов по количеству сотрудников";
                        YNameText = "Сотрудников";
                        XNameText = "Номера садов в серии";
                    });
                    break;

                default: return;
            }

            if(this.DialogResult == DialogResult.OK)
            {
                string Text = "Запрос был успешно выполнен, теперь вы снова можете пользоваться программой!";
                MessageBox.Show(Text, "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selected_type = type;

            try
            {
                cartesianChart1.Invoke((MethodInvoker)delegate
                {
                    YName_Lable.Text = YNameText;
                    XName_Lable.Text = XNameText;

                    cartesianChart1.Series = series;
                    NameSeries_Lable.Text = NameSeriesText;
                    Loading_panel.Visible = false;
                });
            } catch(Exception ex) { return; }


        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            NameSeries_Lable.Left = this.cartesianChart1.Width / 2 - NameSeries_Lable.Width / 2;//привели в центр
        }

        private void ChartsForm_SizeChanged(object sender, EventArgs e)
        {
            if(Loading_panel.Visible)
                LoadingLable.Location = new Point(Loading_panel.Width / 2 - LoadingLable.Width / 2, Loading_panel.Height / 2 - LoadingLable.Height / 2);

            NameSeries_Lable.Left = this.cartesianChart1.Width / 2 - NameSeries_Lable.Width / 2;//привели в центр
            XName_Lable.Left = this.cartesianChart1.Width / 2 - XName_Lable.Width / 2;
        }

        private void ChartsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Loading_panel.Visible == true)
            {
                string Text = "При закрытии формы запрос в базу данный не будет отменен и вы не сможете подавать запросы до тех пора пока он не выполнится.\nВы уверены что хотите продолжить?";
                if(MessageBox.Show(Text, "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            DialogResult = DialogResult.OK;

        }
    }
}
