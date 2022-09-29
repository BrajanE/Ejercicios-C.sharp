using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_Entidades
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo( Punto vertice1,Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            int x2=vertice3.GetX();
            int y2=vertice1.GetY();
            int x4=vertice1.GetX();
            int y4=vertice3.GetY();

            vertice2 = new Punto(x2,y2);
            vertice4 = new Punto(x4,y4);
                
        }

        public float GetArea()
        {
            this.area = Math.Abs(vertice1.GetY() - vertice4.GetY()) * Math.Abs(vertice3.GetX()-vertice4.GetX());
            return area;
        }
        public float GetPerimetro()
        {
            this.perimetro = (Math.Abs(vertice3.GetX()-vertice4.GetX()) + Math.Abs(vertice1.GetY()-vertice4.GetY()))/(float)2;
            return perimetro;
        }
    }
}
