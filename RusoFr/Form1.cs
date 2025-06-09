using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RusoFr
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            Image votreImage = Image.FromFile("C:\\Users\\darli\\source\\repos\\RusoFr\\RusoFr\\drapeau.jpg");

            // Appliquez avec l'opacité désirée (ex: 0.5 = 50%)
            SetPanelBackgroundWithOpacity(panelEntree, votreImage, 0.45f);

            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.Transparent;
                    btn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
            }
        }
        private void SetPanelBackgroundWithOpacity(Panel panel, Image image, float opacity)
        {
            // Créez un Bitmap avec l'opacité ajustée
            Bitmap bmp = new Bitmap(panel.Width, panel.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // Contrôle l'opacité (0.0 - 1.0)

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix);

                // Dessinez l'image avec l'opacité
                g.DrawImage(
                    image,
                    new Rectangle(0, 0, panel.Width, panel.Height),
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel,
                    attributes);
            }

            // Appliquez l'image modifiée au panel
            panel.BackgroundImage = bmp;
            panel.BackgroundImageLayout = ImageLayout.Stretch; // Ajustez selon vos besoins
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightSteelBlue;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            FormCategories form2 = new FormCategories();
            this.Hide();
            form2.ShowDialog();
            this.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManuel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.GetFullPath(@"C:\Users\darli\source\repos\RusoFr\RusoFr\Руководство пользователя.docx"));

        }
    }
}
