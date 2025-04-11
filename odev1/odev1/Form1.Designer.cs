namespace odev1
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // button1
            // 
            button1.Location = new Point(84, 332);
            button1.Name = "button1";
            button1.Size = new Size(167, 29);
            button1.TabIndex = 1;
            button1.Text = "Bilgileri Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 83);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 128);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Renk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 177);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 5;
            label4.Text = "Kapı Sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 227);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 6;
            label5.Text = "Pencere Sayısı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 269);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 7;
            label6.Text = "Yakıt";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 224);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(170, 270);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 391);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}
