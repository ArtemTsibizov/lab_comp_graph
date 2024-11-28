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
            pictureBoxBlackWhite = new PictureBox();
            buttoncontrast = new Button();
            pictureBoxInit = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBoxContrast = new PictureBox();
            pictureBoxBoundaryFilter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlackWhite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoundaryFilter).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBlackWhite
            // 
            pictureBoxBlackWhite.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxBlackWhite.InitialImage = null;
            pictureBoxBlackWhite.Location = new Point(762, 12);
            pictureBoxBlackWhite.Name = "pictureBoxBlackWhite";
            pictureBoxBlackWhite.Size = new Size(664, 405);
            pictureBoxBlackWhite.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBlackWhite.TabIndex = 0;
            pictureBoxBlackWhite.TabStop = false;
            // 
            // buttoncontrast
            // 
            buttoncontrast.Location = new Point(459, 458);
            buttoncontrast.Name = "buttoncontrast";
            buttoncontrast.Size = new Size(199, 48);
            buttoncontrast.TabIndex = 3;
            buttoncontrast.Text = "(пилообразное контрастное";
            buttoncontrast.UseVisualStyleBackColor = true;
            buttoncontrast.Click += buttoncontrast_Click;
            // 
            // pictureBoxInit
            // 
            pictureBoxInit.Image = (Image)resources.GetObject("pictureBoxInit.Image");
            pictureBoxInit.InitialImage = null;
            pictureBoxInit.Location = new Point(12, 12);
            pictureBoxInit.Name = "pictureBoxInit";
            pictureBoxInit.Size = new Size(664, 405);
            pictureBoxInit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxInit.TabIndex = 4;
            pictureBoxInit.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(517, 516);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 519);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 6;
            label1.Text = "k=";
            // 
            // pictureBoxContrast
            // 
            pictureBoxContrast.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxContrast.ErrorImage = (Image)resources.GetObject("pictureBoxContrast.ErrorImage");
            pictureBoxContrast.Image = (Image)resources.GetObject("pictureBoxContrast.Image");
            pictureBoxContrast.InitialImage = null;
            pictureBoxContrast.Location = new Point(35, 446);
            pictureBoxContrast.Name = "pictureBoxContrast";
            pictureBoxContrast.Size = new Size(396, 393);
            pictureBoxContrast.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxContrast.TabIndex = 8;
            pictureBoxContrast.TabStop = false;
            // 
            // pictureBoxBoundaryFilter
            // 
            pictureBoxBoundaryFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxBoundaryFilter.ErrorImage = (Image)resources.GetObject("pictureBoxBoundaryFilter.ErrorImage");
            pictureBoxBoundaryFilter.InitialImage = null;
            pictureBoxBoundaryFilter.Location = new Point(762, 446);
            pictureBoxBoundaryFilter.Name = "pictureBoxBoundaryFilter";
            pictureBoxBoundaryFilter.Size = new Size(664, 405);
            pictureBoxBoundaryFilter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBoundaryFilter.TabIndex = 9;
            pictureBoxBoundaryFilter.TabStop = false;
            // 
            // FormPictureProcess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 863);
            Controls.Add(pictureBoxBoundaryFilter);
            Controls.Add(pictureBoxContrast);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBoxInit);
            Controls.Add(buttoncontrast);
            Controls.Add(pictureBoxBlackWhite);
            Name = "FormPictureProcess";
            Text = "FormPictureProcess";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlackWhite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContrast).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoundaryFilter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxBlackWhite;
        private Button buttoncontrast;
        private PictureBox pictureBoxInit;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBoxContrast;
        private PictureBox pictureBoxBoundaryFilter;
    }
}