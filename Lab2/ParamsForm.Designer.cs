namespace Lab2
{
    partial class ParamsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betaNud = new System.Windows.Forms.NumericUpDown();
            this.mindfulnessNud = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.headersCb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.separatorCb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.csvFileChooser = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betaNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mindfulnessNud)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mindfulnessNud);
            this.groupBox1.Controls.Add(this.betaNud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры кластеризации:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бета-параметр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Внимательность:";
            // 
            // betaNud
            // 
            this.betaNud.Location = new System.Drawing.Point(107, 14);
            this.betaNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betaNud.Name = "betaNud";
            this.betaNud.Size = new System.Drawing.Size(51, 20);
            this.betaNud.TabIndex = 2;
            this.betaNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mindfulnessNud
            // 
            this.mindfulnessNud.DecimalPlaces = 2;
            this.mindfulnessNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mindfulnessNud.Location = new System.Drawing.Point(107, 40);
            this.mindfulnessNud.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mindfulnessNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mindfulnessNud.Name = "mindfulnessNud";
            this.mindfulnessNud.Size = new System.Drawing.Size(51, 20);
            this.mindfulnessNud.TabIndex = 3;
            this.mindfulnessNud.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.separatorCb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.headersCb);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры импорта:";
            // 
            // headersCb
            // 
            this.headersCb.AutoSize = true;
            this.headersCb.Checked = true;
            this.headersCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.headersCb.Location = new System.Drawing.Point(9, 19);
            this.headersCb.Name = "headersCb";
            this.headersCb.Size = new System.Drawing.Size(124, 17);
            this.headersCb.TabIndex = 0;
            this.headersCb.Text = "Строка заголовков";
            this.headersCb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Разделитель:";
            // 
            // separatorCb
            // 
            this.separatorCb.FormattingEnabled = true;
            this.separatorCb.Items.AddRange(new object[] {
            ",",
            ";",
            ".",
            ":"});
            this.separatorCb.Location = new System.Drawing.Point(88, 45);
            this.separatorCb.Name = "separatorCb";
            this.separatorCb.Size = new System.Drawing.Size(121, 21);
            this.separatorCb.TabIndex = 2;
            this.separatorCb.Text = ",";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Начать кластеризацию по файлу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // csvFileChooser
            // 
            this.csvFileChooser.FileName = "openFileDialog1";
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 212);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParamsForm";
            this.Text = "ParamsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betaNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mindfulnessNud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown mindfulnessNud;
        private System.Windows.Forms.NumericUpDown betaNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox separatorCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox headersCb;
        private System.Windows.Forms.OpenFileDialog csvFileChooser;
    }
}