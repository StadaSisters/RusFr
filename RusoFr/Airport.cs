using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RusoFr
{
    public partial class Airport : Form
    {
        public Airport()
        {
            InitializeComponent();
            this.Shown += Airport_Shown;
        }

        private void btnLancerTest_Click(object sender, EventArgs e)
        {
            var questionsAirport = new List<TestForm.Question>
            {
                new TestForm.Question
                {
                    Texte = "Транзитная виза?",
                    Choix = new List<string> { "Виза дё транзит", "Рэзидаис", "Виза этюдиан", "Виза дё коммерс" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Таможня?",
                    Choix = new List<string> { "Тамарк", "Травай", "Дуан", "Пор" },
                    IndexBonneReponse = 2
                },
                  new TestForm.Question
                {
                    Texte = "Ручная кладь?",
                    Choix = new List<string> { "Багаж а мен", "Вализ", "Сак а до", "Сашэ" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Деловая поездка?",
                    Choix = new List<string> { "Визит", "Вуайаж туристик", "Ваканс", "Вуайаж д афэр" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Мне нечего декларировать?",
                    Choix = new List<string> { "Жё н э рьен а манжэ", "Жё н э рьен а дэкларэ", "Жё н э рьен а вандр", "Жё н э рьен а аштэ" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Я могу взять сумку с собой?",
                    Choix = new List<string> { "Эскё жё пё прандр лё сак авэк муа?", "Эскё жё пё аштэ сё сак?", "Эскё жё пё прандр лё ливр авэк муа?", "Эскё жё пё парлэ авэк туа?" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Таможный досмотр?",
                    Choix = new List<string> { "Контроль", "Контроль рутье", "Контроль д идантитэ", "Контроль дуанье" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "У меня долларов?",
                    Choix = new List<string> { "Жэ дё л аржан", "Жэ дэ долар", "Жэ дю ликид", "Жэ дэ су" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Въездная виза?",
                    Choix = new List<string> { "Рэзиданс", "Виза дантрэ", "Виза туристик", "Виза коммэрсиял" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Я гражданин России?",
                    Choix = new List<string> { "Жё сюи ситуайен де Рюси", "Ж этюди ан Рюси", "Жё сюи президан де Рюси", "Жё ви ан Рюси" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Это подарки...",
                    Choix = new List<string> { "Сё сон дэ бижу", "Сё сон дэ шэз", "Сё сон дэ вуатюр", "Сё сон дэ кадо" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Вот паспорт",
                    Choix = new List<string> { "Вуаси мон мари", "Вуаси мон шьен", "Вуаси мон паспор", "Вуаси ма вализ" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Выездная виза",
                    Choix = new List<string> { "Виза дантрэ", "Виза дё сорти", "Виза дэтюд", "Виза элэктроник" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Где паспортный контроль?",
                    Choix = new List<string> { "У контроль-тон лэ бийэ?", "У дон-тон лэ паспор?", "У контроль-тон лэ паспор?", "У ван-тон лэ бийэ?" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Туристическая виза",
                    Choix = new List<string> { "Виза дё сорти", "Виза дэтюд", "Виза элэктроник", "Виза туристик" },
                    IndexBonneReponse = 3
                }
            };
            TestForm test = new TestForm(questionsAirport);
            this.Hide();
            test.ShowDialog();
            this.Show();
           
        }

        private void Airport_Shown(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);

        }
    }
}
