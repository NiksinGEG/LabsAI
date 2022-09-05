namespace Lab1
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
            this.sizeNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.evalBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tempNud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.alphaNud = new System.Windows.Forms.NumericUpDown();
            this.graphicsBtn = new System.Windows.Forms.Button();
            this.initBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.energyLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stepsNud = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.minTempNud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTempNud)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeNud
            // 
            this.sizeNud.Location = new System.Drawing.Point(161, 53);
            this.sizeNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeNud.Name = "sizeNud";
            this.sizeNud.Size = new System.Drawing.Size(53, 23);
            this.sizeNud.TabIndex = 0;
            this.sizeNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeNud.ValueChanged += new System.EventHandler(this.sizeNud_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задача N ферзей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Размер:";
            // 
            // evalBtn
            // 
            this.evalBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.evalBtn.Location = new System.Drawing.Point(418, 537);
            this.evalBtn.Name = "evalBtn";
            this.evalBtn.Size = new System.Drawing.Size(152, 23);
            this.evalBtn.TabIndex = 3;
            this.evalBtn.Text = "Решить!";
            this.evalBtn.UseVisualStyleBackColor = true;
            this.evalBtn.Click += new System.EventHandler(this.evalBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Начальная температура:";
            // 
            // tempNud
            // 
            this.tempNud.DecimalPlaces = 1;
            this.tempNud.Location = new System.Drawing.Point(161, 82);
            this.tempNud.Name = "tempNud";
            this.tempNud.Size = new System.Drawing.Size(53, 23);
            this.tempNud.TabIndex = 6;
            this.tempNud.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Альфа:";
            // 
            // alphaNud
            // 
            this.alphaNud.DecimalPlaces = 2;
            this.alphaNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alphaNud.Location = new System.Drawing.Point(313, 82);
            this.alphaNud.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alphaNud.Name = "alphaNud";
            this.alphaNud.Size = new System.Drawing.Size(52, 23);
            this.alphaNud.TabIndex = 8;
            this.alphaNud.Value = new decimal(new int[] {
            98,
            0,
            0,
            131072});
            // 
            // graphicsBtn
            // 
            this.graphicsBtn.Location = new System.Drawing.Point(418, 479);
            this.graphicsBtn.Name = "graphicsBtn";
            this.graphicsBtn.Size = new System.Drawing.Size(152, 23);
            this.graphicsBtn.TabIndex = 9;
            this.graphicsBtn.Text = "Графики...";
            this.graphicsBtn.UseVisualStyleBackColor = true;
            // 
            // initBtn
            // 
            this.initBtn.Location = new System.Drawing.Point(418, 508);
            this.initBtn.Name = "initBtn";
            this.initBtn.Size = new System.Drawing.Size(152, 23);
            this.initBtn.TabIndex = 10;
            this.initBtn.Text = "Инициализация";
            this.initBtn.UseVisualStyleBackColor = true;
            this.initBtn.Click += new System.EventHandler(this.initBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Энергия решения:";
            // 
            // energyLbl
            // 
            this.energyLbl.AutoSize = true;
            this.energyLbl.Location = new System.Drawing.Point(334, 113);
            this.energyLbl.Name = "energyLbl";
            this.energyLbl.Size = new System.Drawing.Size(12, 15);
            this.energyLbl.TabIndex = 12;
            this.energyLbl.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во шагов:";
            // 
            // stepsNud
            // 
            this.stepsNud.Location = new System.Drawing.Point(313, 53);
            this.stepsNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepsNud.Name = "stepsNud";
            this.stepsNud.Size = new System.Drawing.Size(52, 23);
            this.stepsNud.TabIndex = 14;
            this.stepsNud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Конечная температура:";
            // 
            // minTempNud
            // 
            this.minTempNud.DecimalPlaces = 1;
            this.minTempNud.Location = new System.Drawing.Point(161, 111);
            this.minTempNud.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.minTempNud.Name = "minTempNud";
            this.minTempNud.Size = new System.Drawing.Size(53, 23);
            this.minTempNud.TabIndex = 16;
            this.minTempNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(592, 572);
            this.Controls.Add(this.minTempNud);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stepsNud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.energyLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.initBtn);
            this.Controls.Add(this.graphicsBtn);
            this.Controls.Add(this.alphaNud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.evalBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeNud);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sizeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTempNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown sizeNud;
        private Label label1;
        private Label label2;
        private Button evalBtn;
        private PictureBox pictureBox1;
        private Label label3;
        private NumericUpDown tempNud;
        private Label label4;
        private NumericUpDown alphaNud;
        private Button graphicsBtn;
        private Button initBtn;
        private Label label5;
        private Label energyLbl;
        private Label label6;
        private NumericUpDown stepsNud;
        private Label label7;
        private NumericUpDown minTempNud;
    }
}