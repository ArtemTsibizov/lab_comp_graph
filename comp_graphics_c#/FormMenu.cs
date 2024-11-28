using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp_graphics_c_
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Paint_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paint paint = new Paint();
            paint.ShowDialog();
            this.Show();
        }

        private void PictureProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPictureProcess FormPictureProcess = new FormPictureProcess();
            FormPictureProcess.ShowDialog();
            this.Show();
        }

        private void button3dGraphics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3dGraphics form3DGraphics = new Form3dGraphics();
            form3DGraphics.ShowDialog();
            this.Show();
        }
    }
}
