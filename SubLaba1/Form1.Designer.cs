namespace SubLaba1
{
    partial class MainForm
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
            this.MainCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.FileChosingBtn = new System.Windows.Forms.Button();
            this.AddTrainBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberComboBox = new System.Windows.Forms.ComboBox();
            this.MaxIterationsNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LearnBtn = new System.Windows.Forms.Button();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AnswerLbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EraseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationsNud)).BeginInit();
            this.SuspendLayout();
            // 
            // MainCanvas
            // 
            this.MainCanvas.BackColor = System.Drawing.Color.White;
            this.MainCanvas.Location = new System.Drawing.Point(12, 12);
            this.MainCanvas.Name = "MainCanvas";
            this.MainCanvas.Size = new System.Drawing.Size(500, 500);
            this.MainCanvas.TabIndex = 0;
            this.MainCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл тренировочных данных:";
            // 
            // FileNameInput
            // 
            this.FileNameInput.Location = new System.Drawing.Point(698, 9);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(169, 23);
            this.FileNameInput.TabIndex = 2;
            // 
            // FileChosingBtn
            // 
            this.FileChosingBtn.Location = new System.Drawing.Point(868, 8);
            this.FileChosingBtn.Name = "FileChosingBtn";
            this.FileChosingBtn.Size = new System.Drawing.Size(46, 24);
            this.FileChosingBtn.TabIndex = 3;
            this.FileChosingBtn.Text = "...";
            this.FileChosingBtn.UseVisualStyleBackColor = true;
            this.FileChosingBtn.Click += new System.EventHandler(this.FileChosingBtn_Click);
            // 
            // AddTrainBtn
            // 
            this.AddTrainBtn.Location = new System.Drawing.Point(260, 518);
            this.AddTrainBtn.Name = "AddTrainBtn";
            this.AddTrainBtn.Size = new System.Drawing.Size(252, 23);
            this.AddTrainBtn.TabIndex = 5;
            this.AddTrainBtn.Text = "Добавить к тренировочным данным";
            this.AddTrainBtn.UseVisualStyleBackColor = true;
            this.AddTrainBtn.Click += new System.EventHandler(this.AddTrainBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цифра:";
            // 
            // NumberComboBox
            // 
            this.NumberComboBox.FormattingEnabled = true;
            this.NumberComboBox.Items.AddRange(new object[] {
            "0",
            "5"});
            this.NumberComboBox.Location = new System.Drawing.Point(134, 519);
            this.NumberComboBox.Name = "NumberComboBox";
            this.NumberComboBox.Size = new System.Drawing.Size(121, 23);
            this.NumberComboBox.TabIndex = 7;
            // 
            // MaxIterationsNud
            // 
            this.MaxIterationsNud.Location = new System.Drawing.Point(649, 57);
            this.MaxIterationsNud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxIterationsNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxIterationsNud.Name = "MaxIterationsNud";
            this.MaxIterationsNud.Size = new System.Drawing.Size(120, 23);
            this.MaxIterationsNud.TabIndex = 8;
            this.MaxIterationsNud.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Максимум итераций:";
            // 
            // LearnBtn
            // 
            this.LearnBtn.Location = new System.Drawing.Point(518, 92);
            this.LearnBtn.Name = "LearnBtn";
            this.LearnBtn.Size = new System.Drawing.Size(174, 23);
            this.LearnBtn.TabIndex = 10;
            this.LearnBtn.Text = "Начать обучение";
            this.LearnBtn.UseVisualStyleBackColor = true;
            this.LearnBtn.Click += new System.EventHandler(this.LearnBtn_Click);
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(698, 92);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(216, 23);
            this.CalcBtn.TabIndex = 11;
            this.CalcBtn.Text = "Получить ответ";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Нейросеть считает что это цифра:";
            // 
            // AnswerLbl
            // 
            this.AnswerLbl.AutoSize = true;
            this.AnswerLbl.Font = new System.Drawing.Font("Segoe UI", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerLbl.Location = new System.Drawing.Point(615, 184);
            this.AnswerLbl.Name = "AnswerLbl";
            this.AnswerLbl.Size = new System.Drawing.Size(202, 265);
            this.AnswerLbl.TabIndex = 13;
            this.AnswerLbl.Text = "?";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(518, 121);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(174, 23);
            this.progressBar.TabIndex = 14;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // EraseBtn
            // 
            this.EraseBtn.Location = new System.Drawing.Point(518, 489);
            this.EraseBtn.Name = "EraseBtn";
            this.EraseBtn.Size = new System.Drawing.Size(75, 23);
            this.EraseBtn.TabIndex = 15;
            this.EraseBtn.Text = "Стереть";
            this.EraseBtn.UseVisualStyleBackColor = true;
            this.EraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 591);
            this.Controls.Add(this.EraseBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.AnswerLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.LearnBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxIterationsNud);
            this.Controls.Add(this.NumberComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTrainBtn);
            this.Controls.Add(this.FileChosingBtn);
            this.Controls.Add(this.FileNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainCanvas);
            this.Name = "MainForm";
            this.Text = "Обучение по Хэббу";
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationsNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox MainCanvas;
        private Label label1;
        private TextBox FileNameInput;
        private Button FileChosingBtn;
        private Button AddTrainBtn;
        private Label label2;
        private ComboBox NumberComboBox;
        private NumericUpDown MaxIterationsNud;
        private Label label3;
        private Button LearnBtn;
        private Button CalcBtn;
        private Label label4;
        private Label AnswerLbl;
        private ProgressBar progressBar;
        private OpenFileDialog openFileDialog;
        private Button EraseBtn;
    }
}