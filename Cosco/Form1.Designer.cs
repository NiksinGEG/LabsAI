﻿namespace Cosco
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTb = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.associateBtn1 = new System.Windows.Forms.Button();
            this.associateBtn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eraseBtn2 = new System.Windows.Forms.Button();
            this.eraseBtn1 = new System.Windows.Forms.Button();
            this.learnBtn = new System.Windows.Forms.Button();
            this.addAccosBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(588, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 461);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Файл образов:";
            // 
            // fileNameTb
            // 
            this.fileNameTb.Location = new System.Drawing.Point(537, 6);
            this.fileNameTb.Name = "fileNameTb";
            this.fileNameTb.Size = new System.Drawing.Size(208, 23);
            this.fileNameTb.TabIndex = 4;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(751, 6);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(37, 23);
            this.openFileBtn.TabIndex = 5;
            this.openFileBtn.Text = "...";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // associateBtn1
            // 
            this.associateBtn1.Location = new System.Drawing.Point(147, 416);
            this.associateBtn1.Name = "associateBtn1";
            this.associateBtn1.Size = new System.Drawing.Size(115, 33);
            this.associateBtn1.TabIndex = 7;
            this.associateBtn1.Text = "Ассоциация";
            this.associateBtn1.UseVisualStyleBackColor = true;
            this.associateBtn1.Click += new System.EventHandler(this.associateBtn1_Click);
            // 
            // associateBtn2
            // 
            this.associateBtn2.Location = new System.Drawing.Point(650, 309);
            this.associateBtn2.Name = "associateBtn2";
            this.associateBtn2.Size = new System.Drawing.Size(95, 33);
            this.associateBtn2.TabIndex = 9;
            this.associateBtn2.Text = "Ассоциация";
            this.associateBtn2.UseVisualStyleBackColor = true;
            this.associateBtn2.Click += new System.EventHandler(this.associateBtn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(430, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 133);
            this.label2.TabIndex = 10;
            this.label2.Text = "⇔";
            // 
            // eraseBtn2
            // 
            this.eraseBtn2.Location = new System.Drawing.Point(517, 280);
            this.eraseBtn2.Name = "eraseBtn2";
            this.eraseBtn2.Size = new System.Drawing.Size(65, 23);
            this.eraseBtn2.TabIndex = 11;
            this.eraseBtn2.Text = "Стереть";
            this.eraseBtn2.UseVisualStyleBackColor = true;
            this.eraseBtn2.Click += new System.EventHandler(this.eraseBtn2_Click);
            // 
            // eraseBtn1
            // 
            this.eraseBtn1.Location = new System.Drawing.Point(418, 280);
            this.eraseBtn1.Name = "eraseBtn1";
            this.eraseBtn1.Size = new System.Drawing.Size(65, 23);
            this.eraseBtn1.TabIndex = 12;
            this.eraseBtn1.Text = "Стереть";
            this.eraseBtn1.UseVisualStyleBackColor = true;
            this.eraseBtn1.Click += new System.EventHandler(this.eraseBtn1_Click);
            // 
            // learnBtn
            // 
            this.learnBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learnBtn.Location = new System.Drawing.Point(655, 35);
            this.learnBtn.Name = "learnBtn";
            this.learnBtn.Size = new System.Drawing.Size(133, 34);
            this.learnBtn.TabIndex = 13;
            this.learnBtn.Text = "Обучить";
            this.learnBtn.UseVisualStyleBackColor = true;
            this.learnBtn.Click += new System.EventHandler(this.learnBtn_Click);
            // 
            // addAccosBtn
            // 
            this.addAccosBtn.Location = new System.Drawing.Point(418, 103);
            this.addAccosBtn.Name = "addAccosBtn";
            this.addAccosBtn.Size = new System.Drawing.Size(164, 42);
            this.addAccosBtn.TabIndex = 14;
            this.addAccosBtn.Text = "Добавить ассоциацию";
            this.addAccosBtn.UseVisualStyleBackColor = true;
            this.addAccosBtn.Click += new System.EventHandler(this.addAccosBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.addAccosBtn);
            this.Controls.Add(this.learnBtn);
            this.Controls.Add(this.eraseBtn1);
            this.Controls.Add(this.eraseBtn2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.associateBtn2);
            this.Controls.Add(this.associateBtn1);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.fileNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Splitter splitter1;
        private Label label1;
        private TextBox fileNameTb;
        private Button openFileBtn;
        private OpenFileDialog openFileDialog;
        private Button associateBtn1;
        private Button associateBtn2;
        private Label label2;
        private Button eraseBtn2;
        private Button eraseBtn1;
        private Button learnBtn;
        private Button addAccosBtn;
    }
}