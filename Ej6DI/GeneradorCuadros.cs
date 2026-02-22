using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej6DI
{
    public partial class GeneradorCuadros : UserControl
    {
        List<Figure> figures = new List<Figure>();
        public GeneradorCuadros()
        {
            InitializeComponent();
            weight = 1f;
            tint = Color.Black;
            pictureBox1.BackColor = Color.LightGray;
        }
        private float weight=1f;
        [Category("IDK")]
        [Description("Brush size")]
        public float Weight
        {
            set
            {
                if (value <= 0)
                {
                    value = 1f;
                }
                weight = value;
            }
            get
            {
                return weight;
            }
        }
        private Color tint;
        [Category("IDK")]
        [Description("Color to paint or to put as a background")]
        public Color Tint
        {
            set
            {
                tint = value;
            }
            get
            {
                return tint;
            }
        }
        private bool fill;
        [Category("IDK")]
        [Description("Fill or don't fill the next figure to draw")]
        [DefaultValue(false)]
        public bool Fill
        {
            set
            {
                fill = value;
            }
            get
            {
                return fill;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            weight++;
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (weight > 1)
            {
                weight--;
            }
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = tint;
            Refresh();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                figures.RemoveAt(figures.Count - 1);
            }
            Refresh();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            tint = ((RadioButton)sender).BackColor;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Line l = new Line();
            l.Position = new Point(r.Next(0, pictureBox1.Width), r.Next(0, pictureBox1.Height));
            l.Size = new Size(r.Next(0, pictureBox1.Width), r.Next(0, pictureBox1.Height));
            l.Color = Tint;
            l.Weight = Weight;
            l.Fill = Fill;

            AddFigure(l);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Circle c = new Circle();
            c.Position = new Point(r.Next(0, pictureBox1.Width), r.Next(0, pictureBox1.Height));
            int radius = r.Next(20, 100);
            c.Size = new Size(radius, radius);
            c.Color = Tint;
            c.Weight = Weight;
            c.Fill = Fill;

            AddFigure(c);
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Triangle t = new Triangle();
            t.Position = new Point(r.Next(0, pictureBox1.Width), r.Next(0, pictureBox1.Height));
            t.p2 = new Point(r.Next(0, pictureBox1.Width), r.Next(0, pictureBox1.Height));
            t.p3 = new Point(r.Next(0, pictureBox1.Width), r.Next(0, pictureBox1.Height));
            t.Color = Tint;
            t.Weight = Weight;
            t.Fill = Fill;
            AddFigure(t);
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Rectangle r = new Rectangle();
            r.Position = new Point(rand.Next(0, pictureBox1.Width), rand.Next(0, pictureBox1.Height));
            r.Size = new Size(rand.Next(10, 120), rand.Next(10, 120));
            r.Color = Tint;
            r.Weight = Weight;
            r.Fill = Fill;
            AddFigure(r);
        }

        private void AddFigure(Figure f)
        {
            figures.Add(f);
            Refresh();
        }

        private void rbFill_CheckedChanged(object sender, EventArgs e)
        {
            fill = ((RadioButton)sender).Checked;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Figure f in figures)
            {
                f.Dibujar(g);
            }
        }
    }
}
