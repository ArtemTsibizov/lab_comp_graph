namespace comp_graphics_c_
{
    partial class Form3dGraphics
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
            pictureBox1 = new PictureBox();
            textBoxScaleFactorX = new TextBox();
            textBoxYRotation = new TextBox();
            textBoxZRotation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxR = new TextBox();
            textBox_r = new TextBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDownAngleX = new NumericUpDown();
            numericUpDownAngleY = new NumericUpDown();
            numericUpDownAngleZ = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            numericUpDownShiftX = new NumericUpDown();
            numericUpDownShiftY = new NumericUpDown();
            numericUpDownShiftZ = new NumericUpDown();
            buttonScaleFactorX = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAngleX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAngleY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAngleZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShiftX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShiftY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShiftZ).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1307, 550);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxScaleFactorX
            // 
            textBoxScaleFactorX.Location = new Point(1194, 558);
            textBoxScaleFactorX.Name = "textBoxScaleFactorX";
            textBoxScaleFactorX.Size = new Size(125, 27);
            textBoxScaleFactorX.TabIndex = 3;
            textBoxScaleFactorX.Text = "0";
            // 
            // textBoxYRotation
            // 
            textBoxYRotation.Location = new Point(1194, 591);
            textBoxYRotation.Name = "textBoxYRotation";
            textBoxYRotation.Size = new Size(125, 27);
            textBoxYRotation.TabIndex = 4;
            textBoxYRotation.Text = "0";
            // 
            // textBoxZRotation
            // 
            textBoxZRotation.Location = new Point(1194, 624);
            textBoxZRotation.Name = "textBoxZRotation";
            textBoxZRotation.Size = new Size(125, 27);
            textBoxZRotation.TabIndex = 5;
            textBoxZRotation.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 588);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 6;
            label1.Text = "угол x=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 590);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "угол y=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 588);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 8;
            label3.Text = "угол z=";
            // 
            // textBoxR
            // 
            textBoxR.Location = new Point(56, 581);
            textBoxR.Name = "textBoxR";
            textBoxR.Size = new Size(125, 27);
            textBoxR.TabIndex = 9;
            textBoxR.Text = "100";
            // 
            // textBox_r
            // 
            textBox_r.Location = new Point(56, 613);
            textBox_r.Name = "textBox_r";
            textBox_r.Size = new Size(125, 27);
            textBox_r.TabIndex = 10;
            textBox_r.Text = "30";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 584);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 11;
            label4.Text = "R=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 618);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 12;
            label5.Text = "r=";
            // 
            // numericUpDownAngleX
            // 
            numericUpDownAngleX.Location = new Point(251, 613);
            numericUpDownAngleX.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownAngleX.Name = "numericUpDownAngleX";
            numericUpDownAngleX.Size = new Size(91, 27);
            numericUpDownAngleX.TabIndex = 16;
            numericUpDownAngleX.ValueChanged += numericUpDownAngleX_ValueChanged;
            // 
            // numericUpDownAngleY
            // 
            numericUpDownAngleY.Location = new Point(406, 613);
            numericUpDownAngleY.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownAngleY.Name = "numericUpDownAngleY";
            numericUpDownAngleY.Size = new Size(98, 27);
            numericUpDownAngleY.TabIndex = 17;
            numericUpDownAngleY.ValueChanged += numericUpDownAngleY_ValueChanged;
            // 
            // numericUpDownAngleZ
            // 
            numericUpDownAngleZ.Location = new Point(579, 611);
            numericUpDownAngleZ.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownAngleZ.Name = "numericUpDownAngleZ";
            numericUpDownAngleZ.Size = new Size(94, 27);
            numericUpDownAngleZ.TabIndex = 18;
            numericUpDownAngleZ.ValueChanged += numericUpDownAngleZ_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(713, 616);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 19;
            label6.Text = "dx=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(838, 616);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 21;
            label7.Text = "dy=";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(966, 616);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 23;
            label8.Text = "dz=";
            // 
            // numericUpDownShiftX
            // 
            numericUpDownShiftX.Location = new Point(754, 613);
            numericUpDownShiftX.Name = "numericUpDownShiftX";
            numericUpDownShiftX.Size = new Size(78, 27);
            numericUpDownShiftX.TabIndex = 24;
            numericUpDownShiftX.ValueChanged += numericUpDownShiftX_ValueChanged;
            // 
            // numericUpDownShiftY
            // 
            numericUpDownShiftY.Location = new Point(879, 614);
            numericUpDownShiftY.Name = "numericUpDownShiftY";
            numericUpDownShiftY.Size = new Size(81, 27);
            numericUpDownShiftY.TabIndex = 25;
            numericUpDownShiftY.ValueChanged += numericUpDownShiftY_ValueChanged;
            // 
            // numericUpDownShiftZ
            // 
            numericUpDownShiftZ.Location = new Point(1007, 616);
            numericUpDownShiftZ.Name = "numericUpDownShiftZ";
            numericUpDownShiftZ.Size = new Size(88, 27);
            numericUpDownShiftZ.TabIndex = 26;
            numericUpDownShiftZ.ValueChanged += numericUpDownShiftZ_ValueChanged;
            // 
            // buttonScaleFactorX
            // 
            buttonScaleFactorX.Location = new Point(1081, 557);
            buttonScaleFactorX.Name = "buttonScaleFactorX";
            buttonScaleFactorX.Size = new Size(94, 29);
            buttonScaleFactorX.TabIndex = 27;
            buttonScaleFactorX.Text = "button1";
            buttonScaleFactorX.UseVisualStyleBackColor = true;
            buttonScaleFactorX.Click += buttonScaleFactorX_Click;
            // 
            // Form3dGraphics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 653);
            Controls.Add(buttonScaleFactorX);
            Controls.Add(numericUpDownShiftZ);
            Controls.Add(numericUpDownShiftY);
            Controls.Add(numericUpDownShiftX);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericUpDownAngleZ);
            Controls.Add(numericUpDownAngleY);
            Controls.Add(numericUpDownAngleX);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_r);
            Controls.Add(textBoxR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxZRotation);
            Controls.Add(textBoxYRotation);
            Controls.Add(textBoxScaleFactorX);
            Controls.Add(pictureBox1);
            Name = "Form3dGraphics";
            Text = "Form3dGraphics";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAngleX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAngleY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAngleZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShiftX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShiftY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShiftZ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxScaleFactorX;
        private TextBox textBoxYRotation;
        private TextBox textBoxZRotation;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxR;
        private TextBox textBox_r;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownAngleX;
        private NumericUpDown numericUpDownAngleY;
        private NumericUpDown numericUpDownAngleZ;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDownShiftX;
        private NumericUpDown numericUpDownShiftY;
        private NumericUpDown numericUpDownShiftZ;
        private Button buttonScaleFactorX;
    }
}