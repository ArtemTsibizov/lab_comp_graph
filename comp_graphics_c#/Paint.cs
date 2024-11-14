using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp_graphics_c_
{
    public partial class Paint : Form
    {
        private int radius = 10;
        Graphics GFX;
        Bitmap surface;
        private bool bucketMode = false;
        private bool bucketPatternMode = false;
        private Color bucketColor;
        private bool circleMode = false;
        private bool lineMode = false;
        private int linePoint_x0;
        private int linePoint_y0;
        private int linePoint_x1;
        private int linePoint_y1;
        private int linePoint = 1;

        private bool bezierCurveMode = false;
        private int P0_x;
        private int P0_y;
        private int P1_x;
        private int P1_y;
        private int P2_x;
        private int P2_y;
        private int P3_x;
        private int P3_y;
        private int bezierPoint = 1;
        private bool geom;

        private List<int[]> dynamicBezierPoints = new List<int[]>();
        private bool dynamicBezierMode = false;


        public Paint()
        {
            InitializeComponent();

            surface = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

            pictureBox1.Image = surface;

            GFX = Graphics.FromImage(surface);
            GFX.Clear(Color.Green);

            this.textBoxColorR.Text = "255";
            this.textBoxColorG.Text = "255";
            this.textBoxColorB.Text = "255";
            this.textBoxParameterT.Text = "0,5";


        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (bucketMode == true)
            {
                Form1.ModifiedFloodFill(surface, e.X, e.Y, surface.GetPixel(e.X, e.Y), bucketColor);
                pictureBox1.Refresh();
            }
            else if (bucketPatternMode == true)
            {
                Form1.FloodFill(surface, e.X, e.Y, surface.GetPixel(e.X, e.Y), bucketColor);
                pictureBox1.Refresh();
            }
            else if (circleMode == true)
            {
                if (e.X + radius > surface.Width || e.X - radius < 0 ||
                    e.Y + radius > surface.Height || e.Y - radius < 0)
                {
                    MessageBox.Show("Выход за пределы");
                }
                else
                {
                    Form1.bresenham_circle(surface, e.X, e.Y, radius);

                    pictureBox1.Refresh();
                }
            }
            else if (lineMode == true)
            {
                if (linePoint == 1)
                {
                    linePoint_x0 = e.X;
                    linePoint_y0 = e.Y;
                    this.label2.Text = "x: " + e.X + " y: " + e.Y;
                    linePoint = 2;
                }
                else if (linePoint == 2)
                {
                    linePoint_x1 = e.X;
                    linePoint_y1 = e.Y;
                    this.label2.Text = "x: " + e.X + " y: " + e.Y;

                    Color c = Color.FromArgb(
                    int.Parse(this.textBoxColorR.Text),
                    int.Parse(this.textBoxColorG.Text),
                    int.Parse(this.textBoxColorB.Text));


                    Form1.BresenhamLine(surface,
                        linePoint_x0, linePoint_y0, linePoint_x1, linePoint_y1,
                        c);
                    this.buttonDrawLine.BackColor = c;


                    this.buttonDrawLine.Text = "Сбросить";
                    linePoint = 1;
                    pictureBox1.Refresh();

                }
                else
                {
                    MessageBox.Show("Прямая нарисована");
                }
            }
            else if (bezierCurveMode == true)
            {
                if (bezierPoint == 1)
                {
                    P0_x = e.X;
                    P0_y = e.Y;
                    this.label2.Text = "x: " + e.X + " y: " + e.Y;
                    bezierPoint = 2;

                    surface.SetPixel(P0_x + 1, P0_y, Color.Gold);
                    surface.SetPixel(P0_x, P0_y + 1, Color.Gold);
                    surface.SetPixel(P0_x - 1, P0_y, Color.Gold);
                    surface.SetPixel(P0_x, P0_y - 1, Color.Gold);
                    pictureBox1.Refresh();


                }
                else if (bezierPoint == 2)
                {
                    P1_x = e.X;
                    P1_y = e.Y;
                    this.label2.Text = "x: " + e.X + " y: " + e.Y;
                    bezierPoint = 3;
                    surface.SetPixel(P1_x + 1, P1_y, Color.Gold);
                    surface.SetPixel(P1_x, P1_y + 1, Color.Gold);
                    surface.SetPixel(P1_x - 1, P1_y, Color.Gold);
                    surface.SetPixel(P1_x, P1_y - 1, Color.Gold);
                    pictureBox1.Refresh();

                }
                else if (bezierPoint == 3)
                {
                    P2_x = e.X;
                    P2_y = e.Y;
                    this.label2.Text = "x: " + e.X + " y: " + e.Y;
                    bezierPoint = 4;
                    surface.SetPixel(P2_x + 1, P2_y, Color.Gold);
                    surface.SetPixel(P2_x, P2_y + 1, Color.Gold);
                    surface.SetPixel(P2_x - 1, P2_y, Color.Gold);
                    surface.SetPixel(P2_x, P2_y - 1, Color.Gold);
                    pictureBox1.Refresh();
                }
                else if (bezierPoint == 4)
                {
                    P3_x = e.X;
                    P3_y = e.Y;
                    this.label2.Text = "x: " + e.X + " y: " + e.Y;
                    bezierPoint = 1;
                    surface.SetPixel(P3_x + 1, P3_y, Color.Gold);
                    surface.SetPixel(P3_x, P3_y + 1, Color.Gold);
                    surface.SetPixel(P3_x - 1, P3_y, Color.Gold);
                    surface.SetPixel(P3_x, P3_y - 1, Color.Gold);

                    float t = float.Parse(this.textBoxParameterT.Text);

                    if (geom == true)
                    {
                        Form1.geomBezier(surface, t, P0_x, P0_y, P1_x, P1_y, P2_x, P2_y, P3_x, P3_y);
                    }
                    else
                        Form1.Bezier(surface, t, P0_x, P0_y, P1_x, P1_y, P2_x, P2_y, P3_x, P3_y);


                    pictureBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("Кривая нарисована");
                }
            }
            else if (dynamicBezierMode == true)
            {
                dynamicBezierPoints.Add(new int[] { e.X, e.Y });
                surface.SetPixel(e.X + 1, e.Y, Color.Gold);
                surface.SetPixel(e.X, e.Y + 1, Color.Gold);
                surface.SetPixel(e.X - 1, e.Y, Color.Gold);
                surface.SetPixel(e.X, e.Y - 1, Color.Gold);
                pictureBox1.Refresh();
            }

        }

        private void buttonFloodFill_Click(object sender, EventArgs e)
        {
            bucketMode = bucketMode == true ? false : true;
            if (bucketMode == true)
            {
                Color c = Color.FromArgb(
                    int.Parse(this.textBoxColorR.Text),
                    int.Parse(this.textBoxColorG.Text),
                    int.Parse(this.textBoxColorB.Text));
                this.buttonFloodFill.BackColor = c;
                bucketColor = c;
                this.label2.Text = "Заливка";
                this.buttonFloodFill.Text = "Сбросить";

            }
            else
            {
                this.buttonFloodFill.BackColor = Color.LightGray;
                this.label2.Text = "Выберете режим";
                this.buttonFloodFill.Text = "Заливка";
            }


        }
        private void buttonFloodFillPattern_Click(object sender, EventArgs e)
        {
            bucketPatternMode = bucketPatternMode == true ? false : true;
            if (bucketPatternMode == true)
            {
                Color c = Color.FromArgb(
                    int.Parse(this.textBoxColorR.Text),
                    int.Parse(this.textBoxColorG.Text),
                    int.Parse(this.textBoxColorB.Text));
                this.buttonFloodFillPattern.BackColor = c;
                bucketColor = c;
                this.label2.Text = "Узор";
                this.buttonFloodFillPattern.Text = "Сбросить";

            }
            else
            {
                this.buttonFloodFillPattern.BackColor = Color.LightGray;
                this.label2.Text = "Выберете режим";
                this.buttonFloodFillPattern.Text = "Узор";
            }
        }
        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            if (lineMode == false)
            {

                lineMode = true;
                this.label2.Text = "Прямая";
                this.buttonDrawLine.Text = "Сбросить";
                Color c = Color.FromArgb(
                    int.Parse(this.textBoxColorR.Text),
                    int.Parse(this.textBoxColorG.Text),
                    int.Parse(this.textBoxColorB.Text));
                this.buttonDrawLine.BackColor = c;
            }
            else
            {
                lineMode = false;

                linePoint = 1;
                this.label2.Text = "Выберете режим";
                this.buttonDrawLine.Text = "Прямая";
                this.buttonDrawLine.BackColor = Color.LightGray;
            }

        }

        private void buttonBezierCurve_Click(object sender, EventArgs e)
        {
            if (bezierCurveMode == false)
            {

                bezierCurveMode = true;
                this.label2.Text = "Кривая Безье";
                this.buttonBezierCurve.Text = "Сбросить";
                Color c = Color.FromArgb(
                    int.Parse(this.textBoxColorR.Text),
                    int.Parse(this.textBoxColorG.Text),
                    int.Parse(this.textBoxColorB.Text));
                this.buttonBezierCurve.BackColor = c;
            }
            else
            {
                bezierCurveMode = false;

                bezierPoint = 1;
                this.label2.Text = "Выберете режим";
                this.buttonBezierCurve.Text = "Кривая Безье";
                this.buttonBezierCurve.BackColor = Color.LightGray;
            }
        }

        private void buttonBezierCurveGeom_Click(object sender, EventArgs e)
        {
            if (bezierCurveMode == false)
            {
                bezierCurveMode = true;
                geom = true;
                this.label2.Text = "Кривая Безье(Геом)";
                this.buttonBezierCurveGeom.Text = "Сбросить";
                Color c = Color.FromArgb(
                    int.Parse(this.textBoxColorR.Text),
                    int.Parse(this.textBoxColorG.Text),
                    int.Parse(this.textBoxColorB.Text));
                this.buttonBezierCurveGeom.BackColor = c;
            }
            else
            {
                bezierCurveMode = false;
                geom = false;

                bezierPoint = 1;
                this.label2.Text = "Выберете режим";
                this.buttonBezierCurveGeom.Text = "Кривая Безье(Геом)";
                this.buttonBezierCurveGeom.BackColor = Color.LightGray;
            }
        }

        private void buttonWipe_Click(object sender, EventArgs e)
        {
            surface = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

            pictureBox1.Image = surface;
            GFX = Graphics.FromImage(surface);
            GFX.Clear(Color.Green);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            if (circleMode == false)
            {
                circleMode = true;
                this.radius = int.Parse(this.textBoxRadius.Text);

                this.label2.Text = "Окружность";
                this.buttonCircle.Text = "Сбросить";

            }
            else
            {
                circleMode = false;
                this.label2.Text = "Выберете режим";
                this.buttonCircle.Text = "Окружность";
                this.buttonCircle.BackColor = Color.LightGray;
            }
        }

        private void buttonDynamicBezierCurve_Click(object sender, EventArgs e)
        {
            if(dynamicBezierMode == false)
            {
                dynamicBezierMode = true;
                this.label2.Text = "Кривая Безье(n т.)";
                this.buttonDynamicBezierCurve.Text = "Сбросить";
                Color c = Color.FromArgb(
                    int.Parse(this.textBoxColorR.Text),
                    int.Parse(this.textBoxColorG.Text),
                    int.Parse(this.textBoxColorB.Text));
                this.buttonDynamicBezierCurve.BackColor = c;

            }
            else
            {
                dynamicBezierMode = false;
                this.label2.Text = "Выберете режим";
                this.buttonDynamicBezierCurve.Text = "Кривая Безье(n т.)";
                this.buttonDynamicBezierCurve.BackColor = Color.LightGray;
                float t = float.Parse(this.textBoxParameterT.Text);


                Color c = Color.FromArgb(
                    int.Parse(this.textBoxColorR.Text),
                    int.Parse(this.textBoxColorG.Text),
                    int.Parse(this.textBoxColorB.Text));
                if(dynamicBezierPoints.Count >= 2)
                {
                    Form1.Bezier(surface, t, dynamicBezierPoints, c);
                }
                pictureBox1.Refresh();
                dynamicBezierPoints.Clear();

            }
            

        }
    }
}
