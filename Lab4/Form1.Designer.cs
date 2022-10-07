namespace Lab4
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
            this.mainCanvas = new System.Windows.Forms.PictureBox();
            this.filenameLbl = new System.Windows.Forms.TextBox();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberNud = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            this.learnBtn = new System.Windows.Forms.Button();
            this.mainPb = new System.Windows.Forms.ProgressBar();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNud)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.White;
            this.mainCanvas.Location = new System.Drawing.Point(12, 23);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(489, 489);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
            // 
            // filenameLbl
            // 
            this.filenameLbl.Location = new System.Drawing.Point(260, 519);
            this.filenameLbl.Name = "filenameLbl";
            this.filenameLbl.Size = new System.Drawing.Size(199, 20);
            this.filenameLbl.TabIndex = 1;
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(458, 518);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(43, 21);
            this.chooseFileBtn.TabIndex = 2;
            this.chooseFileBtn.Text = "...";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Файл для сохранения тренировочных данных:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цифра:";
            // 
            // numberNud
            // 
            this.numberNud.Location = new System.Drawing.Point(266, 545);
            this.numberNud.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numberNud.Name = "numberNud";
            this.numberNud.Size = new System.Drawing.Size(90, 20);
            this.numberNud.TabIndex = 7;
            this.numberNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(365, 545);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // learnBtn
            // 
            this.learnBtn.Location = new System.Drawing.Point(507, 23);
            this.learnBtn.Name = "learnBtn";
            this.learnBtn.Size = new System.Drawing.Size(207, 23);
            this.learnBtn.TabIndex = 9;
            this.learnBtn.Text = "ОБУЧИТЬ МОДЕЛЬ";
            this.learnBtn.UseVisualStyleBackColor = true;
            // 
            // mainPb
            // 
            this.mainPb.Location = new System.Drawing.Point(507, 52);
            this.mainPb.Name = "mainPb";
            this.mainPb.Size = new System.Drawing.Size(422, 23);
            this.mainPb.TabIndex = 10;
            // 
            // calcBtn
            // 
            this.calcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcBtn.Location = new System.Drawing.Point(720, 23);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(209, 23);
            this.calcBtn.TabIndex = 11;
            this.calcBtn.Text = "ПОЛУЧИТЬ ОТВЕТ";
            this.calcBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Нейросеть считает что это цифра:";
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLbl.Location = new System.Drawing.Point(616, 108);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(206, 226);
            this.mainLbl.TabIndex = 13;
            this.mainLbl.Text = "8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 617);
            this.Controls.Add(this.mainLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.mainPb);
            this.Controls.Add(this.learnBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.numberNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(this.filenameLbl);
            this.Controls.Add(this.mainCanvas);
            this.Name = "Form1";
            this.Text = "ФНС";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.TextBox filenameLbl;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberNud;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button learnBtn;
        private System.Windows.Forms.ProgressBar mainPb;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mainLbl;
    }
}

