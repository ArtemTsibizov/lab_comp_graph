namespace comp_graphics_c_
{
    partial class FormMenu
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
            Paint = new Button();
            PictureProcess = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Paint
            // 
            Paint.Location = new Point(209, 215);
            Paint.Name = "Paint";
            Paint.Size = new Size(164, 56);
            Paint.TabIndex = 0;
            Paint.Text = "Лабораторная 3";
            Paint.UseVisualStyleBackColor = true;
            Paint.Click += Paint_Click;
            // 
            // PictureProcess
            // 
            PictureProcess.Location = new Point(457, 215);
            PictureProcess.Name = "PictureProcess";
            PictureProcess.Size = new Size(164, 56);
            PictureProcess.TabIndex = 1;
            PictureProcess.Text = "Лабораторная 4";
            PictureProcess.UseVisualStyleBackColor = true;
            PictureProcess.Click += PictureProcess_Click;
            // 
            // button3
            // 
            button3.Location = new Point(712, 215);
            button3.Name = "button3";
            button3.Size = new Size(164, 56);
            button3.TabIndex = 2;
            button3.Text = "Лабораторная 5";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 553);
            Controls.Add(button3);
            Controls.Add(PictureProcess);
            Controls.Add(Paint);
            Name = "FormMenu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button Paint;
        private Button PictureProcess;
        private Button button3;
    }
}