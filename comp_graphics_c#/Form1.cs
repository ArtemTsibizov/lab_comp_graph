using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace comp_graphics_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            Bitmap surface = new Bitmap(1000, 433);

            pictureBox1.Image = surface;

            Graphics GFX = Graphics.FromImage(surface);
            GFX.Clear(Color.Green);

        }
        public static void BresenhamLine(Bitmap surface, int x0, int y0, int x1, int y1, Color color)
        {

            
            double dx = Math.Abs(x1 - x0);
            double dy = Math.Abs(y1 - y0);
            
            bool slope = dy > dx;
            

            int swap;
            if (slope){
                swap = x0;
                x0 = y0; 
                y0 = swap;

                swap = x1;
                x1 = y1;
                y1 = swap;
                
            }


            if (x0 > x1)
            {
                swap = x0;
                x0 = x1;
                x1 = swap;

                swap = y0;
                y0 = y1;
                y1 = swap;
               

            }

            dx = Math.Abs(x1 - x0);
            dy = Math.Abs(y1 - y0);
            double error = dx; // 2

            

            int y = y0;
            int ystep;
            if (y0 < y1)
            {
                ystep = 1;
            }
            else ystep = -1;

           

            for( int x = x0; x < x1 + 1; x++){
                if (slope)
                {
                    surface.SetPixel(y, x, color);
                   
                }
                else
                {
                    surface.SetPixel(x, y, color);
                   
                }
                error -= dy;
                //Debug.WriteLine(error);
                if (error < 0)
                {
                    y += ystep; 
                    error += dx;
                }

            }

            /*double dy = y1 - y0;
            double dx = x1 - x0;
            Debug.WriteLine(dx + "dx dy " + dy);
            if(dy > dx)
            {
                dx = y1 - y0;
                dy = x1 - x0;
            }
            double d = 2 * dy - dx;
            int x = x0;
            int y = y0;

            while (x <= x1)
            {
                Debug.WriteLine(x + " " + y);
                surface.SetPixel(x, y, Color.Black);
                x += 1;

                if (d < 0)
                {

                    d += 2 * dy;
                }
                else
                {
                    d += 2 * (dy - dx);
                    y += 1;
                }
            }*/
        }
        public static void geomBezier(Bitmap surface, float parameter_t, int P0_x, int P0_y, int P1_x, int P1_y, int P2_x, int P2_y, int P3_x, int P3_y)
        {
            BresenhamLine(surface, P0_x, P0_y, P1_x, P1_y, Color.Black);
            BresenhamLine(surface, P1_x, P1_y, P2_x, P2_y, Color.Black);
            BresenhamLine(surface, P2_x, P2_y, P3_x, P3_y, Color.Black);
            float i, t;
            float x, y;


            for (t = 0; t < 1; t += parameter_t)
            {
                // первый шаг(2 линии)
                int x0 = P0_x + (int)((P1_x - P0_x) * t);
                int y0 = P0_y + (int)((P1_y - P0_y) * t);
                surface.SetPixel(P0_x + (int)((P1_x - P0_x) * t),
                    P0_y + (int)((P1_y - P0_y) * t), Color.Red);

                int x1 = P1_x + (int)((P2_x - P1_x) * t);
                int y1 = P1_y + (int)((P2_y - P1_y) * t);
                surface.SetPixel(P1_x + (int)((P2_x - P1_x) * t),
                    P1_y + (int)((P2_y - P1_y) * t), Color.Red);

                BresenhamLine(surface, x0, y0, x1, y1, Color.Red);

                int x2 = P2_x + (int)((P3_x - P2_x) * t);
                int y2 = P2_y + (int)((P3_y - P2_y) * t);
                surface.SetPixel(P2_x + (int)((P3_x - P2_x) * t),
                    P2_y + (int)((P3_y - P2_y) * t), Color.Red);
                BresenhamLine(surface, x1, y1, x2, y2, Color.Red);


                // второй шаг (1 линия)
                x0 = x0 + (int)((x1 - x0) * t);
                y0 = y0 + (int)((y1 - y0) * t);
                surface.SetPixel(x0 + (int)((x1 - x0) * t),
                    y0 + (int)((y1 - y0) * t), Color.Blue);

                x1 = x1 + (int)((x2 - x1) * t);
                y1 = y1 + (int)((y2 - y1) * t);
                surface.SetPixel(x1 + (int)((x2 - x1) * t),
                    y1 + (int)((y2 - y1) * t), Color.Blue);

                BresenhamLine(surface, x0, y0, x1, y1, Color.Yellow);

                // третий шаг ( 1 точка )
                x0 = x0 + (int)((x1 - x0) * t);
                y0 = y0 + (int)((y1 - y0) * t);
                surface.SetPixel(x0 + 1, y0, Color.Blue);
                surface.SetPixel(x0, y0 + 1, Color.Blue);
                surface.SetPixel(x0 - 1, y0, Color.Blue);
                surface.SetPixel(x0, y0 - 1, Color.Blue);
                surface.SetPixel(x0 + 1, y0 + 1, Color.Blue);
                surface.SetPixel(x0 - 1, y0 - 1, Color.Blue);
                surface.SetPixel(x0 - 1, y0 + 1, Color.Blue);
                surface.SetPixel(x0 + 1, y0 - 1, Color.Blue);
                surface.SetPixel(x0, y0, Color.Blue);
            }
            /*for (t = 0; t < 1; t += 0.003F)
            {
                // первый шаг(2 линии)
                int x0 = P0_x + (int)((P1_x - P0_x) * t);
                int y0 = P0_y + (int)((P1_y - P0_y) * t);

                int x1 = P1_x + (int)((P2_x - P1_x) * t);
                int y1 = P1_y + (int)((P2_y - P1_y) * t);



                int x2 = P2_x + (int)((P3_x - P2_x) * t);
                int y2 = P2_y + (int)((P3_y - P2_y) * t);



                // второй шаг (1 линия)
                x0 = x0 + (int)((x1 - x0) * t);
                y0 = y0 + (int)((y1 - y0) * t);


                x1 = x1 + (int)((x2 - x1) * t);
                y1 = y1 + (int)((y2 - y1) * t);




                // третий шаг ( 1 точка )
                x0 = x0 + (int)((x1 - x0) * t);
                y0 = y0 + (int)((y1 - y0) * t);
                surface.SetPixel(x0 + 1, y0, Color.Blue);
                surface.SetPixel(x0, y0 + 1, Color.Blue);
                surface.SetPixel(x0 - 1, y0, Color.Blue);
                surface.SetPixel(x0, y0 - 1, Color.Blue);
                surface.SetPixel(x0 + 1, y0 + 1, Color.Blue);
                surface.SetPixel(x0 - 1, y0 - 1, Color.Blue);
                surface.SetPixel(x0 - 1, y0 + 1, Color.Blue);
                surface.SetPixel(x0 + 1, y0 - 1, Color.Blue);
                surface.SetPixel(x0, y0, Color.Blue);
            }*/

        }
        public static void Bezier(Bitmap surface, float parameter_t, int P0_x, int P0_y, int P1_x, int P1_y, int P2_x, int P2_y, int P3_x, int P3_y)
        {
            float i, t;
            float x, y;


            BresenhamLine(surface, P0_x, P0_y, P1_x, P1_y, Color.Black);
            BresenhamLine(surface, P1_x, P1_y, P2_x, P2_y, Color.Black);
            BresenhamLine(surface, P2_x, P2_y, P3_x, P3_y, Color.Black);


            float xPrev = P0_x, yPrev = P0_y; 

            for(t = 0; t < 1; t = t + parameter_t)
            {
                
                x = (float)(
                    P0_x * Math.Pow(1 - t, 3)     +
                    3 * P1_x * t *Math.Pow(1-t,2)        +
                    3 * P2_x * Math.Pow(t,2) * (1 - t)   +
                    P3_x * Math.Pow(t, 3));
                y = (float)(
                    P0_y * Math.Pow(1 - t, 3) +
                    3 * P1_y * t * Math.Pow(1 - t, 2) +
                    3 * P2_y * Math.Pow(t, 2) * (1 - t) +
                    P3_y * Math.Pow(t, 3));

                BresenhamLine(surface, (int)xPrev, (int)yPrev, (int)x, (int)y, Color.Pink);
                xPrev = x;
                yPrev = y;

            }
            BresenhamLine(surface, (int)xPrev, (int)yPrev, (int)P3_x, (int)P3_y, Color.Pink);

        }
        // 20 точек
        public static void Bezier(Bitmap surface, float parameter_t, List<int[]> points, Color color)
        {

            // Соединение прямой выбранных точек
            int xPrev = points.ElementAt(0)[0];
            int yPrev = points.ElementAt(0)[1];

            for (int k = 0; k < points.Count; k++)
            {
                Debug.WriteLine(xPrev + " " + yPrev);
                Debug.WriteLine(points.ElementAt(k)[0] + " " + points.ElementAt(k)[1]);

                BresenhamLine(surface, xPrev, yPrev, points.ElementAt(k)[0], points.ElementAt(k)[1], Color.White);
                xPrev = points.ElementAt(k)[0];
                yPrev = points.ElementAt(k)[1];
            }

            BresenhamLine(surface, xPrev, yPrev, points.ElementAt(points.Count - 1)[0], points.ElementAt(points.Count - 1)[1], Color.White);



            float i, t;
            float x, y;



            List<int[]> curPoints;

            int xDrawPoints = points.ElementAt(0)[0];
            int yDrawPoints = points.ElementAt(0)[1];

            for(t = 0f; t < 1;t += parameter_t)
            {
                curPoints = points;

                for (int amountOfPoints = points.Count - 1; amountOfPoints >= 2; amountOfPoints--)
                {
                    Debug.WriteLine("AMOUNT OF POINTs = " + amountOfPoints);
                    List<int[]> newPoints = new List<int[]>();

                    xPrev = curPoints.ElementAt(0)[0] + (int)((curPoints.ElementAt(1)[0] - curPoints.ElementAt(0)[0]) * t);
                    yPrev = curPoints.ElementAt(0)[1] + (int)((curPoints.ElementAt(1)[1] - curPoints.ElementAt(0)[1]) * t); 
                    newPoints.Add(new int[] { xPrev, yPrev });
                    int xCur = 0;
                    int yCur = 0;

                    for (int k = 1; k <= amountOfPoints - 1; k++)
                    {
                        xCur = curPoints.ElementAt(k)[0] + (int)((curPoints.ElementAt(k + 1)[0] - curPoints.ElementAt(k)[0]) * t);
                        yCur = curPoints.ElementAt(k)[1] + (int)((curPoints.ElementAt(k + 1)[1] - curPoints.ElementAt(k)[1]) * t);

                        //BresenhamLine(surface, xPrev, yPrev, xCur, yCur, Color.Red);

                        xPrev = xCur;
                        yPrev = yCur;
                        newPoints.Add(new int[] { xCur, yCur });
                    }
                    
                    curPoints = newPoints;
                }

                // Осталось две точки => получаем последнюю точку
                xPrev = curPoints.ElementAt(0)[0] + (int)((curPoints.ElementAt(1)[0] - curPoints.ElementAt(0)[0]) * t);
                yPrev = curPoints.ElementAt(0)[1] + (int)((curPoints.ElementAt(1)[1] - curPoints.ElementAt(0)[1]) * t);

                BresenhamLine(surface, xDrawPoints, yDrawPoints, xPrev, yPrev, color);

                xDrawPoints = xPrev;
                yDrawPoints = yPrev;

            }
            BresenhamLine(surface, xDrawPoints, yDrawPoints, points.ElementAt(points.Count - 1)[0], points.ElementAt(points.Count - 1)[1], color);



        }
        //Алгоритм Брезенхама рисования окружности
        public static void bresenham_circle(Bitmap surface, int xc, int yc, int r)
        {
            int x = 0;
            int y = r;
            int d = 3 - 2 * r;


            while (y >= x)
            {

                surface.SetPixel(xc + x, yc + y, Color.Black);
                surface.SetPixel(xc + x, yc - y, Color.Black);
                surface.SetPixel(xc - x, yc + y, Color.Black);
                surface.SetPixel(xc - x, yc - y, Color.Black);

                surface.SetPixel(xc + y, yc + x, Color.Black);
                surface.SetPixel(xc + y, yc - x, Color.Black);
                surface.SetPixel(xc - y, yc + x, Color.Black);
                surface.SetPixel(xc - y, yc - x, Color.Black);


                if (d <= 0)
                {

                    d = d + 4 * x + 6;

                }
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y -= 1;
                }

                x += 1;


            }

        }
        // алгоритм с затравкой
        public static void FloodFill(Bitmap surface, int x, int y, Color startColor, Color newColor)
        {
            Stack<int[]> pointsIn = new Stack<int[]>();
            pointsIn.Push(new int[] { x, y });
            int[] point;

            Color[,] pattern = new Color[,] {
                {Color.White, Color.White,Color.Red,       Color.Red,  Color.Red,Color.Red,       Color.Red, Color.White,   Color.White   },
                {Color.White, Color.White,Color.White,  Color.White, Color.White,Color.White,  Color.White,Color.White,Color.White   },
                {Color.Red, Color.White,Color.Red,    Color.Red,   Color.Red,Color.Red,        Color.Red, Color.White, Color.Red   },
                                                                                               
                {Color.Red, Color.White,Color.Red,    Color.Blue,  Color.Blue,Color.Blue,   Color.Red, Color.White,Color.Red   },
                {Color.Red, Color.White,Color.Red,    Color.Blue,  Color.Blue,Color.Blue,   Color.Red, Color.White,Color.Red   },
                {Color.Red, Color.White,Color.Red,    Color.Blue,  Color.Blue,Color.Blue,   Color.Red, Color.White,Color.Red   },
                                                                                               
                {Color.Red, Color.White,Color.Red,    Color.Red,   Color.Red,Color.Red,        Color.Red, Color.White,  Color.Red   },
                {Color.White, Color.White,Color.White,  Color.White, Color.White,Color.White,  Color.White, Color.White,Color.White   },
                {Color.White, Color.White,Color.Red,      Color.Red,   Color.Red,Color.Red,        Color.Red, Color.White,    Color.White   },
            };
                 
            while (pointsIn.Count != 0)
            {
                point = pointsIn.Pop();

                if (point[0] < 0 || point[0] >= surface.Width ||
                    point[1] < 0 || point[1] >= surface.Height) continue;



                Color color = surface.GetPixel(point[0], point[1]);
                if (color.R != startColor.R ||
                     color.G != startColor.G ||
                     color.B != startColor.B)
                {
                    continue;
                }
                else if (color.R == newColor.R &&
                        color.G == newColor.G &&
                        color.B == newColor.B)
                {
                    continue;
                }
                else
                {
                    surface.SetPixel(point[0], point[1], pattern[point[0]%9,point[1]%9 ]);
                   

                    pointsIn.Push(new int[] { point[0] - 1, point[1] });
                    pointsIn.Push(new int[] { point[0] + 1, point[1] });
                    pointsIn.Push(new int[] { point[0], point[1] - 1 });
                    pointsIn.Push(new int[] { point[0], point[1] + 1 });
                }
            }
        }
        //Модифицированный алгоритм с затравкой
        public static void ModifiedFloodFill(Bitmap surface, int x, int y, Color prevColor, Color newColor)
        {
            Stack<int[]> pointsIn = new Stack<int[]>();
            pointsIn.Push(new int[] { x, y });
            int[] point;

            while (pointsIn.Count != 0)
            {
                point = pointsIn.Pop();

                //Debug.WriteLine(point[0] + " " + point[1] + " " + +surface.Width + " " + surface.Height);

                if (point[0] < 0 || point[0] >= surface.Width ||
                    point[1] < 0 || point[1] >= surface.Height) continue;

                Color color = surface.GetPixel(point[0], point[1]);
                if (color.R != prevColor.R ||
                     color.G != prevColor.G ||
                     color.B != prevColor.B)
                {
                    continue;
                }else if (color.R == newColor.R &&
                        color.G == newColor.G &&
                        color.B == newColor.B)
                {
                    continue;
                }

                int xleft = point[0];


                while ( color.R == prevColor.R &&
                        color.G == prevColor.G &&
                        color.B == prevColor.B)
                {
                    surface.SetPixel(xleft, point[1], newColor);
                    xleft--;
                    if (xleft < 0 ) { break; }
                    color = surface.GetPixel(xleft, point[1]);
                }
                xleft++;
               

               
                
                int xright = point[0] + 1;
                if (xright >= surface.Width)
                {
                    xright = point[0];
                }
                color = surface.GetPixel(xright, point[1]);
                while ( color.R == prevColor.R &&
                        color.G == prevColor.G &&
                        color.B == prevColor.B)
                {
                    surface.SetPixel(xright, point[1], newColor);
                    xright++;
                    if (xright >= surface.Width) { break; }
                    color = surface.GetPixel(xright, point[1]);
                }
                xright--;


                int xright_ = xright;
                bool flag = true;
                while (xright_ >= xleft)
                {
                    if (point[1] + 1 >= surface.Height) break;
                    //if (xright < 0 || xright >= surface.Width) { break; }
                    color = surface.GetPixel(xright_, point[1] + 1);

                    if(flag == true)
                    {
                        if (color.R == prevColor.R &&
                            color.G == prevColor.G &&
                            color.B == prevColor.B)
                        {
                            pointsIn.Push(new int[] { xright_, point[1] + 1 });
                            flag = false;
                     
                        }
                    }
                    else
                    {
                        if (color.R != prevColor.R ||
                            color.G != prevColor.G ||
                            color.B != prevColor.B)
                        {
                            flag = true;
                        }
                    }
                    xright_--;
                }

                xright_ = xright;
                flag = true;
                while (xright_ >= xleft)
                {
                    if (point[1] - 1 <= 0) break;
                    //if (xright < 0 || xright >= surface.Width) { break; }
                    color = surface.GetPixel(xright_, point[1] - 1);

                    if (flag == true)
                    {
                        if (color.R == prevColor.R &&
                            color.G == prevColor.G &&
                            color.B == prevColor.B)
                        {
                            pointsIn.Push(new int[] { xright_, point[1] - 1 });
                            flag = false;
                            
                        }
                    }
                    else
                    {
                        if (color.R != prevColor.R ||
                            color.G != prevColor.G ||
                            color.B != prevColor.B)
                        {
                            flag = true;
                        }
                    }
                    xright_--;
                }


            }
            
        }

    }
}