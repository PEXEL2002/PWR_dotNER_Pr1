﻿namespace App
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 220);
            button1.Name = "button1";
            button1.Size = new Size(188, 34);
            button1.TabIndex = 0;
            button1.Text = "Uruchom";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 31);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 31);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 4;
            label1.Text = "Liczba przedmiotów:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 5;
            label2.Text = "Seed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 6;
            label3.Text = "Pojemność:";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(269, 51);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(494, 203);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 292);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(751, 126);
            textBox5.TabIndex = 8;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 264);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 9;
            label4.Text = "Plecak:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 23);
            label5.Name = "label5";
            label5.Size = new Size(193, 25);
            label5.TabIndex = 10;
            label5.Text = "Przedmioty do wzięcia:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
    }
}
