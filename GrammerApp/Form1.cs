using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrammerApp

 
{
    public partial class Form1 : Form
    {
        private Button currentActiveButton;
        private Color defaultButtonColor = Color.White;
        

        public Form1()
        {
            InitializeComponent();

            //attacher le meme gestionnaire d'evenements a tous les boutons concernes

            Dashboard.Click += Dashboard_Click;
            Bericht.Click += Bericht_Click;
            Proband.Click += Proband_Click;
            Teststeurung.Click += Teststeurung_Click;
            Start.Click += Start_Click;
            Stop.Click += Stop_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (currentActiveButton != null)
            {
                // Réinitialise la couleur du bouton précédemment actif
                currentActiveButton.BackColor = defaultButtonColor;
                
            }
            // Change la couleur du bouton actuellement cliqué
            clickedButton.BackColor = Color.White;

            // Enregistre le bouton cliqué comme actif
            currentActiveButton = clickedButton;
            panel2.Visible = true;
        }


        private void Proband_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (currentActiveButton != null)
            {
                // Réinitialise la couleur du bouton précédemment actif
                currentActiveButton.BackColor = defaultButtonColor;
            }
            

            // Change la couleur du bouton actuellement cliqué
            clickedButton.BackColor = Color.White;

            // Enregistre le bouton cliqué comme actif
            currentActiveButton = clickedButton;
            panel2.Visible = false;
        }

        private void Bericht_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (currentActiveButton != null)
            {
                // Réinitialise la couleur du bouton précédemment actif
                currentActiveButton.BackColor = defaultButtonColor;
            }

            // Change la couleur du bouton actuellement cliqué
            clickedButton.BackColor = Color.White;

            // Enregistre le bouton cliqué comme actif
            currentActiveButton = clickedButton;
            panel2.Visible = false;
        }

        private void Teststeurung_Click_1(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (currentActiveButton != null)
            {
                // Réinitialise la couleur du bouton précédemment actif
                currentActiveButton.BackColor = defaultButtonColor;

            }
            // Change la couleur du bouton actuellement cliqué
            clickedButton.BackColor = Color.CornflowerBlue;

            // Enregistre le bouton cliqué comme actif
            currentActiveButton = clickedButton;

            Start.Visible = true;
            Stop.Visible = true;
          
        }
    }
}
    