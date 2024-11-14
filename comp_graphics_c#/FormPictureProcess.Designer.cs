namespace comp_graphics_c_
{
    partial class FormPictureProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPictureProcess));
            pictureBox1 = new PictureBox();
            buttonGrayScale = new Button();
            buttonNegative = new Button();
            buttoncontrast = new Button();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            buttonBoundaryFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(657, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(629, 591);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonGrayScale
            // 
            buttonGrayScale.Location = new Point(1292, 23);
            buttonGrayScale.Name = "buttonGrayScale";
            buttonGrayScale.Size = new Size(199, 29);
            buttonGrayScale.TabIndex = 1;
            buttonGrayScale.Text = "Оттенки серого";
            buttonGrayScale.UseVisualStyleBackColor = true;
            buttonGrayScale.Click += buttonGrayScale_Click;
            // 
            // buttonNegative
            // 
            buttonNegative.Location = new Point(1292, 84);
            buttonNegative.Name = "buttonNegative";
            buttonNegative.Size = new Size(94, 29);
            buttonNegative.TabIndex = 2;
            buttonNegative.Text = "Негатив";
            buttonNegative.UseVisualStyleBackColor = true;
            buttonNegative.Click += buttonNegative_Click;
            // 
            // buttoncontrast
            // 
            buttoncontrast.Location = new Point(1292, 151);
            buttoncontrast.Name = "buttoncontrast";
            buttoncontrast.Size = new Size(199, 48);
            buttoncontrast.TabIndex = 3;
            buttoncontrast.Text = "(пилообразное контрастное";
            buttoncontrast.UseVisualStyleBackColor = true;
            buttoncontrast.Click += buttoncontrast_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(12, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(629, 591);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1350, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1292, 257);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 6;
            label1.Text = "k=";
            // 
            // buttonBoundaryFilter
            // 
            buttonBoundaryFilter.Location = new Point(1292, 306);
            buttonBoundaryFilter.Name = "buttonBoundaryFilter";
            buttonBoundaryFilter.Size = new Size(199, 51);
            buttonBoundaryFilter.TabIndex = 7;
            buttonBoundaryFilter.Text = "Фильтр определения границ";
            buttonBoundaryFilter.UseVisualStyleBackColor = true;
            buttonBoundaryFilter.Click += buttonBoundaryFilter_Click;
            // 
            // FormPictureProcess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 658);
            Controls.Add(buttonBoundaryFilter);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(buttoncontrast);
            Controls.Add(buttonNegative);
            Controls.Add(buttonGrayScale);
            Controls.Add(pictureBox1);
            Name = "FormPictureProcess";
            Text = "FormPictureProcess";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonGrayScale;
        private Button buttonNegative;
        private Button buttoncontrast;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label1;
        private Button buttonBoundaryFilter;
    }
}