namespace comp_graphics_c_
{
    partial class Paint
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
            textBoxRadius = new TextBox();
            label1 = new Label();
            buttonCircle = new Button();
            pictureBox1 = new PictureBox();
            textBoxColorR = new TextBox();
            textBoxColorG = new TextBox();
            textBoxColorB = new TextBox();
            buttonFloodFill = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonDrawLine = new Button();
            buttonBezierCurve = new Button();
            buttonBezierCurveGeom = new Button();
            textBoxParameterT = new TextBox();
            label6 = new Label();
            buttonWipe = new Button();
            buttonFloodFillPattern = new Button();
            buttonDynamicBezierCurve = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxRadius
            // 
            textBoxRadius.Location = new Point(1340, 187);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(107, 27);
            textBoxRadius.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1322, 164);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 2;
            label1.Text = "Радиус окружности";
            // 
            // buttonCircle
            // 
            buttonCircle.Location = new Point(1304, 220);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(161, 29);
            buttonCircle.TabIndex = 3;
            buttonCircle.Text = "Окружность";
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1268, 629);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // textBoxColorR
            // 
            textBoxColorR.Location = new Point(1340, 58);
            textBoxColorR.Name = "textBoxColorR";
            textBoxColorR.Size = new Size(107, 27);
            textBoxColorR.TabIndex = 5;
            // 
            // textBoxColorG
            // 
            textBoxColorG.Location = new Point(1340, 91);
            textBoxColorG.Name = "textBoxColorG";
            textBoxColorG.Size = new Size(107, 27);
            textBoxColorG.TabIndex = 6;
            // 
            // textBoxColorB
            // 
            textBoxColorB.Location = new Point(1340, 124);
            textBoxColorB.Name = "textBoxColorB";
            textBoxColorB.Size = new Size(107, 27);
            textBoxColorB.TabIndex = 7;
            // 
            // buttonFloodFill
            // 
            buttonFloodFill.Location = new Point(1304, 275);
            buttonFloodFill.Name = "buttonFloodFill";
            buttonFloodFill.Size = new Size(161, 29);
            buttonFloodFill.TabIndex = 8;
            buttonFloodFill.Text = "Заливка";
            buttonFloodFill.UseVisualStyleBackColor = true;
            buttonFloodFill.Click += buttonFloodFill_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1318, 18);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 9;
            label2.Text = "Выберете режим";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1304, 61);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 10;
            label3.Text = "R";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1304, 94);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 11;
            label4.Text = "G";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1304, 127);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 12;
            label5.Text = "B";
            // 
            // buttonDrawLine
            // 
            buttonDrawLine.Location = new Point(1304, 375);
            buttonDrawLine.Name = "buttonDrawLine";
            buttonDrawLine.Size = new Size(161, 29);
            buttonDrawLine.TabIndex = 13;
            buttonDrawLine.Text = "Прямая";
            buttonDrawLine.UseVisualStyleBackColor = true;
            buttonDrawLine.Click += buttonDrawLine_Click;
            // 
            // buttonBezierCurve
            // 
            buttonBezierCurve.Location = new Point(1304, 514);
            buttonBezierCurve.Name = "buttonBezierCurve";
            buttonBezierCurve.Size = new Size(161, 29);
            buttonBezierCurve.TabIndex = 14;
            buttonBezierCurve.Text = "Кривая Безье(4 т.)";
            buttonBezierCurve.UseVisualStyleBackColor = true;
            buttonBezierCurve.Click += buttonBezierCurve_Click;
            // 
            // buttonBezierCurveGeom
            // 
            buttonBezierCurveGeom.Location = new Point(1304, 549);
            buttonBezierCurveGeom.Name = "buttonBezierCurveGeom";
            buttonBezierCurveGeom.Size = new Size(161, 30);
            buttonBezierCurveGeom.TabIndex = 15;
            buttonBezierCurveGeom.Text = "Кривая Безье(геом)";
            buttonBezierCurveGeom.UseVisualStyleBackColor = true;
            buttonBezierCurveGeom.Click += buttonBezierCurveGeom_Click;
            // 
            // textBoxParameterT
            // 
            textBoxParameterT.Location = new Point(1340, 430);
            textBoxParameterT.Name = "textBoxParameterT";
            textBoxParameterT.Size = new Size(107, 27);
            textBoxParameterT.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1304, 437);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 17;
            label6.Text = "t =";
            // 
            // buttonWipe
            // 
            buttonWipe.Location = new Point(1304, 597);
            buttonWipe.Name = "buttonWipe";
            buttonWipe.Size = new Size(161, 29);
            buttonWipe.TabIndex = 18;
            buttonWipe.Text = "Сброс";
            buttonWipe.UseVisualStyleBackColor = true;
            buttonWipe.Click += buttonWipe_Click;
            // 
            // buttonFloodFillPattern
            // 
            buttonFloodFillPattern.Location = new Point(1304, 326);
            buttonFloodFillPattern.Name = "buttonFloodFillPattern";
            buttonFloodFillPattern.Size = new Size(161, 29);
            buttonFloodFillPattern.TabIndex = 19;
            buttonFloodFillPattern.Text = "Узор";
            buttonFloodFillPattern.UseVisualStyleBackColor = true;
            buttonFloodFillPattern.Click += buttonFloodFillPattern_Click;
            // 
            // buttonDynamicBezierCurve
            // 
            buttonDynamicBezierCurve.Location = new Point(1304, 479);
            buttonDynamicBezierCurve.Name = "buttonDynamicBezierCurve";
            buttonDynamicBezierCurve.Size = new Size(161, 29);
            buttonDynamicBezierCurve.TabIndex = 20;
            buttonDynamicBezierCurve.Text = "Кривая Безье( n т. )";
            buttonDynamicBezierCurve.UseVisualStyleBackColor = true;
            buttonDynamicBezierCurve.Click += buttonDynamicBezierCurve_Click;
            // 
            // Paint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 653);
            Controls.Add(buttonDynamicBezierCurve);
            Controls.Add(buttonFloodFillPattern);
            Controls.Add(buttonWipe);
            Controls.Add(label6);
            Controls.Add(textBoxParameterT);
            Controls.Add(buttonBezierCurveGeom);
            Controls.Add(buttonBezierCurve);
            Controls.Add(buttonDrawLine);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonFloodFill);
            Controls.Add(textBoxColorB);
            Controls.Add(textBoxColorG);
            Controls.Add(textBoxColorR);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCircle);
            Controls.Add(label1);
            Controls.Add(textBoxRadius);
            Name = "Paint";
            Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxRadius;
        private Label label1;
        private Button buttonCircle;
        private PictureBox pictureBox1;
        private TextBox textBoxColorR;
        private TextBox textBoxColorG;
        private TextBox textBoxColorB;
        private Button buttonFloodFill;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonDrawLine;
        private Button buttonBezierCurve;
        private Button buttonBezierCurveGeom;
        private TextBox textBoxParameterT;
        private Label label6;
        private Button buttonWipe;
        private Button buttonFloodFillPattern;
        private Button buttonDynamicBezierCurve;
    }
}