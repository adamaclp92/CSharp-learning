using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Spirál
{
    public partial class Form1 : Form
    {
        private PointF kezdo;
        public Form1()
        {
            InitializeComponent();
            this.kezdo = new PointF(
                this.canvas.Width / 2 + 200,
                this.canvas.Height / 2-50
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

          /*  g.DrawLine(Pens.BlueViolet, 50, 50, 100, 100);
            g.DrawRectangle(Pens.Blue, 200, 200, 30, 30);
            g.FillRectangle(Brushes.Lavender, 200, 200, 30, 30);*/

           // this.Spiral(g, kezdo, 200, 90);
            this.PitagorasziFa(
                g, 
                this.kezdo, 
                new PointF(this.kezdo.X+45, this.kezdo.Y),
                10);
        }

        private void Spiral(Graphics g, PointF P, int l, float a)
        {
            if (l > 1)
            {
                float atmero = l * 0.1f;  //floatra konvertál
                float rad = a * (float)Math.PI / 180;
                PointF P1 = new PointF(
                    atmero * (float)Math.Cos(rad) + P.X,
                    atmero * (float)Math.Sin(rad) + P.Y
                    );

                g.FillEllipse(Brushes.Khaki, P1.X, P1.Y, atmero, atmero);
                g.DrawEllipse(Pens.BurlyWood, P1.X, P1.Y, atmero, atmero);

                this.Spiral(g, P1, l - 1, a + 5);
            }
        }

        private void PitagorasziFa(Graphics g, PointF Pa, PointF Pb, int r)
        {
            //Pc(Pb.x − Pa.y + Pb.y, Pb.y − Pb.x + Pa.x),  ́es Pd(Pa.x − Pa.y + Pb.y, Pa.y − Pb.x + Pa.x),
            PointF Pc = new PointF(
                Pb.X - Pa.Y + Pb.Y,
                Pb.Y - Pb.X + Pa.X
                );

            PointF Pd = new PointF(
                Pa.X - Pa.Y + Pb.Y,
                Pa.Y - Pb.X + Pa.X
                );

            g.DrawPolygon(Pens.Green, new PointF[] { Pa, Pb, Pc, Pd });

            if (r > 0)
            {
                PointF Pe = new PointF(
                    Pd.X + (Pb.X-Pa.X-Pa.Y+Pb.Y)/2,
                    Pd.Y - (Pb.X-Pa.X+Pa.Y-Pb.Y)/2
                    );

                this.PitagorasziFa(g, Pd, Pe, r - 1);
                this.PitagorasziFa(g, Pe, Pc, r - 1);
           
            }
        }
    }
}
