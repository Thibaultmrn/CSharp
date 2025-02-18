using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{

    public abstract class Forme
    {
        public Coordonnee PointAccroche { get; set; }

        protected Forme()
        {
            PointAccroche = new Coordonnee();
        }
    }
}
