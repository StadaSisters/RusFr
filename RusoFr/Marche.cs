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
    public partial class Marche : Form
    {
        public Marche()
        {
            InitializeComponent();
            this.Shown += Marche_Shown;
        }

        private void btnLancerTest_Click(object sender, EventArgs e)
        {
            var questionsMarche = new List<TestForm.Question>
            {
                new TestForm.Question
                {
                    Texte = "Рыба",
                    Choix = new List<string> { "Вьянд", "Крёвэт", "Пуассон", "Шампинён" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Помидор",
                    Choix = new List<string> { "Оранж", "Карот", "Рэзэн", "Томат" },
                    IndexBonneReponse = 3
                },
                  new TestForm.Question
                {
                    Texte = "Виноград",
                    Choix = new List<string> { "Оранж", "Рэзэн", "Томат", "Карот"},
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Молоко",
                    Choix = new List<string> { "Жю", "Миэл", "Лэ", "Пэн" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Бананы",
                    Choix = new List<string> { "Оранж", "Лэтю", "Ситрон", "Банан" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Хлеб",
                    Choix = new List<string> { "Миэль", "Пэн", "Томат", "Карот" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Сок",
                    Choix = new List<string> { "Жю", "Миэл", "Лэ", "Пэн" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Огурец",
                    Choix = new List<string> { "Конкомбр", "Лэтю", "Ситрон", "Карот" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Это дешевго?",
                    Choix = new List<string> { "Сэ дё бон калитэ?", "Сэ гратуи?", "Сэ бон маршэ?", "Сэ мюр?" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Варенье",
                    Choix = new List<string> { "Бёр", "Конфитюр", "Жёлэ", "Фромаж" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Сколько это стоит?",
                    Choix = new List<string> { "Кэскё сэ?", "Кэл кантитэ?", "Комбьян дюнитэ?", "Комбьян са кут?" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Конфеты",
                    Choix = new List<string> { "Жёлэ", "Бонбон", "Гато", "Конфитюр" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Масло",
                    Choix = new List<string> { "Жёлэ", "Конфитюр", "Бёр", "Фромаж" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Пожалуйста, килогрмм...",
                    Choix = new List<string> { "Ун кило, силь ву плэ", "Ун мармит, силь ву плэ", "Ун сашэ, силь ву плэ", "Ун сак, силь ву плэ" },
                    IndexBonneReponse = 0
                },
                 new TestForm.Question
                {
                    Texte = "Где находиться ближайший рынок?",
                    Choix = new List<string> { "У сё трув лэписри ла плю прош?", "У сё трув ла бушри ла плю прош?", "У сё трув лё марше лё плю прош?", "У сё трув ла буланжри ла плю прош?" },
                    IndexBonneReponse = 2
                }
            };
            TestForm test = new TestForm(questionsMarche);
            this.Hide();
            test.ShowDialog();
            this.Show();

        }
        private void Marche_Shown(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);

        }
    }
}
