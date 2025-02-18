using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Rectangle : Forme
    {
        public int Longueur { get; set; }
        public int Largeur { get; set; }

        public Rectangle(int longueur, int largeur) : base()
        {
            Longueur = longueur;
            Largeur = largeur;
        }
        public Rectangle() : this(1, 1) { }

        public override string ToString()
        {
            return $"Rectangle: Point d'accroche {PointAccroche}, Longueur {Longueur}, Largeur {Largeur}";
        }
    }
}
