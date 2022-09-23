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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.solveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weightNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.heurNud = new System.Windows.Forms.NumericUpDown();
            this.volatilityNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.iterationsNud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.colonyNud = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.qNud = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.resLbl = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heurNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volatilityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonyNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(526, 166);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(202, 23);
            this.solveBtn.TabIndex = 1;
            this.solveBtn.Text = "Решить!";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вес фермента:";
            // 
            // weightNud
            // 
            this.weightNud.Location = new System.Drawing.Point(666, 10);
            this.weightNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNud.Name = "weightNud";
            this.weightNud.Size = new System.Drawing.Size(62, 20);
            this.weightNud.TabIndex = 5;
            this.weightNud.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Эвристика:";
            // 
            // heurNud
            // 
            this.heurNud.Location = new System.Drawing.Point(666, 36);
            this.heurNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heurNud.Name = "heurNud";
            this.heurNud.Size = new System.Drawing.Size(62, 20);
            this.heurNud.TabIndex = 7;
            this.heurNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // volatilityNud
            // 
            this.volatilityNud.DecimalPlaces = 2;
            this.volatilityNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.volatilityNud.Location = new System.Drawing.Point(666, 62);
            this.volatilityNud.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volatilityNud.Name = "volatilityNud";
            this.volatilityNud.Size = new System.Drawing.Size(62, 20);
            this.volatilityNud.TabIndex = 8;
            this.volatilityNud.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Коэффициент испарения:";
            // 
            // iterationsNud
            // 
            this.iterationsNud.Location = new System.Drawing.Point(666, 88);
            this.iterationsNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.iterationsNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationsNud.Name = "iterationsNud";
            this.iterationsNud.Size = new System.Drawing.Size(62, 20);
            this.iterationsNud.TabIndex = 10;
            this.iterationsNud.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Макс. итераций:";
            // 
            // colonyNud
            // 
            this.colonyNud.Location = new System.Drawing.Point(666, 114);
            this.colonyNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.colonyNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colonyNud.Name = "colonyNud";
            this.colonyNud.Size = new System.Drawing.Size(62, 20);
            this.colonyNud.TabIndex = 12;
            this.colonyNud.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Муравьёв на вершинах:";
            // 
            // qNud
            // 
            this.qNud.Location = new System.Drawing.Point(666, 140);
            this.qNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qNud.Name = "qNud";
            this.qNud.Size = new System.Drawing.Size(62, 20);
            this.qNud.TabIndex = 14;
            this.qNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "\"Сила\" муравьёв (Q):";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(526, 195);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(202, 17);
            this.progressBar.TabIndex = 16;
            // 
            // resLbl
            // 
            this.resLbl.AutoSize = true;
            this.resLbl.Location = new System.Drawing.Point(526, 219);
            this.resLbl.Name = "resLbl";
            this.resLbl.Size = new System.Drawing.Size(41, 13);
            this.resLbl.TabIndex = 17;
            this.resLbl.Text = "asdasd";
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(526, 241);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(774, 271);
            this.mainChart.TabIndex = 18;
            this.mainChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 539);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.resLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qNud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colonyNud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iterationsNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volatilityNud);
            this.Controls.Add(this.heurNud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weightNud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.solveBtn);
            this.Name = "Form1";
            this.Text = "Муравьиный алгоритм";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heurNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volatilityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonyNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown weightNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown heurNud;
        private System.Windows.Forms.NumericUpDown volatilityNud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown iterationsNud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown colonyNud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown qNud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label resLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
    }
}

