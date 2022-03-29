using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BattleShip
{
    public class Tuile
    {
        private int tailleX;
        private int tailleY;
        private bool bateauPresent;
        private bool tirPresent;

        public Tuile(int tailleX, int tailleY)
        {
            TailleX = tailleX;
            TailleY = tailleY;
            BateauPresent = false;
            TirPresent = false;
        }
        public Bitmap Dessiner(bool brouillardDeGuerre)
        {
            Bitmap tuile = new Bitmap(TailleX, TailleY);
            using (Graphics graphic = Graphics.FromImage(tuile))
            {
                Brush couleurDeFond;
                if (BateauPresent && brouillardDeGuerre && !TirPresent)
                {
                    couleurDeFond = Brushes.Blue;
                }
                else if (BateauPresent)
                {
                    couleurDeFond = Brushes.Gray;
                }
                else
                {
                    couleurDeFond = Brushes.Blue;
                }
                graphic.FillRectangle(couleurDeFond, new Rectangle(0, 0, TailleX, TailleY));
                if (TirPresent)
                {
                    graphic.FillEllipse(Brushes.Red, new Rectangle(0, 0, TailleX, TailleY));
                }
                if (TirPresent && BateauPresent)
                {
                    graphic.FillEllipse(Brushes.Black, new Rectangle(0, 0, TailleX, TailleY));
                }
            }
            return tuile;
        }

        public bool BateauPresent { get => bateauPresent; set => bateauPresent = value; }
        public bool TirPresent { get => tirPresent; set => tirPresent = value; }
        public int TailleX { get => tailleX; set => tailleX = value; }
        public int TailleY { get => tailleY; set => tailleY = value; }
    }
}
