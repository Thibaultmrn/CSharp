using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Carre : Forme
    {
        public int Cote { get; set; }

        public Carre(int cote) : base()
        {
            Cote = cote;
        }

        public Carre() : this(1) { }

        public override string ToString()
        {
            return $"Carré: Point d'accroche {PointAccroche}, Côté {Cote}";
        }
    }
}
