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
    public partial class Conversation : Form
    {
        public Conversation()
        {
            InitializeComponent();
            this.Shown += Conversation_Shown;
        }

        private void btnLancerTest_Click(object sender, EventArgs e)
        {
            var questionsConversation = new List<TestForm.Question>
            {
                new TestForm.Question
                {
                    Texte = "Пожалуйста",
                    Choix = new List<string> { "Мэрси", "Силь ву плэ", "О рэвуар", "Жё ву зан при" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Спасибо",
                    Choix = new List<string> {"Мэрси", "Силь ву плэ", "О рэвуар", "Жё ву зан при" },
                    IndexBonneReponse = 0
                },
                  new TestForm.Question
                {
                    Texte = "Хорошо",
                    Choix = new List<string> { "Маль", "Мовэ", "Пардон", "Бьян" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Конечно",
                    Choix = new List<string> { "Бьян сюр", "Транкилман", "Терминэ", "Дакор" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Да",
                    Choix = new List<string> { "С э врэ", "Уи", "Нон", "Маль" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Спасибо большое",
                    Choix = new List<string> { "Жё ву сюи реконэсан", "Мэрси боку", "Жё ву зан при", "Мэрси" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Нет",
                    Choix = new List<string> { "Уи", "Окей", "Нон", "Дан" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Ладно",
                    Choix = new List<string> { "Дакор", "Уи", "Нон", "Бьян" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Сейчас",
                    Choix = new List<string> { "Дёмен", "Матен", "Ту дё сюит", "Плю тар" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Давайте познакомимся!",
                    Choix = new List<string> { "Фёзон ла пэ!", "Фёзон ла гэр!", "Фёзон конэсанс!", "Фёзон л амур!" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Будте добры...",
                    Choix = new List<string> { "Эйе ла бонтэ дё...", "Эйе ла жуа...", "Эйе ла пэ...", "Эйе ла ви..." },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Как вас зовут?",
                    Choix = new List<string> { "Коман ву залэ?", "Коман талэву?", "Коман ву заплэву?", "Коман ва тэл?" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Повторите, пожалуйста!",
                    Choix = new List<string> { "Алэ ву зан, силь ву плэ!", "Рэпэтэ, силь ву плэ!", "Эдэ муа, силь ву плэ!", "Эмэ ву, силь ву плэ!" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Меня зовут...",
                    Choix = new List<string> { "Жё мамюз...", "Жё мэклипс...", "Жё мэм...", "Жё мапэль..." },
                    IndexBonneReponse = 3
                },
                 new TestForm.Question
                {
                    Texte = "Извините!",
                    Choix = new List<string> { "Пардон!", "Мэрси!", "О рёвуар!", "А демен!" },
                    IndexBonneReponse = 0
                }
            };
            TestForm test = new TestForm(questionsConversation);
            this.Hide();
            test.ShowDialog();
            this.Show();

        }
        private void Conversation_Shown(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);

        }
    }
}
