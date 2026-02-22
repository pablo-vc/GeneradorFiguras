using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6DI
{
    internal class Line : Figure
    {

        public override void Dibujar(Graphics g)
        {
            using (Pen p = new Pen(Color, Weight))
            {
                g.DrawLine(p, Position, new Point(Size.Width,Size.Height));
            }
        }
    }
}
