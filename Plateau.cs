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
    public class Plateau
    {
        static Random random = new Random();
        readonly int nbTuilesLigne = 8;
        readonly int nbTuilesColonne = 8;
        private int tailleTuile;
        private int taillePlateau;
        private int[,] tableauTuile;
        bool brouillardDeGuerre;
        bool verifierGagnant;
        Tuile[,] tuileCarte;

        public Plateau(int nbTuilesLigne, int nbTuilesColonne, bool brouillardDeGuerre, int tailleTuile)
        {
            this.nbTuilesLigne = nbTuilesLigne;
            this.nbTuilesColonne = nbTuilesColonne;
            BrouillardDeGuerre = brouillardDeGuerre;
            TailleTuile = tailleTuile;

            tuileCarte = new Tuile[nbTuilesLigne, nbTuilesColonne];
            for (int indexLigne = 0; indexLigne < nbTuilesLigne; indexLigne++)
            {
                for (int indexColonne = 0; indexColonne < nbTuilesColonne; indexColonne++)
                {
                    Tuile tuile = new Tuile(tailleTuile,tailleTuile);
                    tuileCarte[indexLigne, indexColonne] = tuile;
                }
            }
            PlacerBateau();
        }

        public Bitmap Dessiner()
        {
            Bitmap imagePlateau = new Bitmap(nbTuilesLigne * TailleTuile, nbTuilesColonne * TailleTuile);
            using (Graphics dessinateurPlateau = Graphics.FromImage(imagePlateau))
            {
                for (int indexLigne = 0; indexLigne < nbTuilesLigne; indexLigne++)
                {
                    for (int indexColonne = 0; indexColonne < nbTuilesColonne; indexColonne++)
                    {
                        if (BrouillardDeGuerre == true)
                        {
                            Bitmap imageTuile = tuileCarte[indexLigne, indexColonne].Dessiner(true);
                            int positionX = indexLigne * TailleTuile;
                            int positionY = indexColonne * TailleTuile;
                            dessinateurPlateau.DrawImage(imageTuile, positionX, positionY);
                        }
                        else
                        {
                            Bitmap imageTuile = tuileCarte[indexLigne, indexColonne].Dessiner(false);
                            int positionX = indexLigne * TailleTuile;
                            int positionY = indexColonne * TailleTuile;
                            dessinateurPlateau.DrawImage(imageTuile, positionX, positionY);
                        }
                        
                    }
                }
                Pen pen = new Pen(Color.Black);
                
                for (int indexColonne = 0; indexColonne < nbTuilesColonne; indexColonne++)
                {
                    dessinateurPlateau.DrawLine(pen, indexColonne * TailleTuile, 0, indexColonne * TailleTuile, TailleTuile * nbTuilesLigne);
                }
                for (int indexLigne = 0; indexLigne < nbTuilesLigne; indexLigne++)
                {
                    dessinateurPlateau.DrawLine(pen, 0, indexLigne * TailleTuile, nbTuilesColonne * TailleTuile, indexLigne * TailleTuile);
                }
            }
            return imagePlateau;
        }

        public void PlacerBateau()
        {
            int cpt = 0;
            while (cpt < 3)
            {
                int coordX = random.Next(0, nbTuilesLigne);
                int coordY = random.Next(0, nbTuilesColonne);
                if (!tuileCarte[coordX,coordY].BateauPresent)
                {
                    tuileCarte[coordX, coordY].BateauPresent = true;
                    cpt++;
                }
                
            }
            

        }

        public void Tir(int positionX, int positionY)
        {
            int coordX = positionX / TailleTuile;
            int coordY = positionY / TailleTuile;
            coordX = Math.Min(coordX, nbTuilesColonne - 1);
            coordY = Math.Min(coordY, nbTuilesLigne - 1);
            tuileCarte[coordX, coordY].TirPresent = true;
        }

        public bool EstMort()
        {
            //tour grille avec 2 for si je trouve un bateau vivant je retourne faux
            //apres 2 for si jai jamais retourner faux je retourn vrai
            int indexLigne;
            int indexColonne;
            int count = 0;
            for (indexLigne = 0; indexLigne < nbTuilesLigne; indexLigne++)
            {
                for (indexColonne = 0; indexColonne < nbTuilesColonne; indexColonne++)
                {
                    if (tuileCarte[indexLigne, indexColonne].BateauPresent == true && tuileCarte[indexLigne, indexColonne].TirPresent == true)
                    {
                        count++;
                        if (count == 3)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int TaillePlateau { get => taillePlateau; set => taillePlateau = value; }
        public int[,] TableauTuile { get => tableauTuile; set => tableauTuile = value; }
        public bool BrouillardDeGuerre { get => brouillardDeGuerre; set => brouillardDeGuerre = value; }
        public bool VerifierGagnant { get => verifierGagnant; set => verifierGagnant = value; }
        public int TailleTuile { get => tailleTuile; set => tailleTuile = value; }
    }
}
