namespace MyShapeLibrary
{
    public class Coordonnee
    {
        public int X { get; set; }
        public int Y { get; set; }

        //Constructeur d'initialisation
        public Coordonnee(int x,int y)
        {
            Y = y;
            X = x;
        }

        //Constructeur par défaut
        public Coordonnee() : this(0,0) { }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
