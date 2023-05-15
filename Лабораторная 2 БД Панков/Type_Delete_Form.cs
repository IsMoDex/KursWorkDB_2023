using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лабораторная_2_БД_Панков.Forms.Cities_List;
using Лабораторная_2_БД_Панков.Forms.GardenPlots_Table;
using Лабораторная_2_БД_Панков.Forms.HistoryPP_Table;
using Лабораторная_2_БД_Панков.Forms.IAG_Table;
using Лабораторная_2_БД_Панков.Forms.PlantedPlant_Table;
using Лабораторная_2_БД_Панков.Forms.PlantFamilies_List;
using Лабораторная_2_БД_Панков.Forms.PlantSpecies_Table;
using Лабораторная_2_БД_Панков.Forms.PlantСatalog_Table;
using Лабораторная_2_БД_Панков.Forms.Positions_List;
using Лабораторная_2_БД_Панков.Forms.Staff_Table;
using Лабораторная_2_БД_Панков.Forms.TreatmentСP_List;
using Лабораторная_2_БД_Панков.Forms.TypesOwnership_List;

namespace Лабораторная_2_БД_Панков
{
    public partial class Type_Delete_Form : Form
    {
        string SetTable = null;

        public Type_Delete_Form(string _SetTable)
        {
            SetTable = _SetTable;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void DeleteMeaningButton_Click(object sender, EventArgs e)
        {
            if(SetTable == null || SetTable.Length == 0)
            {
                MessageBox.Show("Ошибка параметров! Неверно переданные параметры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (SetTable)
            {
                case "Информация о садах":

                    new DeleteEntryForm_IAG().Show();

                    break;

                case "Участки садов":

                    new DeleteEntryForm_GardenPlots().Show();

                    break;

                case "Посаженные растения":

                    new DeleteEntryForm_PlantedPlant().Show();

                    break;

                case "Каталог растений":

                    new DeleteEntryForm_PlantСatalog().Show();

                    break;

                case "Виды растений":

                    new DeleteEntryForm_PlantSpecies().Show();

                    break;

                case "История обработки растений":

                    new DeleteEntryForm_HistoryPP().Show();

                    break;

                case "Сотрудники":

                    new DeleteEntryForm_Staff().Show();

                    break;

                    ///Справочники

                case "Города":

                    new DeleteEntryForm_Cities().Show();

                    break;

                case "Типы собственности":

                    new DeleteEntryForm_TypesOwnership().Show();

                    break;

                case "Семейства растений":

                    new DeleteEntryForm_PlantFamilies().Show();

                    break;

                case "Средства обработки и ухода":

                    new DeleteEntryForm_TreatmentСP().Show();

                    break;

                case "Должности":

                    new DeleteEntryForm_Positions().Show();

                    break;
            }
        }

        private void DeleteAllDataInTableButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Если нажмете Да, все данные из таблицы будут удалены!\nВсе свазанные данные так-же будут удалены!\nВы уверены?", "Вопрос", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Все данные успешно удалены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteLineButton_Click(object sender, EventArgs e)
        {
            new Select_And_Delete_Line_Form(SetTable).Show();
        }
    }
}
