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
    public partial class TestForm : Form
    {
        // Structure pour stocker une question
        public class Question
        {
            public string Texte { get; set; }
            public List<string> Choix { get; set; }
            public int IndexBonneReponse { get; set; }
        }

        private List<Question> questions;
        private int questionActuelle = 0;
        private int score = 0;
        public TestForm(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
            btnSuivant.Enabled = false;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
            radioButton4.CheckedChanged += radioButton_CheckedChanged;
            AfficherQuestion();
        }
        private void ResetRadioButtons(bool enable)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton1.Enabled = enable;
            radioButton2.Enabled = enable;
            radioButton3.Enabled = enable;
            radioButton4.Enabled = enable;
        }

        private void AfficherQuestion()
        {
            if (questionActuelle < questions.Count)
            {
                var q = questions[questionActuelle];
                lblQuestion.Text = q.Texte;
                radioButton1.Text = q.Choix[0];
                radioButton2.Text = q.Choix[1];
                radioButton3.Text = q.Choix[2];
                radioButton4.Text = q.Choix[3];
                lblCorrection.Text = "";
                btnSuivant.Enabled=false;
                ResetRadioButtons(true);

            }
            else
            {
                MessageBox.Show($"Тест завершен! Правильных ответов: {score} из {questions.Count}");
                this.Close();
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            // Ne rien faire si c'est une désélection
            if (rb != null && !rb.Checked)
                return;

            // Récupère la question actuelle
            var q = questions[questionActuelle];
            int reponseUtilisateur = -1;

            if (radioButton1.Checked) reponseUtilisateur = 0;
            else if (radioButton2.Checked) reponseUtilisateur = 1;
            else if (radioButton3.Checked) reponseUtilisateur = 2;
            else if (radioButton4.Checked) reponseUtilisateur = 3;

            // Désactive tous les RadioButtons après avoir capturé la réponse
            ResetRadioButtons(false);
            if (reponseUtilisateur == q.IndexBonneReponse)
            {
                lblCorrection.Text = "Правильно, молодец!";
                score++;
            }
            else
            {
                lblCorrection.Text = $"Неверно! Правильный ответ - {q.Choix[q.IndexBonneReponse]}";
            }

            // Active le bouton "Suivant"
            btnSuivant.Enabled = true;
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {
           
            questionActuelle++;
            AfficherQuestion();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
