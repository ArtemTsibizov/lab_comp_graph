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
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxScaleX = new TextBox();
            textBoxScaleY = new TextBox();
            textBoxScaleZ = new TextBox();
            buttonScale = new Button();
            label12 = new Label();
            textBoxStepA = new TextBox();
            label13 = new Label();
            textBoxStepB = new TextBox();
            buttonStep = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 572);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 6;
            label1.Text = "угол x=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 574);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "угол y=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 573);
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
            numericUpDownAngleX.Location = new Point(219, 597);
            numericUpDownAngleX.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownAngleX.Name = "numericUpDownAngleX";
            numericUpDownAngleX.Size = new Size(91, 27);
            numericUpDownAngleX.TabIndex = 16;
            numericUpDownAngleX.ValueChanged += numericUpDownAngleX_ValueChanged;
            // 
            // numericUpDownAngleY
            // 
            numericUpDownAngleY.Location = new Point(330, 597);
            numericUpDownAngleY.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownAngleY.Name = "numericUpDownAngleY";
            numericUpDownAngleY.Size = new Size(98, 27);
            numericUpDownAngleY.TabIndex = 17;
            numericUpDownAngleY.ValueChanged += numericUpDownAngleY_ValueChanged;
            // 
            // numericUpDownAngleZ
            // 
            numericUpDownAngleZ.Location = new Point(454, 597);
            numericUpDownAngleZ.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownAngleZ.Name = "numericUpDownAngleZ";
            numericUpDownAngleZ.Size = new Size(94, 27);
            numericUpDownAngleZ.TabIndex = 18;
            numericUpDownAngleZ.ValueChanged += numericUpDownAngleZ_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(808, 571);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 19;
            label6.Text = "dx=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(933, 571);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 21;
            label7.Text = "dy=";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1061, 571);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 23;
            label8.Text = "dz=";
            // 
            // numericUpDownShiftX
            // 
            numericUpDownShiftX.Location = new Point(849, 568);
            numericUpDownShiftX.Name = "numericUpDownShiftX";
            numericUpDownShiftX.Size = new Size(78, 27);
            numericUpDownShiftX.TabIndex = 24;
            numericUpDownShiftX.ValueChanged += numericUpDownShiftX_ValueChanged;
            // 
            // numericUpDownShiftY
            // 
            numericUpDownShiftY.Location = new Point(974, 568);
            numericUpDownShiftY.Name = "numericUpDownShiftY";
            numericUpDownShiftY.Size = new Size(81, 27);
            numericUpDownShiftY.TabIndex = 25;
            numericUpDownShiftY.ValueChanged += numericUpDownShiftY_ValueChanged;
            // 
            // numericUpDownShiftZ
            // 
            numericUpDownShiftZ.Location = new Point(1102, 568);
            numericUpDownShiftZ.Name = "numericUpDownShiftZ";
            numericUpDownShiftZ.Size = new Size(88, 27);
            numericUpDownShiftZ.TabIndex = 26;
            numericUpDownShiftZ.ValueChanged += numericUpDownShiftZ_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(808, 616);
            label9.Name = "label9";
            label9.Size = new Size(35, 20);
            label9.TabIndex = 27;
            label9.Text = "kX=";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(934, 616);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 29;
            label10.Text = "kY=";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1061, 620);
            label11.Name = "label11";
            label11.Size = new Size(35, 20);
            label11.TabIndex = 31;
            label11.Text = "kZ=";
            // 
            // textBoxScaleX
            // 
            textBoxScaleX.Location = new Point(849, 614);
            textBoxScaleX.Name = "textBoxScaleX";
            textBoxScaleX.Size = new Size(78, 27);
            textBoxScaleX.TabIndex = 33;
            textBoxScaleX.Text = "1";
            // 
            // textBoxScaleY
            // 
            textBoxScaleY.Location = new Point(974, 614);
            textBoxScaleY.Name = "textBoxScaleY";
            textBoxScaleY.Size = new Size(81, 27);
            textBoxScaleY.TabIndex = 34;
            textBoxScaleY.Text = "1";
            // 
            // textBoxScaleZ
            // 
            textBoxScaleZ.Location = new Point(1102, 614);
            textBoxScaleZ.Name = "textBoxScaleZ";
            textBoxScaleZ.Size = new Size(88, 27);
            textBoxScaleZ.TabIndex = 35;
            textBoxScaleZ.Text = "1";
            // 
            // buttonScale
            // 
            buttonScale.Location = new Point(1209, 617);
            buttonScale.Name = "buttonScale";
            buttonScale.Size = new Size(94, 29);
            buttonScale.TabIndex = 36;
            buttonScale.Text = "scale";
            buttonScale.UseVisualStyleBackColor = true;
            buttonScale.Click += buttonScale_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(579, 556);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 37;
            label12.Text = "шаг по a";
            // 
            // textBoxStepA
            // 
            textBoxStepA.Location = new Point(579, 584);
            textBoxStepA.Name = "textBoxStepA";
            textBoxStepA.Size = new Size(72, 27);
            textBoxStepA.TabIndex = 38;
            textBoxStepA.Text = "0,1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(674, 560);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 39;
            label13.Text = "шаг по b";
            // 
            // textBoxStepB
            // 
            textBoxStepB.Location = new Point(674, 584);
            textBoxStepB.Name = "textBoxStepB";
            textBoxStepB.Size = new Size(70, 27);
            textBoxStepB.TabIndex = 40;
            textBoxStepB.Text = "0,1";
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(618, 617);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(94, 29);
            buttonStep.TabIndex = 41;
            buttonStep.Text = "step";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // Form3dGraphics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 653);
            Controls.Add(buttonStep);
            Controls.Add(textBoxStepB);
            Controls.Add(label13);
            Controls.Add(textBoxStepA);
            Controls.Add(label12);
            Controls.Add(buttonScale);
            Controls.Add(textBoxScaleZ);
            Controls.Add(textBoxScaleY);
            Controls.Add(textBoxScaleX);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
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
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxScaleX;
        private TextBox textBoxScaleY;
        private TextBox textBoxScaleZ;
        private Button buttonScale;
        private Label label12;
        private TextBox textBoxStepA;
        private Label label13;
        private TextBox textBoxStepB;
        private Button buttonStep;
    }
}