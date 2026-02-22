using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6DI
{
    abstract class Figure
    {
        public Point Position { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public float Weight { get; set; }
        public bool Fill { get; set; }

        public abstract void Dibujar(Graphics g);
    }
}
