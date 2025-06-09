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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
            this.Shown += Hotel_Shown;
        }

        private void btnLancerTest_Click(object sender, EventArgs e)
        {
            var questionsHotel = new List<TestForm.Question>
            {
                new TestForm.Question
                {
                    Texte = "Не очень дорого!",
                    Choix = new List<string> { "Трэ шэр!", "Па тро шэр!", "Трэ онэрё!", "Трэ кутё!" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "У меня заказан номэр",
                    Choix = new List<string> { "Он ма рэзэрвэ ун шамбр", "Он на рэзэрвэ ун сюит", "Он на рэзэрвэ ун кабан", "Он ма рэзэрвэ ун вуатюр" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Номер на одного",
                    Choix = new List<string> { "Ун шамбр пур катр персон ", "Ун шамбр пур труа персон", "Ун шамбр пур дё персон", "Ун шамбр пур ун персон" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Есть ли для меня сообщения?",
                    Choix = new List<string> { "Авэву дэ месаж пур муа?", "Авэву дэ кэстьон пур муа?", "Авэву дэ з энформасьон пур муа?", "Авэву дэ сюгжестьон пур муа?" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "На одну ночь",
                    Choix = new List<string> { "Пур катр нюи", "Пур дё нюи", "Пур ун нюи", "Пур ун журнэ" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Дайте ключи от моего номера, пожалуйста",
                    Choix = new List<string> { "Жё вудрэ лэ клэ дё са шамбр, силь ву плэ", "Жё вудрэ лэ клэ дё ма шамбр, силь ву плэ", 
                                               "Жё вудрэ лэ клэ дё нотр шамбр, силь ву плэ", "Жё вудрэ лэ клэ дё лёр шамбр, силь ву плэ" },
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Можно я зарезервировать номер?",
                    Choix = new List<string> { "Пюж рэзэрвэ ун сюит?", "Пюж рэзэрвэ ун вуатюр?", "Пюж рэзэрвэ ун шамбр?", "Пюж рэзэрвэ дё шамбр?" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Номер с ванной",
                    Choix = new List<string> { "Ун шамбр авэк телевизьон", "Ун шамбр авэк рэфрижэратёр ", "Ун шамбр авэк саль дё бэн", "Ун шамбр авэк тэрас" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Номер с телевизором",
                    Choix = new List<string> { "Ун шамбр авэк телевизьон", "Ун шамбр авэк рэфрижэратёр ", "Ун шамбр авэк саль дё бэн", "Ун шамбр авэк тэрас" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Номер с холодильником",
                    Choix = new List<string> { "Ун шамбр авэк телевизьон", "Ун шамбр авэк рэфрижэратёр ", "Ун шамбр авэк саль дё бэн", "Ун шамбр авэк тэрас"},
                    IndexBonneReponse = 1
                },
                new TestForm.Question
                {
                    Texte = "Номер с балконом",
                    Choix = new List<string> { "Ун шамбр авэк телевизьон", "Ун шамбр авэк рэфрижэратёр ", "Ун шамбр авэк саль дё бэн", "Ун шамбр авэк балкон" },
                    IndexBonneReponse = 3
                },
                new TestForm.Question
                {
                    Texte = "Я бы хотел рассчитаться",
                    Choix = new List<string> { "Жё вудрэ рэглэ ла нот", "Ну вудрион рэглэ ла нот", "Эль вудрэ рэглэ ла нот", "Иль вудрэ рэглэ ла нот" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "На каком этаже мой номер?",
                    Choix = new List<string> { "А кэлэтаж сё трув ла куизин?", "А кэлэтаж сё трув ла писин?", "А кэлэтаж сё трув ма шамбр?", "А кэлэтаж сё трув лё гараж?" },
                    IndexBonneReponse = 2
                },
                new TestForm.Question
                {
                    Texte = "Я хочу платить наличными",
                    Choix = new List<string> { "Жё вудрэ пайе ан эспэс", "Иль вудрэ пайе ан эспэс", "Эль вудрэ пайе ан эспэс", "Ну вудрион пайе ан эспэс" },
                    IndexBonneReponse = 0
                },
                new TestForm.Question
                {
                    Texte = "Номер с интернетом",
                    Choix = new List<string> { "Ун шамбр авэк телевизьон", "Ун шамбр авэк рэфрижэратёр ", "Ун шамбр авэк саль дё бэн", "Ун шамбр авэк энтэрнэт" },
                    IndexBonneReponse = 3
                }

            };
            TestForm test = new TestForm(questionsHotel);
            this.Hide();
            test.ShowDialog();
            this.Show();

        }
        private void Hotel_Shown(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);

        }
    }
}
