namespace MyShapeLibrary
{
    public class Coordonnee
    {
        private int X;
        private int Y;

        //Propriété X
        public int x
        {
            get { return X; }
            set { X = value; }
        }
        //Propriété Y
        public int y
        {
            get { return Y; }
            set { Y = value; }
        }

        //Constructeur d'initialisation
        public Coordonnee(int x,int y)
        {
            Y = y;
            X = x;
        }

        public Coordonnee() : this(0,0) { }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
