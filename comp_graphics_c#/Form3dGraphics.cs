using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp_graphics_c_
{
    public partial class Form3dGraphics : Form
    {
        int xc = 40;
        int yc = 10;
        bool flag = false;


        public Form3dGraphics()
        {
            InitializeComponent();



            Bitmap surface = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

            pictureBox1.Image = surface;


            int R = int.Parse(textBoxR.Text);
            int r = int.Parse(textBox_r.Text);
            R = 100;
            r = 30;


            int dx = int.Parse(numericUpDownShiftX.Value.ToString());
            int dy = int.Parse(numericUpDownShiftY.Value.ToString());
            int dz = int.Parse(numericUpDownShiftZ.Value.ToString());

            int x_rotate_angle = int.Parse(numericUpDownAngleX.Value.ToString());
            int y_rotate_angle = int.Parse(numericUpDownAngleY.Value.ToString());
            int z_rotate_angle = int.Parse(numericUpDownAngleZ.Value.ToString());

            double kX = 1;
            double kY = 1;
            double kZ = 1;

            for (double a = 0; a < 2 * Math.PI; a += Math.PI * .1)
            {
                double x_prev = (int)((R + r * Math.Cos(a)) * (Math.Sin((-1) * (Math.PI))));
                double y_prev = (int)((R + r * Math.Cos(a)) * (Math.Cos((-1) * (Math.PI))));
                double z_prev = (int)(r * Math.Sin(a));
                double[,] coordinates_prev = transformCoordinate(x_prev, y_prev, z_prev, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
                x_prev = coordinates_prev[0, 0];
                y_prev = coordinates_prev[1, 0];

                for (double b = (-1) * (Math.PI); b < Math.PI; b += Math.PI * .1)
                {
                    double x = (int)((R + r * Math.Cos(a)) * (Math.Sin(b)));
                    double y = (int)((R + r * Math.Cos(a)) * (Math.Cos(b)));
                    double z = (int)(r * Math.Sin(a));


                    double[,] coordinates = transformCoordinate(x, y, z, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);


                    x = coordinates[0, 0];
                    y = coordinates[1, 0];



                    Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x + 600, (int)y + 200, Color.Red);
                    x_prev = x;
                    y_prev = y;
                }

                double x_first = (int)((R + r * Math.Cos(a)) * (Math.Sin((-1) * (Math.PI))));
                double y_first = (int)((R + r * Math.Cos(a)) * (Math.Cos((-1) * (Math.PI))));
                double z_first = (int)(r * Math.Sin(a));
                double[,] coordinates_first = transformCoordinate(x_first, y_first, z_first, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
                x_first = coordinates_first[0, 0];
                y_first = coordinates_first[1, 0];


                Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x_first + 600, (int)y_first + 200, Color.Red);
            }

            for (double b = (-1) * (Math.PI); b < Math.PI; b += Math.PI * .1)
            {
                double x_prev = (int)((R + r * Math.Cos(0)) * (Math.Sin(b)));
                double y_prev = (int)((R + r * Math.Cos(0)) * (Math.Cos(b)));
                double z_prev = (int)(r * Math.Sin(0));

                double[,] coordinates_prev = transformCoordinate(x_prev, y_prev, z_prev, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
                x_prev = coordinates_prev[0, 0];
                y_prev = coordinates_prev[1, 0];

                for (double a = 0; a < 2 * Math.PI; a += Math.PI * .1)
                {
                    double x = (int)((R + r * Math.Cos(a)) * (Math.Sin(b)));
                    double y = (int)((R + r * Math.Cos(a)) * (Math.Cos(b)));
                    double z = (int)(r * Math.Sin(a));


                    double[,] coordinates = transformCoordinate(x, y, z, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);


                    x = coordinates[0, 0];
                    y = coordinates[1, 0];


                    Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x + 600, (int)y + 200, Color.Red);
                    x_prev = x;
                    y_prev = y;
                }

                double x_first = (int)((R + r * Math.Cos(0)) * (Math.Sin(b)));
                double y_first = (int)((R + r * Math.Cos(0)) * (Math.Cos(b)));
                double z_first = (int)(r * Math.Sin(0));

                double[,] coordinates_first = transformCoordinate(x_first, y_first, z_first, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
                x_first = coordinates_first[0, 0];
                y_first = coordinates_first[1, 0];

                Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x_first + 600, (int)y_first + 200, Color.Red);
            }
        }

        public double[,] transformCoordinate(double x, double y, double z, int dx, int dy, int dz,
            int x_rotate_angle, int y_rotate_angle, int z_rotate_angle, double kX, double kY, double kZ)
        {
            double x_radian = x_rotate_angle * Math.PI / 180.0;
            double y_radian = y_rotate_angle * Math.PI / 180.0;
            double z_radian = z_rotate_angle * Math.PI / 180.0;


            double[,] coordinates = new double[,] { { x }, { y }, { z }, { 1 } };

            double[,] transformationMatrix = new double[,] {
                        {1,0,0,0 },
                        {0,1,0,0 },
                        {0,0,1,0 },
                        {0,0,0,1 } };

            double[,] shiftMatrix = new double[,] {
                        {1,0,0,dx + 10 },
                        {0,1,0,dy + 10 },
                        {0,0,1,dz + 10},
                        {0,0,0,1  } };


            double cosa = Math.Cos(x_radian);
            double sina = Math.Sin(x_radian);
            double[,] rotateX = new double[,]
            {
                        { 1, 0   , 0        , 0  },
                        { 0, cosa, (-1)*sina, 0  },
                        { 0, sina, cosa     , 0  },
                        { 0,    0, 0        , 1  }
            };

            double cosb = Math.Cos(y_radian);
            double sinb = Math.Sin(y_radian);
            double[,] rotateY = new double[,]
            {
                        { cosb,      0, sinb  , 0 },
                        { 0   ,      1, 0     , 0 },
                        { (-1)*sinb, 0, cosb  , 0 },
                        { 0,         0, 0     , 1 }
            };
            double cosz = Math.Cos(z_radian);
            double sinz = Math.Sin(z_radian);
            double[,] rotateZ = new double[,]
            {
                        { cosz,  (-1)*sinz, 0  , 0 },
                        { sinz,  cosz,      0  , 0 },
                        { 0,     0,         1  , 0 },
                        { 0,     0,         0  , 1 }
            };

            double[,] scaleMatrix = new double[,]
            {
                {kX,0,0,0 },
                {0,kY,0,0 },
                {0,0,kZ,0 },
                {0,0,0,1 }
            };




            transformationMatrix = MultiplyMatrices(transformationMatrix, shiftMatrix);
            transformationMatrix = MultiplyMatrices(transformationMatrix, rotateX);
            transformationMatrix = MultiplyMatrices(transformationMatrix, rotateY);
            transformationMatrix = MultiplyMatrices(transformationMatrix, rotateZ);
            transformationMatrix = MultiplyMatrices(transformationMatrix, scaleMatrix);

            coordinates = MultiplyMatrices(transformationMatrix, coordinates);

            return coordinates;

        }
        public double[,] MultiplyMatrices(double[,] a, double[,] b)
        {

            double[,] newMatrix = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    newMatrix[i, j] = 0;
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        newMatrix[i, j] += a[i, k] * b[k, j];

                    }
                }
            }


            return newMatrix;
            /*int[,] scaleFactor = new int[,] { { 1, 0, 0 }, { 0, 1, k } };
            int[] arbitraryOffse = new int[] { 500, 250 };
            double[] res = new double[2];

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < m.Length; i++)
                {
                    res[j] += scaleFactor[j, i] * m[i];
                }
            }

            double x = m[0];
            double y = m[1];
            double z = m[2];

            //isometric
            res[0] = (x - z) * Math.Cos((Math.PI / 180) * 30);
            res[1] = y + (x + z) * Math.Sin((Math.PI / 180) * 30);

            //comp games
            res[0] = x - z;
            res[1] = y + (x + z) / 2;

            res[0] += arbitraryOffse[0];
            res[1] += arbitraryOffse[1];
            return res;*/
        }
        /*private void showAxis(int dx, int dy, int dz,
            int x_rotate_angle, int y_rotate_angle, int z_rotate_angle, Bitmap surface)
        {


            double[,] coordinate_start_x = new double[,] { { 0 }, { 0 }, { 0 }, { 1 } };
            double[,] coordinate_end_x = new double[,] { { 20 }, { 0 }, { 0 }, { 1 } };

            coordinate_start_x = transformCoordinate(0, 0, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
            coordinate_end_x = transformCoordinate(40, 0, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            Form1.BresenhamLine(surface, (int)coordinate_start_x[0, 0] + 300, (int)coordinate_start_x[1, 0] + 100, (int)coordinate_end_x[0, 0] + 300, (int)coordinate_end_x[1, 0] + 100, Color.Red);
            coordinate_start_x = transformCoordinate(0, 0, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            coordinate_end_x = transformCoordinate(40, 0, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            Form1.BresenhamLine(surface, (int)coordinate_start_x[0, 0] + 299, (int)coordinate_start_x[1, 0] + 99, (int)coordinate_end_x[0, 0] + 299, (int)coordinate_end_x[1, 0] + 99, Color.Red);



            double[,] coordinate_start_y = new double[,] { { 0 }, { 0 }, { 0 }, { 1 } };
            double[,] coordinate_end_y = new double[,] { { 0 }, { 20 }, { 0 }, { 1 } };
            coordinate_start_y = transformCoordinate(0, 0, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            coordinate_end_y = transformCoordinate(0, 40, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            Form1.BresenhamLine(surface, (int)coordinate_start_y[0, 0] + 300, (int)coordinate_start_y[1, 0] + 100, (int)coordinate_end_y[0, 0] + 300, (int)coordinate_end_y[1, 0] + 100, Color.Blue);
            coordinate_start_y = transformCoordinate(0, 0, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            coordinate_end_y = transformCoordinate(0, 40, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            Form1.BresenhamLine(surface, (int)coordinate_start_y[0, 0] + 299, (int)coordinate_start_y[1, 0] + 99, (int)coordinate_end_y[0, 0] + 299, (int)coordinate_end_y[1, 0] + 99, Color.Blue);



            double[,] coordinate_start_z = new double[,] { { 0 }, { 0 }, { 0 }, { 1 } };
            double[,] coordinate_end_z = new double[,] { { 0 }, { 0 }, { 20 }, { 1 } };
            coordinate_start_z = transformCoordinate(0, 0, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            coordinate_end_z = transformCoordinate(0, 0, 40, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            Form1.BresenhamLine(surface, (int)coordinate_start_z[0, 0] + 300, (int)coordinate_start_z[1, 0] + 100, (int)coordinate_end_z[0, 0] + 300, (int)coordinate_end_z[1, 0] + 100, Color.Green);
            coordinate_start_z = transformCoordinate(0, 0, 0, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            coordinate_end_z = transformCoordinate(0, 0, 40, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle);
            Form1.BresenhamLine(surface, (int)coordinate_start_z[0, 0] + 299, (int)coordinate_start_z[1, 0] + 99, (int)coordinate_end_z[0, 0] + 299, (int)coordinate_end_z[1, 0] + 99, Color.LightGreen);


        }*/
        private void process()
        {

            int x_rotate_angle = int.Parse(numericUpDownAngleX.Value.ToString());
            int y_rotate_angle = int.Parse(numericUpDownAngleY.Value.ToString());
            int z_rotate_angle = int.Parse(numericUpDownAngleZ.Value.ToString());
            int R = int.Parse(textBoxR.Text);
            int r = int.Parse(textBox_r.Text);

            double kX = double.Parse(textBoxScaleX.Text);
            double kY = double.Parse(textBoxScaleY.Text);
            double kZ = double.Parse(textBoxScaleZ.Text);



            Bitmap surface = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

            pictureBox1.Image = surface;


            int dx = int.Parse(numericUpDownShiftX.Value.ToString());
            int dy = int.Parse(numericUpDownShiftY.Value.ToString());
            int dz = int.Parse(numericUpDownShiftZ.Value.ToString());





            double x_radian = x_rotate_angle * Math.PI / 180.0;
            double y_radian = y_rotate_angle * Math.PI / 180.0;
            double z_radian = z_rotate_angle * Math.PI / 180.0;

            //showAxis(0, 0, 0, x_rotate_angle, y_rotate_angle, z_rotate_angle, surface);

            double step_a = double.Parse(textBoxStepA.Text);
            double step_b = double.Parse(textBoxStepB.Text);

            for (double a = 0; a < 2 * Math.PI; a += Math.PI * step_a)
            {
                double x_prev = (int)((R + r * Math.Cos(a)) * (Math.Sin((-1) * (Math.PI))));
                double y_prev = (int)((R + r * Math.Cos(a)) * (Math.Cos((-1) * (Math.PI))));
                double z_prev = (int)(r * Math.Sin(a));
                double[,] coordinates_prev = transformCoordinate(x_prev, y_prev, z_prev, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
                x_prev = coordinates_prev[0, 0];
                y_prev = coordinates_prev[1, 0];

                for (double b = (-1) * (Math.PI); b < Math.PI; b += Math.PI * step_b)
                {
                    double x = (int)((R + r * Math.Cos(a)) * (Math.Sin(b)));
                    double y = (int)((R + r * Math.Cos(a)) * (Math.Cos(b)));
                    double z = (int)(r * Math.Sin(a));



                    double[,] coordinates = transformCoordinate(x, y, z, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);


                    x = coordinates[0, 0];
                    y = coordinates[1, 0];



                    Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x + 600, (int)y + 200, Color.Red);
                    x_prev = x;
                    y_prev = y;
                }

                double x_first = (int)((R + r * Math.Cos(a)) * (Math.Sin((-1) * (Math.PI))));
                double y_first = (int)((R + r * Math.Cos(a)) * (Math.Cos((-1) * (Math.PI))));
                double z_first = (int)(r * Math.Sin(a));
                double[,] coordinates_first = transformCoordinate(x_first, y_first, z_first, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
                x_first = coordinates_first[0, 0];
                y_first = coordinates_first[1, 0];


                Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x_first + 600, (int)y_first + 200, Color.Red);
            }

            for (double b = (-1) * (Math.PI); b < Math.PI; b += Math.PI * step_b)
            {
                double x_prev = (int)((R + r * Math.Cos(0)) * (Math.Sin(b)));
                double y_prev = (int)((R + r * Math.Cos(0)) * (Math.Cos(b)));
                double z_prev = (int)(r * Math.Sin(0));

                double[,] coordinates_prev = transformCoordinate(x_prev, y_prev, z_prev, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
                x_prev = coordinates_prev[0, 0];
                y_prev = coordinates_prev[1, 0];

                for (double a = 0; a < 2 * Math.PI; a += Math.PI * step_a)
                {
                    double x = (int)((R + r * Math.Cos(a)) * (Math.Sin(b)));
                    double y = (int)((R + r * Math.Cos(a)) * (Math.Cos(b)));
                    double z = (int)(r * Math.Sin(a));


                    //double[] xy = MultiplyMatrix(new double[] { x, y, z }, 1);




                    double[,] coordinates = transformCoordinate(x, y, z, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);


                    x = coordinates[0, 0];
                    y = coordinates[1, 0];



                    //surface.SetPixel((int)(x) + 600, (int)(y) + 200, Color.Red);
                    Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x + 600, (int)y + 200, Color.Red);
                    x_prev = x;
                    y_prev = y;
                }

                double x_first = (int)((R + r * Math.Cos(0)) * (Math.Sin(b)));
                double y_first = (int)((R + r * Math.Cos(0)) * (Math.Cos(b)));
                double z_first = (int)(r * Math.Sin(0));

                double[,] coordinates_first = transformCoordinate(x_first, y_first, z_first, dx, dy, dz, x_rotate_angle, y_rotate_angle, z_rotate_angle, kX, kY, kZ);
                x_first = coordinates_first[0, 0];
                y_first = coordinates_first[1, 0];

                Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x_first + 600, (int)y_first + 200, Color.Red);
            }





            /* Bitmap surface = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

             pictureBox1.Image = surface;

             for (double x1 = 0; x1 < 20; x1 += 1)
             {
                 for (double y1 = 0; y1 < 20; y1 += 1)
                 {
                     for (double z1 = 0; z1 < 20; z1 += 1)
                     {
                         if ((z1 == 0 && y1 == 0) ||
                             (x1 == 0 && y1 == 0) ||
                             (x1 == 0 && z1 == 0))
                         {
                             double gamma;
                             //для x
                             gamma = (Math.PI / 180) * x_rotate;
                             double x = x1;
                             double y = (int)(y1 * Math.Cos(gamma) - z1 * Math.Sin(gamma));
                             double z = (int)(y1 * Math.Sin(gamma) + z1 * Math.Cos(gamma));

                             //для y
                             gamma = (Math.PI / 180) * y_rotate;
                             x = (int)(x * Math.Cos(gamma) + z * Math.Sin(gamma));
                             y = y;
                             z = (int)((-1 * x) * Math.Sin(gamma) + z * Math.Cos(gamma));

                             //для z
                             gamma = (Math.PI / 180) * z_rotate;
                             x = (int)(x * Math.Cos(gamma) - y * Math.Sin(gamma));
                             y = (int)(x * Math.Sin(gamma) + y * Math.Cos(gamma));
                             z = z;

                             //double[] xy = MultiplyMatrix(new double[] { x, y, z }, 1);

                             Color c;
                             if (z1 == 0 && y1 == 0) // x
                             {
                                 c = Color.Black;
                             }
                             else if (x1 == 0 && y1 == 0) c = Color.Red; // z
                             else c = Color.White;
                             //surface.SetPixel((int)(xy[0]) + 150, (int)(xy[1]), c);
                         }


                     }
                 }
             }




             double R = R_input;
             double r = r_input;



             for (double a = 0; a < 2 * Math.PI; a += Math.PI * .1)
             {
                 double x_prev = (int)((R + r * Math.Cos(a)) * (Math.Sin((-1) * (Math.PI))));
                 double y_prev = (int)((R + r * Math.Cos(a)) * (Math.Cos((-1) * (Math.PI))));
                 for (double b = (-1) * (Math.PI); b < Math.PI; b += Math.PI * .1)
                 {
                     double x = (int)((R + r * Math.Cos(a)) * (Math.Sin(b)));
                     double y = (int)((R + r * Math.Cos(a)) * (Math.Cos(b)));
                     double z = (int)(r * Math.Sin(a));


                     double[,] transformationMatrix = new double[,] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, {0,0,1,0 }, {0,0,0,1 } };

                     //double[] xy = MultiplyMatrix(new double[] { x, y, z }, 1);



                     //surface.SetPixel((int)(x) + 600, (int)(y) + 200, Color.Red);
                     Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x + 600, (int)y + 200, Color.Red);
                     x_prev = x;
                     y_prev = y;
                 }
                 double x_last = (int)((R + r * Math.Cos(a)) * (Math.Sin((-1) * (Math.PI))));
                 double y_last = (int)((R + r * Math.Cos(a)) * (Math.Cos((-1) * (Math.PI)))); ;

                 Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x_last + 600, (int)y_last + 200, Color.Red);
             }

             for (double b = (-1) * (Math.PI); b < Math.PI; b += Math.PI * .1)
             {
                 double x_prev = (int)((R + r * Math.Cos(0)) * (Math.Sin(b)));
                 double y_prev = (int)((R + r * Math.Cos(0)) * (Math.Cos(b)));
                 for (double a = 0; a < 2 * Math.PI; a += Math.PI * .1)
                 {
                     double x = (int)((R + r * Math.Cos(a)) * (Math.Sin(b)));
                     double y = (int)((R + r * Math.Cos(a)) * (Math.Cos(b)));
                     double z = (int)(r * Math.Sin(a));


                     //double[] xy = MultiplyMatrix(new double[] { x, y, z }, 1);



                     //surface.SetPixel((int)(x) + 600, (int)(y) + 200, Color.Red);
                     Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x + 600, (int)y + 200, Color.Red);
                     x_prev = x;
                     y_prev = y;
                 }
                 double x_last = (int)((R + r * Math.Cos(0)) * (Math.Sin(b)));
                 double y_last = (int)((R + r * Math.Cos(0)) * (Math.Cos(b)));

                 Form1.BresenhamLine(surface, (int)x_prev + 600, (int)y_prev + 200, (int)x_last + 600, (int)y_last + 200, Color.Red);
             }*/








            /*for (double a = 0; a < 2 * Math.PI; a += Math.PI * .01)
            {
                for (double b = (-1) * (Math.PI); b < Math.PI; b += Math.PI * .01)
                {
                    double x = (int)((R + r * Math.Cos(a)) * (Math.Sin(b)));
                    double y = (int)((R + r * Math.Cos(a)) * (Math.Cos(b)));
                    double z = (int)(r * Math.Sin(a)) + 10;

                    double gamma;

                    Color c;
                    if (z > 0 && x > 0 && y > 0)
                    {
                        c = Color.Aqua;
                    }
                    else if (z < 0 && x < 0 && y < 0)
                    {
                        c = Color.Yellow;
                    }
                    else if (z < 0 && x > 0 && y > 0)
                    {
                        c = Color.Pink;
                    }
                    else if (z < 0 && x > 0 && y < 0)
                    {
                        c = Color.Purple;
                    }
                    else if (z < 0 && x < 0 && y > 0)
                    {
                        c = Color.Brown;
                    }
                    else c = Color.Red;


                    //для x
                    gamma = (Math.PI / 180) * x_rotate;
                    x = x;
                    y = (int)(y * Math.Cos(gamma) - z * Math.Sin(gamma));
                    z = (int)(y * Math.Sin(gamma) + z * Math.Cos(gamma));

                    //для y
                    gamma = (Math.PI / 180) * y_rotate;
                    x = (x * Math.Cos(gamma) + z * Math.Sin(gamma));
                    y = y;
                    z = ((-1 * x) * Math.Sin(gamma) + z * Math.Cos(gamma));

                    //для z
                    gamma = (Math.PI / 180) * z_rotate;
                    x = (int)(x * Math.Cos(gamma) - y * Math.Sin(gamma));
                    y = (int)(x * Math.Sin(gamma) + y * Math.Cos(gamma));
                    z = z;



                    double[] xy = MultiplyMatrix(new double[] { x, y, z }, k);



                    surface.SetPixel((int)(xy[0]), (int)(xy[1]), c);
                }

            }*/
        }
        private void numericUpDownAngleX_ValueChanged(object sender, EventArgs e)
        {
            process();
        }
        private void numericUpDownAngleY_ValueChanged(object sender, EventArgs e)
        {
            process();
        }

        private void numericUpDownAngleZ_ValueChanged(object sender, EventArgs e)
        {
            process();
        }
        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            process();
        }

        private void numericUpDownZ_ValueChanged(object sender, EventArgs e)
        {
            process();
        }

        private void numericUpDownShiftX_ValueChanged(object sender, EventArgs e)
        {
            process();
        }

        private void numericUpDownShiftY_ValueChanged(object sender, EventArgs e)
        {
            process();
        }

        private void numericUpDownShiftZ_ValueChanged(object sender, EventArgs e)
        {
            process();
        }


        private void buttonScale_Click(object sender, EventArgs e)
        {
            process();
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            process();
        }
    }







}
