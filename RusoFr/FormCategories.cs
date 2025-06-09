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
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
            
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.MistyRose;
                    btn.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
            }

        }
       
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightSkyBlue;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.MistyRose;
        }
        private void btnAirport_Click_1(object sender, EventArgs e)
        {
            Airport formA = new Airport();
            this.Hide();
            formA.ShowDialog();
            this.Show();
        }
        private void btnConversation_Click(object sender, EventArgs e)
        {
            Conversation formC = new Conversation();
            this.Hide();
            formC.ShowDialog();
            this.Show();
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            Restaurant formR = new Restaurant();
            this.Hide();
            formR.ShowDialog();
            this.Show();
        }

        private void btnMarche_Click(object sender, EventArgs e)
        {
            Marche formM = new Marche();
            this.Hide();
            formM.ShowDialog();
            this.Show();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            Hotel formH = new Hotel();
            this.Hide();
            formH.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
