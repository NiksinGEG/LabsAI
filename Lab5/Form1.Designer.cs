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
            this.weighsLbl = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rowCountNud = new System.Windows.Forms.NumericUpDown();
            this.colCountNud = new System.Windows.Forms.NumericUpDown();
            this.populationNud = new System.Windows.Forms.NumericUpDown();
            this.crossNud = new System.Windows.Forms.NumericUpDown();
            this.mutationNud = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.maxIterationsNud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsNud)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.White;
            this.mainCanvas.Location = new System.Drawing.Point(12, 12);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(585, 525);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(603, 280);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(75, 23);
            this.solveBtn.TabIndex = 1;
            this.solveBtn.Text = "Решить";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // weighsLbl
            // 
            this.weighsLbl.AutoSize = true;
            this.weighsLbl.Location = new System.Drawing.Point(684, 284);
            this.weighsLbl.Name = "weighsLbl";
            this.weighsLbl.Size = new System.Drawing.Size(120, 15);
            this.weighsLbl.TabIndex = 2;
            this.weighsLbl.Text = "Соприкосновений: ?";
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.Color.White;
            this.plotView1.Location = new System.Drawing.Point(603, 309);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(473, 228);
            this.plotView1.TabIndex = 3;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер популяции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Треугольничков по вертикали:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Треугольничков по горизонтали:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Коэффициент скрещивания:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вероятность мутации:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Макс. итераций без улучшения результата:";
            // 
            // rowCountNud
            // 
            this.rowCountNud.Location = new System.Drawing.Point(799, 10);
            this.rowCountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowCountNud.Name = "rowCountNud";
            this.rowCountNud.Size = new System.Drawing.Size(63, 23);
            this.rowCountNud.TabIndex = 10;
            this.rowCountNud.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // colCountNud
            // 
            this.colCountNud.Location = new System.Drawing.Point(799, 39);
            this.colCountNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colCountNud.Name = "colCountNud";
            this.colCountNud.Size = new System.Drawing.Size(63, 23);
            this.colCountNud.TabIndex = 11;
            this.colCountNud.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // populationNud
            // 
            this.populationNud.Location = new System.Drawing.Point(799, 91);
            this.populationNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.populationNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.populationNud.Name = "populationNud";
            this.populationNud.Size = new System.Drawing.Size(63, 23);
            this.populationNud.TabIndex = 12;
            this.populationNud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // crossNud
            // 
            this.crossNud.DecimalPlaces = 2;
            this.crossNud.Location = new System.Drawing.Point(799, 120);
            this.crossNud.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crossNud.Name = "crossNud";
            this.crossNud.Size = new System.Drawing.Size(63, 23);
            this.crossNud.TabIndex = 13;
            this.crossNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // mutationNud
            // 
            this.mutationNud.Location = new System.Drawing.Point(799, 149);
            this.mutationNud.Name = "mutationNud";
            this.mutationNud.Size = new System.Drawing.Size(63, 23);
            this.mutationNud.TabIndex = 14;
            this.mutationNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(868, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "%";
            // 
            // maxIterationsNud
            // 
            this.maxIterationsNud.Location = new System.Drawing.Point(855, 216);
            this.maxIterationsNud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxIterationsNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxIterationsNud.Name = "maxIterationsNud";
            this.maxIterationsNud.Size = new System.Drawing.Size(66, 23);
            this.maxIterationsNud.TabIndex = 16;
            this.maxIterationsNud.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 549);
            this.Controls.Add(this.maxIterationsNud);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mutationNud);
            this.Controls.Add(this.crossNud);
            this.Controls.Add(this.populationNud);
            this.Controls.Add(this.colCountNud);
            this.Controls.Add(this.rowCountNud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.weighsLbl);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.mainCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox mainCanvas;
        private Button solveBtn;
        private Label weighsLbl;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown rowCountNud;
        private NumericUpDown colCountNud;
        private NumericUpDown populationNud;
        private NumericUpDown crossNud;
        private NumericUpDown mutationNud;
        private Label label7;
        private NumericUpDown maxIterationsNud;
    }
}