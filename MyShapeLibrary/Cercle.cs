using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public int Diametre
        {
            get { return Rayon * 2; }
        }

        public Cercle(int rayon) : base()
        {
            Rayon = rayon;
        }

        public Cercle() : this(1) { }

       
        public override string ToString()
        {
            return $"Cercle: Centre {PointAccroche}, Rayon {Rayon}, Diamètre {Diametre}}";
        }
    }
}
