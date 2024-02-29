namespace ThreadingDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnProcess1 = new Button();
            btnProcecess2 = new Button();
            SuspendLayout();
            // 
            // BtnProcess1
            // 
            BtnProcess1.Location = new Point(99, 58);
            BtnProcess1.Name = "BtnProcess1";
            BtnProcess1.Size = new Size(94, 29);
            BtnProcess1.TabIndex = 0;
            BtnProcess1.Text = "İŞLEM1";
            BtnProcess1.UseVisualStyleBackColor = true;
            BtnProcess1.Click += BtnProcess1_Click;
            // 
            // btnProcecess2
            // 
            btnProcecess2.Location = new Point(309, 58);
            btnProcecess2.Name = "btnProcecess2";
            btnProcecess2.Size = new Size(94, 29);
            btnProcecess2.TabIndex = 1;
            btnProcecess2.Text = "İŞLEM2";
            btnProcecess2.UseVisualStyleBackColor = true;
            btnProcecess2.Click += btnProcecess2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcecess2);
            Controls.Add(BtnProcess1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnProcess1;
        private Button btnProcecess2;
    }
}
