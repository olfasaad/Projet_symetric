using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_TP2
{
     class Point
    {
        private int x, y;

        public Point() { }
        public Point (int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        //consturcteur de recopie:permet de créer une copie d'un objet.
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;

        }



         public int getx() { return this.x; }
         public int gety() { return this.y; }
         public void sety(int i)
        {
            this.y = i;
        }
        public void setx(int i)
        {
            this.x = i;
        }
         //test d'egalite
         public bool Equals( Point p) {
            bool res = false;
            if (this.x == p.x && this.y == p.y)
                res = true;
            return res;
   }
        public void translation( int dx,int dy)
        {
            this.x += dx;
            this.y += dy;
        }
        //symetric ou non 
        public bool isymetric( Point p )
        {
            bool res = false;
            if (this.x == p.x && this.y == p.y)
                res = true;
            return res;
        }
    }
}
