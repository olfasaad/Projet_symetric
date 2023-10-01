// See https://aka.ms/new-console-template for more information



namespace Poo_TP2
{ 
       class Program
    {
        static void Main(string[] args)
        {  // parse pour convertie chaine en int 
            //Method 1: Constructeur d'inisialitation tu peux fait dans la meme ligne 
            Console.WriteLine("write the point to A1!!!");
            Point A1 = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //Method2 : Constructeur par defaut peut faire avec cette methode 
            Point A2 = new Point();
            //Method 3 Constructeur 
            Point c = new Point(-A1.getx(), -A1.gety());

            Console.WriteLine("write the point to A2");
            A2.setx(int.Parse(Console.ReadLine()));
            A2.sety(int.Parse(Console.ReadLine()));
            Segment Ab = new Segment(A1,A2);
            Console.WriteLine("Affichage d'un segment AB");
           Ab.affiche();
            Console.WriteLine("Voir si sont egaux ou non !!");
            if (A1.Equals(A2) == true)
                Console.WriteLine("yes it's Equal");
            else Console.WriteLine("no it's not Equal");

            Console.WriteLine("A1 avant translation("+A1.getx()+","+A1.gety()+")"+"");
            A1.translation(5,2);
           
            Console.WriteLine("A1 Apres translation(" + A1.getx() + "," + A1.gety() + ")" +"");
            Console.WriteLine("!!!!!!!!!!     A2     !!!!!");
            Console.WriteLine("A2 avant translation(" + A2.getx() + "," + A2.gety() + ")" + "");
            A2.translation(-5, -2);

            Console.WriteLine("A2 Apres translation(" + A2.getx() + "," + A2.gety() + ")" + "");

            if ( A1.isymetric(A2)==true)
                Console.WriteLine("yes it's symetric");
           else Console.WriteLine("no it's not symetric");
           Console.WriteLine("creation du segment CD qui est le resultat de la translation de A1,A2");
            Segment CD = new Segment(A1,A2);
            CD.affiche();
        }
    }
} 
