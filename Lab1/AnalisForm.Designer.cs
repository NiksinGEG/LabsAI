namespace Lab1
{
    partial class AnalisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startNud1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.finNud1 = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.startNud2 = new System.Windows.Forms.NumericUpDown();
            this.startNud3 = new System.Windows.Forms.NumericUpDown();
            this.startNud4 = new System.Windows.Forms.NumericUpDown();
            this.startNud5 = new System.Windows.Forms.NumericUpDown();
            this.finNud2 = new System.Windows.Forms.NumericUpDown();
            this.finNud3 = new System.Windows.Forms.NumericUpDown();
            this.finNud4 = new System.Windows.Forms.NumericUpDown();
            this.finNud5 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.solveBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.startNud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNud5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная температура:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечная температура:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во шагов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Альфа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Размер:";
            // 
            // startNud1
            // 
            this.startNud1.DecimalPlaces = 1;
            this.startNud1.Location = new System.Drawing.Point(229, 7);
            this.startNud1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startNud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startNud1.Name = "startNud1";
            this.startNud1.Size = new System.Drawing.Size(50, 23);
            this.startNud1.TabIndex = 5;
            this.startNud1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Исх. знач:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Конеч. знач:";
            // 
            // finNud1
            // 
            this.finNud1.DecimalPlaces = 1;
            this.finNud1.Location = new System.Drawing.Point(366, 7);
            this.finNud1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.finNud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.finNud1.Name = "finNud1";
            this.finNud1.Size = new System.Drawing.Size(50, 23);
            this.finNud1.TabIndex = 8;
            this.finNud1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(422, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Изменяемая вел-на";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // startNud2
            // 
            this.startNud2.DecimalPlaces = 1;
            this.startNud2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startNud2.Location = new System.Drawing.Point(229, 36);
            this.startNud2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startNud2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startNud2.Name = "startNud2";
            this.startNud2.Size = new System.Drawing.Size(50, 23);
            this.startNud2.TabIndex = 12;
            this.startNud2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startNud3
            // 
            this.startNud3.Location = new System.Drawing.Point(229, 65);
            this.startNud3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startNud3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNud3.Name = "startNud3";
            this.startNud3.Size = new System.Drawing.Size(50, 23);
            this.startNud3.TabIndex = 13;
            this.startNud3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // startNud4
            // 
            this.startNud4.DecimalPlaces = 2;
            this.startNud4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.startNud4.Location = new System.Drawing.Point(229, 94);
            this.startNud4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNud4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.startNud4.Name = "startNud4";
            this.startNud4.Size = new System.Drawing.Size(50, 23);
            this.startNud4.TabIndex = 14;
            this.startNud4.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            // 
            // startNud5
            // 
            this.startNud5.Location = new System.Drawing.Point(229, 123);
            this.startNud5.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.startNud5.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.startNud5.Name = "startNud5";
            this.startNud5.Size = new System.Drawing.Size(50, 23);
            this.startNud5.TabIndex = 15;
            this.startNud5.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // finNud2
            // 
            this.finNud2.DecimalPlaces = 1;
            this.finNud2.Enabled = false;
            this.finNud2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.finNud2.Location = new System.Drawing.Point(366, 36);
            this.finNud2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.finNud2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.finNud2.Name = "finNud2";
            this.finNud2.Size = new System.Drawing.Size(50, 23);
            this.finNud2.TabIndex = 16;
            this.finNud2.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // finNud3
            // 
            this.finNud3.Enabled = false;
            this.finNud3.Location = new System.Drawing.Point(366, 65);
            this.finNud3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.finNud3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.finNud3.Name = "finNud3";
            this.finNud3.Size = new System.Drawing.Size(50, 23);
            this.finNud3.TabIndex = 17;
            this.finNud3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // finNud4
            // 
            this.finNud4.DecimalPlaces = 2;
            this.finNud4.Enabled = false;
            this.finNud4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.finNud4.Location = new System.Drawing.Point(366, 94);
            this.finNud4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.finNud4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.finNud4.Name = "finNud4";
            this.finNud4.Size = new System.Drawing.Size(50, 23);
            this.finNud4.TabIndex = 18;
            this.finNud4.Value = new decimal(new int[] {
            9,
            0,
            0,
            131072});
            // 
            // finNud5
            // 
            this.finNud5.Enabled = false;
            this.finNud5.Location = new System.Drawing.Point(366, 123);
            this.finNud5.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.finNud5.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.finNud5.Name = "finNud5";
            this.finNud5.Size = new System.Drawing.Size(50, 23);
            this.finNud5.TabIndex = 19;
            this.finNud5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Исх. знач:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Исх. знач:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Исх. знач:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Исх. знач:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(285, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Конеч. знач:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(285, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "Конеч. знач:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(285, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "Конеч. знач:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(285, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 31;
            this.label16.Text = "Конеч. знач:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(422, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 19);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.Text = "Изменяемая вел-на";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(422, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(134, 19);
            this.radioButton3.TabIndex = 37;
            this.radioButton3.Text = "Изменяемая вел-на";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(422, 94);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(134, 19);
            this.radioButton4.TabIndex = 38;
            this.radioButton4.Text = "Изменяемая вел-на";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(422, 123);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(134, 19);
            this.radioButton5.TabIndex = 39;
            this.radioButton5.Text = "Изменяемая вел-на";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(422, 165);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(134, 23);
            this.solveBtn.TabIndex = 40;
            this.solveBtn.Text = "Начать решение";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 217);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 23);
            this.progressBar1.TabIndex = 41;
            // 
            // AnalisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.finNud5);
            this.Controls.Add(this.finNud4);
            this.Controls.Add(this.finNud3);
            this.Controls.Add(this.finNud2);
            this.Controls.Add(this.startNud5);
            this.Controls.Add(this.startNud4);
            this.Controls.Add(this.startNud3);
            this.Controls.Add(this.startNud2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.finNud1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startNud1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnalisForm";
            this.Text = "AnalisForm";
            ((System.ComponentModel.ISupportInitialize)(this.startNud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNud5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finNud5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown startNud1;
        private Label label6;
        private Label label7;
        private NumericUpDown finNud1;
        private RadioButton radioButton1;
        private NumericUpDown startNud2;
        private NumericUpDown startNud3;
        private NumericUpDown startNud4;
        private NumericUpDown startNud5;
        private NumericUpDown finNud2;
        private NumericUpDown finNud3;
        private NumericUpDown finNud4;
        private NumericUpDown finNud5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Button solveBtn;
        private ProgressBar progressBar1;
    }
}