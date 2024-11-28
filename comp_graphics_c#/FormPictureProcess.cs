using comp_graphics_c_.Properties;
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
    public partial class FormPictureProcess : Form
    {
        Graphics GFX;
        Bitmap surface;
        public FormPictureProcess()
        {
            InitializeComponent();



            // Оттенок серого
            surface = new Bitmap(pictureBoxInit.Image);
            for (int i = 0; i < surface.Width; i++)
            {
                for (int j = 0; j < surface.Height; j++)
                {
                    Color originalColor = surface.GetPixel(i, j);

                    int gray = (int)(0.3 * originalColor.R + 0.59 * originalColor.G + 0.11 * originalColor.B);

                    surface.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            pictureBoxBlackWhite.Image = surface;



            // Препарирование изображения (пилообразное контрастное масштабирование)
            //=

            double k = double.Parse(textBox1.Text);

            surface = new Bitmap(Resources.gradient);
            for (int i = 0; i < surface.Width; i++)
            {
                for (int j = 0; j < surface.Height; j++)
                {
                    Color originalColor = surface.GetPixel(i, j);



                    surface.SetPixel(i, j, Color.FromArgb(
                        (int)(k * originalColor.R % 255),
                        (int)(k * originalColor.G % 255),
                        (int)(k * originalColor.B % 255)
                        ));
                }
            }

            pictureBoxContrast.Image = surface;






            // Фильтр определения границ. Фильтр, основанный на второй производной функции Гаусса. (Центр > 0, вокруг <= 0, сумма = 0).

            int A = 0;
            int B = 1;
            int[,] M = new int[,]
            {
                { 0, -1, 0 },
                { -1, 4, -1 },
                { 0, -1, 0 },
            };

            Bitmap newSurface = new Bitmap(pictureBoxInit.Image);
            surface = ProcessBoundary();



            for (int i = 1; i < surface.Width - 2; i++)
            {
                for (int j = 1; j < surface.Height - 2; j++)
                {


                    int newColorR = (int)(
                        B * (
                            M[0, 0] * surface.GetPixel(i - 1, j - 1).R +
                            M[0, 1] * surface.GetPixel(i, j - 1).R +
                            M[0, 2] * surface.GetPixel(i + 1, j - 1).R +
                            M[1, 0] * surface.GetPixel(i - 1, j).R +
                            M[1, 1] * surface.GetPixel(i, j).R +
                            M[1, 2] * surface.GetPixel(i + 1, j).R +
                            M[2, 0] * surface.GetPixel(i - 1, j + 1).R +
                            M[2, 1] * surface.GetPixel(i, j + 1).R +
                            M[2, 1] * surface.GetPixel(i + 1, j + 1).R
                        )
                    );



                    newColorR = A + newColorR;
                    newColorR = Math.Max(0, Math.Min(newColorR, 255));

                    int newColorG = (int)(
                    B * (
                        M[0, 0] * surface.GetPixel(i - 1, j - 1).G +
                        M[0, 1] * surface.GetPixel(i, j - 1).G +
                        M[0, 2] * surface.GetPixel(i + 1, j - 1).G +
                        M[1, 0] * surface.GetPixel(i - 1, j).G +
                        M[1, 1] * surface.GetPixel(i, j).G +
                        M[1, 2] * surface.GetPixel(i + 1, j).G +
                        M[2, 0] * surface.GetPixel(i - 1, j + 1).G +
                        M[2, 1] * surface.GetPixel(i, j + 1).G +
                        M[2, 1] * surface.GetPixel(i + 1, j + 1).G
                        )
                    );



                    newColorG = A + newColorG;
                    newColorG = Math.Max(0, Math.Min(newColorG, 255));


                    int newColorB = (int)(
                        B * (
                        M[0, 0] * surface.GetPixel(i - 1, j - 1).B +
                        M[0, 1] * surface.GetPixel(i, j - 1).B +
                        M[0, 2] * surface.GetPixel(i + 1, j - 1).B +
                        M[1, 0] * surface.GetPixel(i - 1, j).B +
                        M[1, 1] * surface.GetPixel(i, j).B +
                        M[1, 2] * surface.GetPixel(i + 1, j).B +
                        M[2, 0] * surface.GetPixel(i - 1, j + 1).B +
                        M[2, 1] * surface.GetPixel(i, j + 1).B +
                        M[2, 1] * surface.GetPixel(i + 1, j + 1).B



                        )


                        );



                    newColorB = A + newColorB;
                    newColorB = Math.Max(0, Math.Min(newColorB, 255));


                    newSurface.SetPixel(i, j, Color.FromArgb(newColorR, newColorG, newColorB));


                }
            }

            pictureBoxBoundaryFilter.Image = newSurface;

        }

        private Bitmap ProcessBoundary()
        {
            Bitmap newBitmap = new Bitmap(pictureBoxInit.Image.Width + 2, pictureBoxInit.Image.Height + 2);
            Bitmap prevBitmap = (Bitmap)pictureBoxInit.Image;

            for (int i = 0; i < pictureBoxInit.Image.Width; i++)
            {
                for (int j = 0; j < pictureBoxInit.Image.Height; j++)
                {
                    newBitmap.SetPixel(i + 1, j + 1, prevBitmap.GetPixel(i, j));
                }
            }

            return newBitmap;
        }





        private void buttonGrayScale_Click(object sender, EventArgs e)
        {

        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            surface = new Bitmap(pictureBoxInit.Image);
            for (int i = 0; i < surface.Width; i++)
            {
                for (int j = 0; j < surface.Height; j++)
                {
                    Color originalColor = surface.GetPixel(i, j);


                    surface.SetPixel(i, j, Color.FromArgb(
                        255 - originalColor.R,
                        255 - originalColor.G,
                        255 - originalColor.B
                        ));
                }
            }

            pictureBoxBlackWhite.Image = surface;
        }

        private void buttoncontrast_Click(object sender, EventArgs e)
        {
            double k = double.Parse(textBox1.Text);

            surface = new Bitmap(Resources.gradient);
            for (int i = 0; i < surface.Width; i++)
            {
                for (int j = 0; j < surface.Height; j++)
                {
                    Color originalColor = surface.GetPixel(i, j);



                    surface.SetPixel(i, j, Color.FromArgb(
                        (int)(k * originalColor.R % 255),
                        (int)(k * originalColor.G % 255),
                        (int)(k * originalColor.B % 255)
                        ));
                }
            }

            pictureBoxContrast.Image = surface;
            pictureBoxContrast.Refresh();
        }

        private void buttonBoundaryFilter_Click(object sender, EventArgs e)
        {

            int A = 0;
            int B = 1;
            int[,] M = new int[,]
            {
                { 0, -1, 0 },
                { -1, 4, -1 },
                { 0, -1, 0 },
            };

            Bitmap newSurface = new Bitmap(pictureBoxInit.Image);
            surface = new Bitmap(pictureBoxInit.Image);
            for (int i = 1; i < surface.Width - 1; i++)
            {
                for (int j = 1; j < surface.Height - 1; j++)
                {


                    int newColorR = (int)(
                        B * (
                        M[0, 0] * surface.GetPixel(i - 1, j - 1).R +
                        M[0, 1] * surface.GetPixel(i, j - 1).R +
                        M[0, 2] * surface.GetPixel(i + 1, j - 1).R +
                        M[1, 0] * surface.GetPixel(i - 1, j).R +
                        M[1, 1] * surface.GetPixel(i, j).R +
                        M[1, 2] * surface.GetPixel(i + 1, j).R +
                        M[2, 0] * surface.GetPixel(i - 1, j + 1).R +
                        M[2, 1] * surface.GetPixel(i, j + 1).R +
                        M[2, 1] * surface.GetPixel(i + 1, j + 1).R



                        )


                        );



                    newColorR = A + newColorR;
                    newColorR = Math.Max(0, Math.Min(newColorR, 255));

                    int newColorG = (int)(
                        B * (
                        M[0, 0] * surface.GetPixel(i - 1, j - 1).G +
                        M[0, 1] * surface.GetPixel(i, j - 1).G +
                        M[0, 2] * surface.GetPixel(i + 1, j - 1).G +
                        M[1, 0] * surface.GetPixel(i - 1, j).G +
                        M[1, 1] * surface.GetPixel(i, j).G +
                        M[1, 2] * surface.GetPixel(i + 1, j).G +
                        M[2, 0] * surface.GetPixel(i - 1, j + 1).G +
                        M[2, 1] * surface.GetPixel(i, j + 1).G +
                        M[2, 1] * surface.GetPixel(i + 1, j + 1).G

                            )

                        );



                    newColorG = A + newColorG;
                    newColorG = Math.Max(0, Math.Min(newColorG, 255));


                    int newColorB = (int)(
                        B * (
                        M[0, 0] * surface.GetPixel(i - 1, j - 1).B +
                        M[0, 1] * surface.GetPixel(i, j - 1).B +
                        M[0, 2] * surface.GetPixel(i + 1, j - 1).B +
                        M[1, 0] * surface.GetPixel(i - 1, j).B +
                        M[1, 1] * surface.GetPixel(i, j).B +
                        M[1, 2] * surface.GetPixel(i + 1, j).B +
                        M[2, 0] * surface.GetPixel(i - 1, j + 1).B +
                        M[2, 1] * surface.GetPixel(i, j + 1).B +
                        M[2, 1] * surface.GetPixel(i + 1, j + 1).B



                        )


                        );



                    newColorB = A + newColorB;
                    newColorB = Math.Max(0, Math.Min(newColorB, 255));






                    newSurface.SetPixel(i, j, Color.FromArgb(newColorR, newColorG, newColorB));


                }
            }

            pictureBoxBoundaryFilter.Image = newSurface;
        }
    }
}
