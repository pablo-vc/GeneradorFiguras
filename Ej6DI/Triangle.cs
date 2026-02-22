using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6DI
{
    internal class Triangle : Figure
    {
        public Point p2 { set; get; }
        public Point p3 { set; get; }
        public override void Dibujar(Graphics g)
        {
            

            Point[] puntos = { Position, p2, p3 };

            using (Pen p = new Pen(Color, Weight))
            using (Brush b = new SolidBrush(Color))
            {
                if (Fill)
                    g.FillPolygon(b, puntos);
                else
                    g.DrawPolygon(p, puntos);
            }
        }
    }
}
