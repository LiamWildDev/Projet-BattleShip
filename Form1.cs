using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class Form1 : Form
    {
        
        Plateau plateauJoueur = new Plateau(8,8,false,25);
        Plateau plateauAdversaire = new Plateau(8, 8, true, 25);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
    


        private void pictureBoxAdversiare_Paint(object sender, PaintEventArgs e)
        {
            Bitmap imageAdversaire = plateauAdversaire.Dessiner();
            e.Graphics.DrawImage(imageAdversaire, 0, 0);
        }

        private void pictureBoxJoueur_Paint(object sender, PaintEventArgs e)
        {
            Bitmap imageJoueur = plateauJoueur.Dessiner();
            e.Graphics.DrawImage(imageJoueur, 0, 0);
        }

        private void pictureBoxAdversiare_MouseUp(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int positionX = e.X;
            int positionY = e.Y;
            plateauAdversaire.Tir(positionX, positionY);
            pictureBoxAdversiare.Invalidate();
            if (plateauAdversaire.EstMort())
            {
                MessageBox.Show("Vous avez gagné");
                Reinitialiser();
            }
            int positionXOrdinateur = random.Next(0, 25 * 8);
            int positionYOrdinateur = random.Next(0, 25 * 8);
            plateauJoueur.Tir(positionXOrdinateur, positionYOrdinateur);
            pictureBoxJoueur.Invalidate();
            
            if (plateauJoueur.EstMort())
            {
                MessageBox.Show("Vous avez perdu");
                Reinitialiser();
            }
        }

        private void Reinitialiser()
        {
            plateauJoueur = new Plateau(8, 8, false, 25);
            plateauAdversaire = new Plateau(8, 8, true, 25);
            pictureBoxAdversiare.Invalidate();
            pictureBoxJoueur.Invalidate();
        }
    }
    
}
