namespace Lab5
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
            this.mainCanvas = new System.Windows.Forms.PictureBox();
            this.solveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.White;
            this.mainCanvas.Location = new System.Drawing.Point(12, 12);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(511, 426);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(529, 12);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(75, 23);
            this.solveBtn.TabIndex = 1;
            this.solveBtn.Text = "Решить";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.mainCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox mainCanvas;
        private Button solveBtn;
    }
}