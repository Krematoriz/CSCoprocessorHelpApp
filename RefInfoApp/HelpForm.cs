using System;
using System.Windows.Forms;

namespace RefInfoApp
{
    public partial class HelpForm : Form
    {
        // Массив String для хранения названия разделов справки
        string[] sections = new string[9];

        // Конструктор для класса формы
        public HelpForm()
        {
            // Стандартный метод инициализации элементов интерфейса
            InitializeComponent();

            // Добавление разделов справки в массив
            sections[0] = "Введение";
            sections[1] = "Понятие сопроцессора";
            sections[2] = "Программная модель сопроцессора";
            sections[3] = "Совместная работа процессора и сопроцессора";
            sections[4] = "Система команд сопроцессора";
            sections[5] = "Примеры программ";
            sections[6] = "Развитие системы инструкций Intel и AMD";
            sections[7] = "Контрольные вопросы";
            sections[8] = "Заключение";

            // Добавление разделов справки в RefNameBox
            FillSearch();

            // Загрузка HTML справки из ресурсов и передача его в документ браузера
            string html = Properties.Resources.Справка;

            // Загрузка пустой страницы в браузер
            this.HelpBrowser.Navigate("about:blank");
            // Создание переменной документа браузера
            HtmlDocument doc = this.HelpBrowser.Document;
            // Очистка документа (необходим в случае обновления страницы)
            doc.Write(String.Empty);
            // Запись кода HTML в документ браузера
            this.HelpBrowser.DocumentText = html;
        }

        // Метод фильтрации секций справки в зависимости от поиска
        private void FillSearch()
        {
            //Очиста RefNameBox
            RefNameBox.Items.Clear();
            // Если текст поиска пустой
            if(RefSearchBox.Text.Equals(""))
            {
                // Загрузка всех разделов справки в RefNameBox
                foreach(string section in sections)
                {
                    RefNameBox.Items.Add(section);
                }
            }
            // Если не пустой
            else
            {
                foreach (string section in sections)
                {
                    // Сравнивание поиска и названия раздела справки по очереди без учета регистра
                    if(section.ToLower().Contains(RefSearchBox.Text.ToLower()))
                        // В случае совпадения - добавляет раздел в RefNameBox
                        RefNameBox.Items.Add(section);
                }
            }
        }

        // Событие нажатия на секцию справки
        private void RefNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = RefNameBox.Text;
            HtmlElement sectionAnchor = null;

            // Выбор необходимой закладки в HTML в зависимости от выбранной секции справки
            if (choice.Equals("Введение"))
            {
                // Поиск необходимой закладки в документе браузера
                sectionAnchor = HelpBrowser.Document.GetElementById("C0");
                if (sectionAnchor != null)
                {
                    // Прокручивание до нужного элемента
                    sectionAnchor.ScrollIntoView(true);
                }
            }
            else if (choice.Equals("Понятие сопроцессора"))
            {
                sectionAnchor = HelpBrowser.Document.GetElementById("C1");
                if (sectionAnchor != null)
                {
                    sectionAnchor.ScrollIntoView(true);
                }
            }
            else if (choice.Equals("Программная модель сопроцессора"))
            {
                sectionAnchor = HelpBrowser.Document.GetElementById("C2");
                if (sectionAnchor != null)
                {
                    sectionAnchor.ScrollIntoView(true);
                }
            }
            else if (choice.Equals("Совместная работа процессора и сопроцессора"))
            {
                sectionAnchor = HelpBrowser.Document.GetElementById("C3");
                if (sectionAnchor != null)
                {
                    sectionAnchor.ScrollIntoView(true);
                }
            }
            else if (choice.Equals("Система команд сопроцессора"))
            {
                sectionAnchor = HelpBrowser.Document.GetElementById("C4");
                if (sectionAnchor != null)
                {
                    sectionAnchor.ScrollIntoView(true);
                }
            }
            else if (choice.Equals("Примеры программ"))
            {
                sectionAnchor = HelpBrowser.Document.GetElementById("C5");
                if (sectionAnchor != null)
                {
                    sectionAnchor.ScrollIntoView(true);
                }
            }
            else if (choice.Equals("Развитие системы инструкций Intel и AMD"))
            {
                sectionAnchor = HelpBrowser.Document.GetElementById("C6");
                if (sectionAnchor != null)
                {
                    sectionAnchor.ScrollIntoView(true);
                }
            }
            else if (choice.Equals("Контрольные вопросы"))
            {
                sectionAnchor = HelpBrowser.Document.GetElementById("C7");
                if (sectionAnchor != null)
                {
                    sectionAnchor.ScrollIntoView(true);
                }
            }
            else
            {
                sectionAnchor = HelpBrowser.Document.GetElementById("C8");
                if (sectionAnchor != null)
                {
                    sectionAnchor.ScrollIntoView(true);
                }
            }
        }

        // Событие изменения текста в строке поиска. Обновляет RefNameBox
        private void RefSearchBox_TextChanged(object sender, EventArgs e)
        {
            FillSearch();
        }
    }
}
