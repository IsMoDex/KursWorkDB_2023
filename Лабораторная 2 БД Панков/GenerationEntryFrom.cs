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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Лабораторная_2_БД_Панков
{
    public partial class GenerationEntryFrom : Form
    {
        public GenerationEntryFrom()
        {
            InitializeComponent();
        }
        private volatile bool GenerationStart = false;

        private void GenerationEntryFrom_Load(object sender, EventArgs e)
        {
            SelectedTableComboBox.Items.Clear();
            SelectedTableComboBox.Items.Add(MainForm.Gardens);
            SelectedTableComboBox.Items.Add(MainForm.Stuff);
            SelectedTableComboBox.Items.Add(MainForm.GardenPlots);
            SelectedTableComboBox.Items.Add(MainForm.Plants);
            SelectedTableComboBox.Items.Add(MainForm.CareHistory);
            SelectedTableComboBox.Items.Add(MainForm.PlantCatalog);
            SelectedTableComboBox.Items.Add("Все таблицы");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            if (SelectedTableComboBox.Text.Length == 0) return;
            if (CountEntryToGenerate_NumericUpDown.Text.Length == 0) return;

            if(GenerationStart)
            {
                MessageBox.Show("Генерация в процессе, подождите пожалуйста.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int CountEntry = Convert.ToInt32(CountEntryToGenerate_NumericUpDown.Value);

            bool AllTables = SelectedTableComboBox.Text.Equals("Все таблицы");

            GenerationEntry.StopGenerate = false;

            progressBar1.Value = 0;
            GenerationStart = true;
            int CountGenerateEntrys = 0; 

            var progress = new GenerationEntry.ProgressBarDelegate(delegate (int procent)
            {
                int ProcentResult = 0;

                if (AllTables)
                    ProcentResult = ++CountGenerateEntrys * 100 / (CountEntry * 6);
                else
                    ProcentResult = (CountEntry - procent + 1) * 100 / CountEntry;

                if(progressBar1.Value < ProcentResult)
                {
                    try
                    {
                        progressBar1.Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value = ProcentResult;
                        });
                    } catch { 
                        return; 
                    }

                    if (progressBar1.Value == 100)
                    {
                        GenerationStart = false;
                        MessageBox.Show("Все данные успешно сгенерированы!", "Оповещение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                return;
            });

            try
            {
                string SelectedTable = SelectedTableComboBox.Text;

                await Task.Run(() =>
                {
                    switch (SelectedTable)
                    {
                        ///Таблицыdd
                        case MainForm.Gardens:
                            GenerationEntry.generateGardens(CountEntry, progress);
                            break;

                        case MainForm.Stuff:
                            GenerationEntry.generateStuff(CountEntry, progress);
                            break;

                        case MainForm.GardenPlots:
                            GenerationEntry.generateGardenPlots_2(CountEntry, progress);
                            break;

                        case MainForm.Plants:
                            GenerationEntry.generatePlatns(CountEntry, progress);
                            break;

                        case MainForm.CareHistory:
                            GenerationEntry.generateCareHistory(CountEntry, progress);
                            break;

                        case MainForm.PlantCatalog:
                            GenerationEntry.generateCatalog(CountEntry, progress);
                            break;

                        case "Все таблицы":
                            GenerationEntry.generateAllData(CountEntry, progress);
                            break;
                    }
                });


            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void GenerationEntryFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            GenerationEntry.StopGenerate = true;

            if (GenerationStart)
                MessageBox.Show("Генерация была приостановлена в связи с закрытием формы!", "Оповещение", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
