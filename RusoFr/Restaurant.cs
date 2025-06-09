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
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
            this.Shown += Restaurant_Shown;
        }

        private void btnLancerTest_Click(object sender, EventArgs e)
        {
            var questionsRestaurant = new List<TestForm.Question>
            {
                new TestForm.Question
                {
                    Texte = "Бутерброд",
                    Choix = new List<string> { "Тартин", "Круассан", "Крэп", "Багэт" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Выпить шоколад",
                    Choix = new List<string> { "Буар дю жю", "Буар дю кафе", "Буар дю шокола", "Буар дю тэ" },
                    IndexBonneReponse = 2
                },
                  new TestForm.Question
                {
                    Texte = "Вот кофе",
                    Choix = new List<string> { "Вуаси лё пен", "Вуаси лё кафе", "Вуаси лё вен", "Вуаси лё жю" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Что вы порекомендуете нам?",
                    Choix = new List<string> { "Кё пувэ-ву ну дир?", "Кё пувэ-ву ну рёкомандэ?", "Кё пувэ-ву ну сюгжэрэ?", "Кё пувэ-ву ну апортэ?" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Поесть вкусно и недорого",
                    Choix = new List<string> { "Манжэ делисьэ э трэ шэр", "Манжэ делисьэ э па тро шэр", "Манжэ боку э па тро шэр", "Манжэ боку э трэ шэр" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Меню, пожалуйста!",
                    Choix = new List<string> { "Лё манто, силь ву плэ!", "Ладисьон, силь ву плэ!", "Дю кафе, силь ву плэ!", "Лё мёню, силь ву плэ!" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Приглашаю тебя на ресторан",
                    Choix = new List<string> { "Жё тэнвит а ла мэзон", "Жё тэнвит о синэма", "Жё тэнвит о рэсторан", "Жё тэнвит а лэглиз" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Здесь занято?",
                    Choix = new List<string> { "Сэт пляс этэль вид?", "Сэт пляс этэль окюпэ?", "Сэт пляс этэль рэзэрвэ?", "Сэт пляс этэль конфортабл?" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Мороженное",
                    Choix = new List<string> { "Жю", "Вэн", "Глас", "Лэ" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Цыпленка",
                    Choix = new List<string> { "Лё пулэ", "Лэ зэл", "Лё стэк", "Ла вуянд" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Я хочу попробовать что-нибудь новое",
                    Choix = new List<string> { "Жё вё гутэ кэлькёшоз дё дэлисьэ", "Жё вё гутэ кэлькёшоз дё савурё", "Жё вё гутэ кэлькёшоз дё нуво", "Жё вё гутэ кэлькёшоз дэлэктабл" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Хорошое вино!",
                    Choix = new List<string> { "Ун бон глас!", "Ун бон жю!", "Ун бон кафе!", "Ун бон вэн!" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Десерт",
                    Choix = new List<string> { "десэр", "Антрэ", "Динэ", "Дэжёнэ" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Это мясное блюдо?",
                    Choix = new List<string> { "Сэ тен пла дё вьянд? ", "Сэ сон дэ легюм?", "Сэ сон дэ фруи?", "Сэ тен пла дё ри?" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Гриба",
                    Choix = new List<string> { "Дю пулэ", "Дю пуассон", "Дю шампинён", "Дю кабри" },
                    IndexBonneReponse = 2
                }
            };
            TestForm test = new TestForm(questionsRestaurant);
            this.Hide();
            test.ShowDialog();
            this.Show();

        }
        private void Restaurant_Shown(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);

        }
    }
}
