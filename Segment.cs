using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_TP2 { 

 class Segment
{
    Point ex1, ex2;
    
    public Segment() { }

    public Segment (Point ex1,Point ex2)
    {
        this.ex1 = ex1;
        this.ex2 = ex2;
    }
    // copy constructeur 
    public Segment(Segment s1)
    {
        this.ex1 = s1.ex1;
        this.ex2 = s1.ex2;
    }
    public Point getex1() { return this.ex1; }
    public Point getex2() { return this.ex2; }
    public void setex1(Point x) { this.ex1 = x; }
    public void setex2(Point x) { this.ex2 = x; }

    public void affiche()
    {
        Console.WriteLine("Le segment :");
        Console.WriteLine("Le Extrmite1 :("+ex1.getx()+","+ex1.gety()+")");
        Console.WriteLine("Le Extrmite2 :(" + ex2.getx() + "," + ex2.gety() + ")");

    }
    public bool isymetric(Segment s1)
    { bool res = false;
        if ((this.ex1.isymetric(s1.ex1) && this.ex2.isymetric(s1.ex2)))
            res = true;
        return res; 
    }
    public bool Equalss(Segment s1)
    {
        bool res = false;
        if ((this.ex1.Equals(s1.ex1) && this.ex2.Equals(s1.ex2)) || (this.ex1.Equals(s1.ex2) && this.ex2.Equals(s1.ex1)))

            res = true;
        return res;
    }

}

}
