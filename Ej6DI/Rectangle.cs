using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6DI
{
    internal class Rectangle : Figure
    {
        public override void Dibujar(Graphics g)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Position, Size);
            using (Pen p = new Pen(Color, Weight))
            using (Brush b = new SolidBrush(Color))
            {
                if (Fill)
                    g.FillRectangle(b, rect);
                else
                    g.DrawRectangle(p, rect);
            }
        }
    }
}
