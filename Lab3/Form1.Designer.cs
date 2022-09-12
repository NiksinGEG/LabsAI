namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.testLbl = new System.Windows.Forms.Label();
            this.solveBtn = new System.Windows.Forms.Button();
            this.lenLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.Location = new System.Drawing.Point(12, 9);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(35, 13);
            this.testLbl.TabIndex = 0;
            this.testLbl.Text = "label1";
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(12, 51);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(75, 23);
            this.solveBtn.TabIndex = 1;
            this.solveBtn.Text = "Решить!";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // lenLbl
            // 
            this.lenLbl.AutoSize = true;
            this.lenLbl.Location = new System.Drawing.Point(12, 26);
            this.lenLbl.Name = "lenLbl";
            this.lenLbl.Size = new System.Drawing.Size(35, 13);
            this.lenLbl.TabIndex = 2;
            this.lenLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lenLbl);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.testLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testLbl;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Label lenLbl;
    }
}

