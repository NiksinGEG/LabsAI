namespace Lab1Framework
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tempNud = new System.Windows.Forms.NumericUpDown();
            this.sizeNud = new System.Windows.Forms.NumericUpDown();
            this.minTempNud = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.energyLbl = new System.Windows.Forms.Label();
            this.alphaNud = new System.Windows.Forms.NumericUpDown();
            this.stepsNud = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.analisBtn = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTempNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Задача N ферзей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начальная температура:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Конечная температура:";
            // 
            // tempNud
            // 
            this.tempNud.DecimalPlaces = 1;
            this.tempNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tempNud.Location = new System.Drawing.Point(152, 91);
            this.tempNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tempNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tempNud.Name = "tempNud";
            this.tempNud.Size = new System.Drawing.Size(49, 20);
            this.tempNud.TabIndex = 4;
            this.tempNud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // sizeNud
            // 
            this.sizeNud.Location = new System.Drawing.Point(152, 65);
            this.sizeNud.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sizeNud.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sizeNud.Name = "sizeNud";
            this.sizeNud.Size = new System.Drawing.Size(49, 20);
            this.sizeNud.TabIndex = 5;
            this.sizeNud.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // minTempNud
            // 
            this.minTempNud.DecimalPlaces = 1;
            this.minTempNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.minTempNud.Location = new System.Drawing.Point(152, 117);
            this.minTempNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minTempNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.minTempNud.Name = "minTempNud";
            this.minTempNud.Size = new System.Drawing.Size(49, 20);
            this.minTempNud.TabIndex = 6;
            this.minTempNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Кол-во шагов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Альфа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Энергия решения:";
            // 
            // energyLbl
            // 
            this.energyLbl.AutoSize = true;
            this.energyLbl.Location = new System.Drawing.Point(312, 119);
            this.energyLbl.Name = "energyLbl";
            this.energyLbl.Size = new System.Drawing.Size(13, 13);
            this.energyLbl.TabIndex = 10;
            this.energyLbl.Text = "?";
            // 
            // alphaNud
            // 
            this.alphaNud.DecimalPlaces = 2;
            this.alphaNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alphaNud.Location = new System.Drawing.Point(315, 91);
            this.alphaNud.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.alphaNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alphaNud.Name = "alphaNud";
            this.alphaNud.Size = new System.Drawing.Size(49, 20);
            this.alphaNud.TabIndex = 11;
            this.alphaNud.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // stepsNud
            // 
            this.stepsNud.Location = new System.Drawing.Point(315, 65);
            this.stepsNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stepsNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepsNud.Name = "stepsNud";
            this.stepsNud.Size = new System.Drawing.Size(49, 20);
            this.stepsNud.TabIndex = 12;
            this.stepsNud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // analisBtn
            // 
            this.analisBtn.Location = new System.Drawing.Point(421, 497);
            this.analisBtn.Name = "analisBtn";
            this.analisBtn.Size = new System.Drawing.Size(138, 23);
            this.analisBtn.TabIndex = 14;
            this.analisBtn.Text = "Менеджер анализа";
            this.analisBtn.UseVisualStyleBackColor = true;
            this.analisBtn.Click += new System.EventHandler(this.analisBtn_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveBtn.Location = new System.Drawing.Point(422, 523);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(137, 23);
            this.solveBtn.TabIndex = 15;
            this.solveBtn.Text = "Решить!";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 558);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.analisBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stepsNud);
            this.Controls.Add(this.alphaNud);
            this.Controls.Add(this.energyLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minTempNud);
            this.Controls.Add(this.sizeNud);
            this.Controls.Add(this.tempNud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Задача N ферзей";
            ((System.ComponentModel.ISupportInitialize)(this.tempNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTempNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tempNud;
        private System.Windows.Forms.NumericUpDown sizeNud;
        private System.Windows.Forms.NumericUpDown minTempNud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label energyLbl;
        private System.Windows.Forms.NumericUpDown alphaNud;
        private System.Windows.Forms.NumericUpDown stepsNud;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button analisBtn;
        private System.Windows.Forms.Button solveBtn;
    }
}

