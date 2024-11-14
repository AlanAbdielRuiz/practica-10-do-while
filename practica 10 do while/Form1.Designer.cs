namespace practica_10_do_while
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 24);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 0;
            label1.Text = "z= x²+x³";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 97);
            label2.Name = "label2";
            label2.Size = new Size(26, 32);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 97);
            label3.Name = "label3";
            label3.Size = new Size(36, 32);
            label3.TabIndex = 2;
            label3.Text = "x²";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(472, 97);
            label4.Name = "label4";
            label4.Size = new Size(36, 32);
            label4.TabIndex = 3;
            label4.Text = "x³";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(646, 97);
            label5.Name = "label5";
            label5.Size = new Size(26, 32);
            label5.TabIndex = 4;
            label5.Text = "z";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 128, 0);
            listBox1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(79, 150);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 191);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(255, 128, 0);
            listBox2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(256, 150);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 191);
            listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(255, 128, 0);
            listBox3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 17;
            listBox3.Location = new Point(429, 150);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 191);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.FromArgb(255, 128, 0);
            listBox4.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 17;
            listBox4.Location = new Point(612, 150);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 191);
            listBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 64, 0);
            button1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(342, 366);
            button1.Name = "button1";
            button1.Size = new Size(123, 60);
            button1.TabIndex = 9;
            button1.Text = "calcular valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "calcular ecuacion 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button1;
    }
}
