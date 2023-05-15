using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Лабораторная_2_БД_Панков
{
    public partial class RequestForm : Form
    {
        public enum RequestLevel 
        {
            Essy,
            Hard,
            Technical,
            Individual
        }

        private RequestLevel request_level;
        public RequestForm(RequestLevel level)
        {
            InitializeComponent();

            request_level = level;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            dataGridView_RequestTable.Select();

            Loading_panel.Visible = false;

            RequestForm_SizeChanged(sender, EventArgs.Empty);

            setTypeForm(request_level);

            RequestList_ComboBox_SelectedIndexChanged(null, null);

            простыеToolStripMenuItem.Click += (sen, ev) => setTypeForm(RequestLevel.Essy);
            сложныеToolStripMenuItem.Click += (sen, ev) => setTypeForm(RequestLevel.Hard);
            техническиеToolStripMenuItem.Click += (sen, ev) => setTypeForm(RequestLevel.Technical);
            курсовыеToolStripMenuItem.Click += (sen, ev) => setTypeForm(RequestLevel.Individual);

            Request_TextBox.MouseWheel += (sen, ev) =>
            {
                var el = sen as System.Windows.Forms.TextBox;
                if (Control.ModifierKeys == Keys.Control)
                {
                    if (ev.Delta > 0)
                        el.Font = new Font(el.Font.Name, el.Font.Size + 1);
                    else if (el.Font.Size - 1 > 1)
                        el.Font = new Font(el.Font.Name, el.Font.Size - 1);
                }
            };

            SetTableBehavior(dataGridView_RequestTable);
        }

        private void setTypeForm(RequestLevel level)
        {
            if (Loading_panel.Visible)
            {
                MessageBox.Show("Дождитесь коца выполнения запроса перед переключением!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string TextForm = "Форма запросов ";

            SortedDictionary<string, string> RequestList = new SortedDictionary<string, string>();

            if (level == RequestLevel.Essy)
            {
                TextForm += "\"Простые запросы\"";

                RequestList = new SortedDictionary<string, string>()
                {
                    { "Внутрненее соединение №1.1 с условием: По ключу_1", "SELECT \r\nCONCAT(\"фамилия\", ' ', \"имя\", ' ', \"отчество\") as \"ФИО сотрудника\", \r\n\"название_должности\" as \"Должность\"\r\nFROM \"Сотрудники\"\r\nINNER JOIN \"Должности\" ON \"Должности\".\"код_должности\" = \"Сотрудники\".\"номер_должности\"\r\nWHERE \"регистрационный_номер_сада\" = @Param AND \r\n\"Должности\".\"название_должности\" IN \r\n('Садовод овощевод', 'Плодоовощевод', 'Ботаник', 'Ботаник естествоиспытатель', 'Тепличница', 'Рабочий зеленого строительства');" }, 
                    { "Внутрненее соединение №1.2 с условием: По ключу_2", "SELECT \r\n\"код_записи\" as \"Код записи\", \r\n\"История ухода\".\"код_растения\" as \"Код растения\", \r\n\"название_растения\" as \"Название растения\", \r\n\"дата_обработки\" as \"Дата обработки\", \r\n\"название_средства\" as \"Название средства\", \r\n\"количество_упоковок\" as \"Количество упоковок\", \r\nCONCAT(\"фамилия\", ' ', \"имя\", ' ', \"отчество\") as \"Фио сотрудника\"\r\nFROM \"История ухода\" \r\nINNER JOIN \"Растения\" ON \"Растения\".\"код_растения\" = \"История ухода\".\"код_растения\" \r\nINNER JOIN \"Каталог\" ON \"Каталог\".\"номер_растения_в_каталоге\" = \"Растения\".\"номер_в_каталоге\" \r\nINNER JOIN \"Средства ухода\" ON \"Средства ухода\".\"код_средства\" = \"История ухода\".\"код_средства\" \r\nINNER JOIN \"Сотрудники\" ON \"Сотрудники\".\"код_сотрудника\" = \"История ухода\".\"код_сотрудника\" \r\nWHERE \"регистрационный_номер_сада\" = @Param;" },
                    { "Внутрненее соединение №1.3 с условием: По дате_1", "SELECT \r\n\"регистрационный_номер_сада\" as \"Номер сада\", \r\n\"название_сада\" as \"Название Сада\", \r\n\"название_растения\" as \"Название растения\",\r\n\"срок_жизни_растения\" as \"Срок жизни растения\", \r\nCASE \r\n    WHEN \"однолетнее\" = True THEN 'Да' \r\n    ELSE 'Нет' \r\nEND as \"Однолетнее?\",\r\n\"фото_растения\" as \"Фото растения\", \r\n\"дата_посадки\" as \"Дата посадки\", \r\n\"дата_гибели\" as \"Дата гибели\", \r\n\"стоимость_саженца\" as \"Стоимость саженца\" \r\nFROM \"Растения\" \r\nINNER JOIN \"Участки\" ON \"Участки\".\"код_участка\" = \"Растения\".\"код_участка\" \r\nINNER JOIN \"Сады\" ON \"Сады\".\"регистрационный_номер\" = \"Участки\".\"регистрационный_номер_сада\"\r\nINNER JOIN \"Каталог\" ON \"Каталог\".\"номер_растения_в_каталоге\" = \"Растения\".\"номер_в_каталоге\"\r\nWHERE \"дата_посадки\" <= @Param\r\nORDER BY \"регистрационный_номер_сада\" ASC;" },
                    { "Внутрненее соединение №1.4 с условием: По дате_2", "SELECT \r\n\"регистрационный_номер_сада\" as \"Номер сада\", \r\n\"название_сада\" as \"Название Сада\", \r\n\"название_растения\" as \"Название растения\",\r\n\"срок_жизни_растения\" as \"Строк жизни растения\", \r\nCASE \r\n    WHEN \"однолетнее\" = True THEN 'Да' \r\n    ELSE 'Нет' \r\nEND as \"Однолетнее?\",\r\n\"фото_растения\" as \"Фото растения\", \r\n\"дата_посадки\" as \"Дата посадки\", \r\n\"дата_гибели\" as \"Дата гибели\", \r\n\"стоимость_саженца\" as \"Стоимость саженца\" \r\nFROM \"Растения\" \r\nINNER JOIN \"Участки\" ON \"Участки\".\"код_участка\" = \"Растения\".\"код_участка\" \r\nINNER JOIN \"Сады\" ON \"Сады\".\"регистрационный_номер\" = \"Участки\".\"регистрационный_номер_сада\"\r\nINNER JOIN \"Каталог\" ON \"Каталог\".\"номер_растения_в_каталоге\" = \"Растения\".\"номер_в_каталоге\"\r\nWHERE \"дата_гибели\" >= @Param\r\nORDER BY \"Дата гибели\" ASC;" },
                    { "Внутрненее соединение №2.1 без условия.", "SELECT \r\n\"название_растения\" as \"Название растения\", \r\n\"срок_жизни_растения\" as \"Строк жизни растения\", \r\n\"название_вида\" as \"Название вида\", \r\nCASE \r\n    WHEN \"однолетнее\" = True THEN 'Да' \r\n    ELSE 'Нет' \r\nEND as \"Однолетнее?\",\r\n\"название_семейства\" as \"Семейство\"\r\nFROM \"Каталог\" \r\nINNER JOIN \"Виды\" ON \"Виды\".\"код_вида\" = \"Каталог\".\"код_вида\" \r\nINNER JOIN \"Семейства\" ON \"Семейства\".\"код_семейства\" = \"Виды\".\"код_семейства\"\r\nORDER BY \"название_вида\" ASC;" },
                    { "Внутрненее соединение №2.2 без условия.", "SELECT\r\n\"регистрационный_номер_сада\" as \"Номер сада\", \r\n\"название_сада\" as \"Название Сада\", \r\nCONCAT(\"фамилия\", ' ', \"имя\", ' ', \"отчество\") as \"ФИО сотрудника\", \r\nCOUNT(history.*) as \"Количество раз\"\r\nFROM \"Сотрудники\" stuff\r\nINNER JOIN \"История ухода\" history ON history.\"код_сотрудника\" = stuff.\"код_сотрудника\"\r\nINNER JOIN \"Сады\" ON \"Сады\".\"регистрационный_номер\" = stuff.\"регистрационный_номер_сада\"\r\nGROUP BY \"регистрационный_номер_сада\", \"название_сада\", \"ФИО сотрудника\"\r\nORDER BY \"регистрационный_номер_сада\";" },
                    { "Внутрненее соединение №2.3 без условия.", "SELECT \"название_города\" as \"Город\", \r\nCOUNT(\"название_сада\") as \"Сады\"\r\nFROM \"Города\"\r\nINNER JOIN \"Сады\" ON \"Города\".\"код_города\" = \"Сады\".\"код_города\"\r\nGROUP BY \"название_города\";" },
                    { "Левое соединение №3", "SELECT \"название_растения\" as \"Растение\", \r\nCOUNT(\"Растения\".*) as \"Количество\"\r\nFROM \"Каталог\"\r\nLEFT OUTER JOIN \"Растения\" ON \"Растения\".\"номер_в_каталоге\" = \"Каталог\".\"номер_растения_в_каталоге\"\r\nGROUP BY \"название_растения\"; " },
                    { "Правое соединение №4", "SELECT \"название_семейства\" as \"Семейство\", \r\nCOUNT(class.*) as \"Количество видов\"\r\nFROM \"Виды\" class\r\nRIGHT JOIN \"Семейства\" families ON families.\"код_семейства\" = class.\"код_семейства\"\r\nGROUP BY \"название_семейства\";" },
                    { "Запрос с подзапросом №5", "SELECT \r\n\"регистрационный_номер\" as \"Номер сада\", \r\n\"название_сада\" as \"Название Сада\",  \r\n(\r\n    SELECT \r\n    CASE\r\n        WHEN COUNT(\"количество_упоковок\") != 0 THEN SUM(\"количество_упоковок\" * \"стоимость_средства\")\r\n        ELSE 0\r\n    END\r\n    FROM \"История ухода\"\r\n    INNER JOIN \"Средства ухода\" ON \"Средства ухода\".\"код_средства\" = \"История ухода\".\"код_средства\"\r\n    WHERE \"код_растения\" = \"Растения\".\"код_растения\"\r\n) as \"Затраты\"\r\nFROM \"Сады\"\r\nLEFT JOIN \"Участки\" ON \"Участки\".\"регистрационный_номер_сада\" = \"Сады\".\"регистрационный_номер\"\r\nLEFT JOIN \"Растения\" ON \"Растения\".\"код_участка\" = \"Участки\".\"код_участка\"\r\nORDER BY \"Затраты\" DESC;" }
                };
            }
            else if (level == RequestLevel.Hard)
            {
                TextForm += "\"Сложные запросы\"";

                RequestList = new SortedDictionary<string, string>()
                {
                    {"Итоговый запрос без условия №1", "SELECT \"название_семейства\" as \"Семейства\", \r\nCOUNT(\"Виды\".*) as \"Количество видов\", \r\nCOUNT(\"Каталог\".*) as \"Количество в каталоге\"\r\nFROM \"Семейства\"\r\nLEFT JOIN \"Виды\" ON \"Виды\".\"код_семейства\" = \"Семейства\".\"код_семейства\"\r\nLEFT JOIN \"Каталог\" ON \"Каталог\".\"код_вида\" = \"Виды\".\"код_вида\"\r\nGROUP BY \"название_семейства\";"},
                    {"Итоговый запрос с условием на данные №2", "SELECT \"название_растения\" as \"Название растения\", \r\n\"название_вида\" as \"Вид\", \r\nCOUNT(\"Растения\".*) as \"Количество\"\r\nFROM \"Каталог\"\r\nLEFT JOIN \"Виды\" ON \"Виды\".\"код_вида\" = \"Каталог\".\"код_вида\" \r\nLEFT JOIN \"Растения\" ON \"Растения\".\"номер_в_каталоге\" = \"Каталог\".\"номер_растения_в_каталоге\"\r\nWHERE \"дата_гибели\" IS NOT NULL AND \r\n(\"срок_жизни_растения\" / 50) > ((UPPER(daterange(\"дата_посадки\",  \"дата_гибели\")) - LOWER(daterange(\"дата_посадки\", \"дата_гибели\"))) / 365)\r\nGROUP BY \"название_растения\", \"название_вида\"\r\nORDER BY \"Количество\" DESC;"},
                    {"Итоговый запрос с условием на группы №3", "SELECT \r\n\"название_растения\" as \"Название растения\", \r\nROUND(AVG(\"стоимость_саженца\"), 1) as \"Средняя стоимость саженцов\", \r\nCOUNT(\"Растения\".*) as \"Количество  растений\"\r\nFROM \"Каталог\"\r\nINNER JOIN \"Растения\" ON \"Растения\".\"номер_в_каталоге\" = \"Каталог\".\"номер_растения_в_каталоге\"\r\nGROUP BY \"название_растения\"\r\nHAVING AVG(\"стоимость_саженца\") > @Param\r\nORDER BY \"Средняя стоимость саженцов\" DESC;"},
                    {"Итоговый запрос с условием на данные и на группы №4", "SELECT \r\n\"название_растения\" as \"Название растения\", \r\n\"название_вида\" as \"Вид\", \r\nCASE \r\n    WHEN \"однолетнее\" = True THEN 'Да' \r\n    ELSE 'Нет' \r\nEND as \"Однолетнее?\",\r\n\"название_семейства\" as \"Семейство\", \r\nCOUNT(\"Растения\".*) as \"Количество\"\r\nFROM \"Города\"\r\nINNER JOIN \"Сады\" ON \"Сады\".\"код_города\" = \"Города\".\"код_города\"\r\nINNER JOIN \"Участки\" ON \"Участки\".\"регистрационный_номер_сада\" = \"Сады\".\"регистрационный_номер\"\r\nINNER JOIN \"Растения\" ON \"Растения\".\"код_участка\" = \"Участки\".\"код_участка\"\r\nINNER JOIN \"Каталог\" ON \"Растения\".\"номер_в_каталоге\" = \"Каталог\".\"номер_растения_в_каталоге\"\r\nINNER JOIN \"Виды\" ON \"Виды\".\"код_вида\" = \"Каталог\".\"код_вида\"\r\nINNER JOIN \"Семейства\" ON \"Семейства\".\"код_семейства\" = \"Виды\".\"код_семейства\"\r\nWHERE \"название_города\" = @Param\r\nGROUP BY \"название_города\", \"название_растения\", \"название_вида\", \"однолетнее\", \"название_семейства\"\r\nHAVING COUNT(\"Растения\".*) >= @Param2\r\nORDER BY \"название_растения\" DESC;"},
                    {"Запрос на запросе по принципу итогового запроса №5", "SELECT \"регистрационный_номер\" as \"Номер сада\",\r\n\"название_сада\" as \"Название сада\", \r\nCOUNT(\"Сотрудники\".*) as \"Количество\", \r\nCONCAT(round((COUNT(\"Сотрудники\".*) * 100.0 / (SELECT COUNT(*) FROM \"Сотрудники\")), 2), '%') as \"Процент\"\r\nFROM \"Сады\"\r\nLEFT JOIN \"Сотрудники\" ON \"Сотрудники\".\"регистрационный_номер_сада\" = \"Сады\".\"регистрационный_номер\"\r\nGROUP BY \"регистрационный_номер\"\r\nORDER BY \"Количество\" DESC;"},
                    {"Запрос с подзапросом №6", "SELECT \r\n\"регистрационный_номер\" as \"регистрационный номер\", \r\n\"название_сада\" as \"Название сада\", \r\n\"год_открытия\" as \"Год открытия\", \r\n\"название_города\" as \"Города\", \r\n\"тип_собственности\" as \"Тип собственности\"\r\nFROM \"Сады\"\r\nJOIN \"Города\" ON \"Сады\".\"код_города\" = \"Города\".\"код_города\"\r\nJOIN \"Типы собственности\" ON \"Сады\".\"код_типа_собственности\" = \"Типы собственности\".\"код_собственности\"\r\nWHERE \"год_открытия\" > (\r\n\tSELECT AVG(\"год_открытия\")\r\n\tFROM \"Сады\"\r\n);"}
                };

            }
            else if (level == RequestLevel.Individual)
            {
                TextForm += "\"Курсовые запросы\"";
                RequestList = new SortedDictionary<string, string>()
                {
                    { "a) Процент растений посаженных до 2010 года по всем садам №1", "SELECT * FROM percent_before_2010_in_all_gardens" },
                    { "a) Процент растений посаженных до 2010 года для каждого сада №2", "SELECT * FROM percent_before_2010_for_each_garden \r\nORDER BY percent_before_2010_for_each_garden.\"Номер сада\"" },
                    { "a) Процент растений посаженных до 2010 года для каждого сада №3, относительно общего процента растений.", "SELECT * FROM percent_before_2010_for_each_garden_percentage_for_all_plants" },
                    { "b) Средний возраст сотрудников по всем садам №4", "SELECT * FROM avg_age_of_employees" },
                    { "b) Средний возраст сотрудников для каждого сада №5", "SELECT * FROM avf_age_employees_for_each_garden" },
                    { "с) Суммарные расходы по уходу за растениями №6", "SELECT * FROM total_plant_care_costs" },
                    { "с) Количество растений по каждому саду №7", "SELECT * FROM count_plants_for_each_garden" },
                };
            }
            else if (level == RequestLevel.Technical)
            {
                TextForm += "\"Технические запросы\"";

                RequestList = new SortedDictionary<string, string>()
                {
                    { "Итоговый запрос без условия c итоговыми данными вида: «Всего» №1" , "SELECT COUNT(*) as \"Всего удобрений\", \r\nround(AVG(\"стоимость_средства\"), 2) as \"Средняя стоимость всех удобрений\" \r\nFROM \"Средства ухода\";" },
                    { "Итоговый запрос без условия c итоговыми данными вида: «В том числе» №2" , "SELECT COUNT(\"Семейства\".*) as \"Всего семейств\", \r\nCOUNT(\"Виды\".*) as \"Всего видов\", \r\nround(AVG(\"Каталог\".\"срок_жизни_растения\"), 2) as \"Средняя стоимость растений\"\r\nFROM \"Каталог\"\r\nFULL JOIN \"Виды\" ON \"Виды\".\"код_вида\" = \"Каталог\".\"код_вида\"\r\nFULL JOIN \"Семейства\" ON \"Семейства\".\"код_семейства\" = \"Виды\".\"код_семейства\";" },
                    { "Итоговый запрос с условием на данные по значению №3" , "SELECT \r\n\"регистрационный_номер\" as \"Код сада\", \r\n\"название_сада\" as \"Название сада\", \r\n\"название_города\" as \"Название города\", \r\n\"год_открытия\" as \"Год открытия\"\r\nFROM \"Сады\"\r\nINNER JOIN \"Города\" ON \"Города\".\"код_города\" = \"Сады\".\"код_города\"\r\nINNER JOIN \"Типы собственности\" types_owership ON types_owership.\"код_собственности\" = \"Сады\".\"код_типа_собственности\" \r\nWHERE \"тип_собственности\" = @Param;" },
                    { "Итоговый запрос с условием на данные по маске №4" , "SELECT \r\n\"регистрационный_номер\" as \"Код сада\", \r\n\"название_сада\" as \"Название сада\", \r\nCOUNT(\"Сотрудники\".*) as \"Количество\"\r\nFROM \"Сады\"\r\nLEFT JOIN \"Сотрудники\" ON \"Сады\".\"регистрационный_номер\" = \"Сотрудники\".\"регистрационный_номер_сада\"\r\nWHERE \"имя\" LIKE @Param%\r\nGROUP BY \"регистрационный_номер\";" },
                    { "Итоговый запрос с условием на данные с использованием индекса №5" , "SELECT \r\n\"код_растения\" as \"Код растения\", \r\n\"код_участка\" as \"Код участка\", \r\n\"название_растения\" as \"Название растения\", \r\n\"стоимость_саженца\" as \"Стоимость саженца\", \r\n\"название_вида\" as \"Вид\", \r\n\"название_семейства\" as \"Семейство\", \r\n\"фото_растения\" as \"Фото растения\", \r\n\"дата_посадки\" as \"Дата посадки\", \r\n\"дата_гибели\" as \"Дата гибели\"\r\nFROM \"Растения\"\r\nINNER JOIN \"Каталог\" ON \"Каталог\".\"номер_растения_в_каталоге\" = \"Растения\".\"номер_в_каталоге\"\r\nINNER JOIN \"Виды\" ON \"Виды\".\"код_вида\" = \"Каталог\".\"код_вида\"\r\nINNER JOIN \"Семейства\" ON \"Семейства\".\"код_семейства\" = \"Виды\".\"код_семейства\"\r\nWHERE \"стоимость_саженца\" >= @Param;" },
                    { "Итоговый запрос с условием на данные без использования индекса №6" , "SELECT \r\n\"название_растения\" as \"Название растения\", \r\n\"название_вида\" as \"Вид\", \r\n\"срок_жизни_растения\" as \"Строк жизни\", \r\nCASE \r\n    WHEN \"однолетнее\" = True THEN 'Да' \r\n    ELSE 'Нет' \r\nEND as \"Однолетнее?\",\r\n\"название_семейства\" as \"Семейство\"\r\nFROM \"Каталог\"\r\nINNER JOIN \"Виды\" ON \"Виды\".\"код_вида\" = \"Каталог\".\"код_вида\"\r\nINNER JOIN \"Семейства\" ON \"Семейства\".\"код_семейства\" = \"Виды\".\"код_семейства\"\r\nWHERE \"срок_жизни_растения\" >= @Param;" },
                    { "Запрос с использованием объединения №7" , "SELECT \"название_семейства\" AS \"Название\", 'Семейство' AS \"Тип\", '-' AS \"Подвязка\"\r\nFROM \"Семейства\"\r\nUNION\r\nSELECT \"название_вида\", 'Вид', \"название_семейства\"\r\nFROM \"Виды\"\r\nINNER JOIN \"Семейства\" ON \"Семейства\".\"код_семейства\" = \"Виды\".\"код_вида\"\r\nORDER BY \"Тип\" DESC;" },
                    { "Запрос с подзапросом с использованием IN №8" , "SELECT \"название_вида\" as \"Вид\", \r\nCOUNT(\"Каталог\".*) as \"Количество растений\"\r\nFROM \"Виды\"\r\nLEFT JOIN \"Каталог\" ON \"Каталог\".\"код_вида\" = \"Виды\".\"код_вида\"\r\nWHERE \r\n(\r\n    SELECT TRUE\r\n    FROM \"Семейства\" \r\n    WHERE \"название_семейства\" IN \r\n    (\r\n        'Паслёновые', 'Паслёновые', 'Вахтовые', 'Valerianaceae', 'Дымянковые'\r\n    ) \r\n    AND \"Семейства\".\"код_семейства\" = \"Виды\".\"код_семейства\"\r\n)\r\nGROUP BY \"название_вида\"\r\nORDER BY \"название_вида\" DESC;" },
                    { "Запрос с подзапросом с использованием NOT IN №9" , "SELECT \r\n\"Растения\".\"код_растения\" as \"Код растения\", \r\n\"название_растения\" as \"Название растения\", \r\n\"название_вида\" as \"Вид\", \r\nCOUNT(history.*) as \"Количество уходов\"\r\nFROM \"Растения\"\r\nLEFT JOIN \"История ухода\" history ON history.\"код_растения\" = \"Растения\".\"код_растения\"\r\nINNER JOIN \"Каталог\" ON \"Каталог\".\"номер_растения_в_каталоге\" = \"Растения\".\"номер_в_каталоге\"\r\nINNER JOIN \"Виды\" ON \"Виды\".\"код_вида\" = \"Каталог\".\"код_вида\"\r\nWHERE \r\n(\r\n    SELECT TRUE\r\n    FROM \"Семейства\" \r\n    WHERE \"название_семейства\" NOT IN \r\n    (\r\n        'Rosaceae', 'Иксонантовые', 'Стилидиевые', 'Вахтовые', 'Ленноовые', 'Сипаруновые', 'Педалиевые', 'Melastomataceae'\r\n    ) \r\n    AND \"Семейства\".\"код_семейства\" = \"Виды\".\"код_семейства\"\r\n)\r\nGROUP BY \"Растения\".\"код_растения\", \"название_растения\", \"название_вида\"\r\nORDER BY \"Количество уходов\" DESC;" },
                    { "Запрос с подзапросом с использованием CASE №10" , "SELECT \"код_растения\" as \"Код растения\", \r\n\"название_растения\" as \"Название растения\", \r\n\"название_вида\" as \"Название вида\", \r\n\"название_семейства\" as \"Название семейства\", \r\nCASE\r\n    WHEN \"дата_гибели\" IS NULL \r\n        THEN ((UPPER(daterange(\"дата_посадки\",  current_date)) - LOWER(daterange(\"дата_посадки\", current_date))) / 365)\r\n\r\n    ELSE \r\n        ((UPPER(daterange(\"дата_посадки\",  \"дата_гибели\")) - LOWER(daterange(\"дата_посадки\", \"дата_гибели\"))) / 365)\r\nEND as \"Прожитых лет\",\r\n\"регистрационный_номер\" as \"Номер сада\",\r\n\"название_сада\" as \"Название сада\",\r\n\"название_города\" as \"Город\"\r\nFROM \"Растения\"\r\nINNER JOIN \"Каталог\" ON \"Каталог\".\"номер_растения_в_каталоге\" = \"Растения\".\"номер_в_каталоге\"\r\nINNER JOIN \"Виды\" ON \"Виды\".\"код_вида\" = \"Каталог\".\"код_вида\"\r\nINNER JOIN \"Семейства\" ON \"Семейства\".\"код_семейства\" = \"Виды\".\"код_семейства\"\r\nINNER JOIN \r\n(\r\n    SELECT \r\n    \"название_города\", \r\n    \"регистрационный_номер\",\r\n    \"название_сада\",\r\n    \"код_участка\"\r\n    FROM \"Сады\" \r\n    INNER JOIN \"Участки\" ON \"Участки\".\"регистрационный_номер_сада\" = \"Сады\".\"регистрационный_номер\"\r\n\tINNER JOIN \"Города\" ON \"Города\".\"код_города\" = \"Сады\".\"код_города\"\r\n    --WHERE \"код_участка\" = \"Растения\".\"код_участка\"\r\n) AS \"Города сады\" ON \"Города сады\".\"код_участка\" = \"Растения\".\"код_участка\";" },
                    { "Запрос с подзапросом с использованием операциями над итоговыми данными №11" , "SELECT \r\n\"Сады\".\"регистрационный_номер\" as \"Код сада\",\r\n\"Сады\".\"название_сада\" as \"Название сада\",\r\nCOUNT(\"Растения\".\"код_растения\") AS \"Количество растений\"\r\nFROM \"Сады\"\r\nINNER JOIN \"Участки\" ON \"Сады\".\"регистрационный_номер\" = \"Участки\".\"регистрационный_номер_сада\"\r\nINNER JOIN \"Растения\" ON \"Участки\".\"код_участка\" = \"Растения\".\"код_участка\"\r\nINNER JOIN \r\n(\r\n    SELECT \"Растения\".\"код_растения\",\r\n    MAX(\"История ухода\".\"дата_обработки\") AS \"дата_обработки\"\r\n    FROM \"Растения\"\r\n    INNER JOIN \"История ухода\" ON \"Растения\".\"код_растения\" = \"История ухода\".\"код_растения\"\r\n    GROUP BY \"Растения\".\"код_растения\"\r\n) \r\nAS \"Последний уход\" ON \"Растения\".\"код_растения\" = \"Последний уход\".\"код_растения\"\r\nWHERE \"Последний уход\".\"дата_обработки\" <= @Param\r\nGROUP BY \"Сады\".\"регистрационный_номер\", \"Сады\".\"название_сада\"\r\nHAVING COUNT(\"Растения\".\"код_растения\") >= @Param2\r\nORDER BY \"Количество растений\" DESC;" }
                };
            }
            else return;

            this.Text = TextForm;

            RequestList_ComboBox.DataSource = new BindingSource(RequestList, null);
            RequestList_ComboBox.DisplayMember = "Key";
            RequestList_ComboBox.ValueMember = "Value";

            this.request_level = level;
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

        private void RequestList_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Request_TextBox.Text = RequestList_ComboBox.SelectedValue.ToString();
        }

        private async void StartRequest_Button_Click(object sender, EventArgs e)
        {
            string SQL = Request_TextBox.Text;

            if
            (
                (Regex.IsMatch(SQL, "@Param") && Parameter_TextBox.Text.Length == 0) || 
                (Regex.IsMatch(SQL, "@Param2") && Parameter_two_TextBox.Text.Length == 0) ||
                (Regex.IsMatch(SQL, "@Param%") && Parameter_TextBox.Text.Length == 0)
            )
            {
                MessageBox.Show("Данный запрос имеет параметр, " +
                    "поэтому текстовое поле для параметров не может быть пустым!", 
                    "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Loading_panel.Visible)
            {
                MessageBox.Show("Дождитесь коца выполнения запроса перед переключением!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Loading_panel.Visible = true;

            SQL = Regex.Replace(SQL, "@Param2", $"'{Parameter_two_TextBox.Text}'");
            SQL = Regex.Replace(SQL, "@Param%", $"'{Parameter_TextBox.Text}%'");
            SQL = Regex.Replace(SQL, "@Param", $"'{Parameter_TextBox.Text}'");

            await Task.Run(() =>
            {
                DataTable dt;

                try
                {
                    dt = MainForm.getDataTable(SQL);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    dataGridView_RequestTable.Invoke((MethodInvoker)delegate
                    {
                        dataGridView_RequestTable.DataSource = dt;
                        CountEtryLable.Text = "| Записей: " + dataGridView_RequestTable.Rows.Count;
                    });
                } catch { };
            });

            Loading_panel.Invoke((MethodInvoker)delegate
            {
                Loading_panel.Visible = false;
            });
        }

        private async void сохранитьВEXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView_RequestTable.DataSource == null)
            {
                MessageBox.Show("Таблицы полностью пуста!\nВыполните любой запрос для того что-бы записать результат в Excel.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Лист Miscrosoft Excel (*.xlsx)|*.xlsx",
                FileName = "result.xlsx",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            string path = saveFileDialog.FileName;

            DataTable dt = (DataTable)dataGridView_RequestTable.DataSource;//Экземпляр данные DataGridView

            await Task.Run(() =>
            {
                ///--------------Создаем экземпляр Excel файла
                Excel excel = new Excel(path, 1);

                int rowsCount = dt.Rows.Count;
                int columnsCount = dt.Columns.Count;

                if(columnsCount > 0)
                {
                    string[,] ColumnsNames = new string[1, columnsCount];

                    ///--------------Записываем заголовки таблицы в Excel
                    for (int i = 0; i < columnsCount; ++i)
                        ColumnsNames[0, i] += dt.Columns[i].ColumnName;

                    excel.WriteRange(0, 0, 0, columnsCount - 1, ColumnsNames);
                }

                ///--------------Записываем данные таблицы в Excel файл
                if (rowsCount > 0)
                {
                    string[,] resultArray = new string[rowsCount, columnsCount];

                    for (int i = 0; i < rowsCount; i++)
                    {
                        for (int j = 0; j < columnsCount; j++)
                        {
                            resultArray[i, j] = Convert.ToString(dt.Rows[i].Field<object>(j));
                        }
                    }

                    ///--------------
                    excel.WriteRange(1, 0, rowsCount - 1, columnsCount - 1, resultArray);
                    ///--------------
                }

                excel.Save();
                excel.Close();
            });
        }

        private async void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_RequestTable.DataSource == null)
            {
                MessageBox.Show("Таблицы полностью пуста!\nВыполните любой запрос для того что-бы записать результат в Excel.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text files(*.txt)|*.txt|XML files(*.xml)|*.xml|All files(*.*)|*.*",
                FileName = "result.txt",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            string path = saveFileDialog.FileName;
            DataTable dt = (DataTable)dataGridView_RequestTable.DataSource;
            dt.TableName = "ResultTable";

            await Task.Run(() =>
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
                    {
                        if (Path.GetExtension(path).Equals(".xml"))
                        {
                            dt.WriteXml(sw);
                        }
                        else
                        {
                            string DataTableString = string.Join("| |", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                            DataTableString += "\r\n" + string.Join(Environment.NewLine, dt.Rows.Cast<DataRow>().Select(row => string.Join("| |", row.ItemArray)));
                            sw.Write(DataTableString);
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            });


        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TextMessage = "";
            string TypeMessage = "";

            switch(request_level)
            {
                case RequestLevel.Essy:
                    TypeMessage = "Справка: Простые запросы";
                    TextMessage = @"Внутрненее соединение №1.1 с условием: По ключу_1.
Получить ФИО всех сотрудников являющихся специалистами по ботанике, их должности, и сады в которых они работают.

Внутрненее соединение №1.2 с условием: По ключу_2.
Получить Данные об всех историях обработки для выбранного сада.

Внутрненее соединение №1.3 с условием: По дате_1.
Получить все растения дата посадки которых <= заданной дате и номера сада в котором они находятся.

Внутрненее соединение №1.4 с условием: По дате_2.
Получить все растения дата гибели которых >= заданной дате и номера сада в котором они находятся.

Внутрненее соединение №2.1 без условия.
Растения и их описание.

Внутрненее соединение №2.2 без условия.
Сотрудники обслужившие растения и количество растений.

Внутрненее соединение №2.3 без условия.
Количество садов в каждом городе.

Левое соединение №3.
Подсчет общего количества растения в каждом городе.

Правое соединение №4.
Количество видов в семействе.

Запрос с подзапросом №5.
Сумарные затраты на уход за растениями по кажому саду.";
                    break;

                case RequestLevel.Hard:
                    TypeMessage = "Справка: Сложные запросы";
                    TextMessage = @"Итоговый запрос без условия №1.
Сколько семейства насчитывают видов и растений из каталога.

Итоговый запрос с условием на данные №2.
Подсчет общего количества растений из каталога которые прожили меньше 2% от своего срока жизни.

Итоговый запрос с условием на группы №3.
Получить среднюю стоимость растения из каталога которая больше @Param и количество растений.

Итоговый запрос с условием на данные и на группы №4.
Количество растений для города выбранного пользователем.

Запрос на запросе по принципу итогового запроса №5.
Процент сотрудников в каждом саду относительно всех сотрудников.

Запрос с подзапросом №6.
Cады, которые имеют год открытия позже, чем средний год открытия всех садов.";
                    break;

                case RequestLevel.Individual:
                    TypeMessage = "Справка: Курсовые запросы";
                    TextMessage = "Описание всех запросов соответствует их названиию.";
                    break;
            }

            MessageBox.Show(TextMessage, TypeMessage);

        }

        private void RequestForm_SizeChanged(object sender, EventArgs e)
        {
            if (Loading_panel.Visible)
                Loading_label.Location = new Point(Loading_panel.Width / 2 - Loading_label.Width / 2, Loading_panel.Height / 2 - Loading_label.Height / 2);
        }
    }
}
