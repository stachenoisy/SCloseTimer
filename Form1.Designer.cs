namespace SCloseTimer
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BG3;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(976, 576);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += Form1_MouseDown;
            pictureBox1.MouseMove += Form1_MouseMove;
            pictureBox1.MouseUp += Form1_MouseUp;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(19, 19, 19);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI Variable Display Semib", 45F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(159, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 80);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.WordWrap = false;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(19, 19, 19);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI Variable Display Semib", 45F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(429, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 80);
            textBox2.TabIndex = 2;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.WordWrap = false;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(19, 19, 19);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI Variable Display Semib", 45F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(693, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 80);
            textBox3.TabIndex = 3;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.WordWrap = false;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(19, 19, 19);
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(198, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 37);
            label1.TabIndex = 4;
            label1.Text = "Saat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(19, 19, 19);
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(456, 48);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 5;
            label2.Text = "Dakika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(19, 19, 19);
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(722, 48);
            label3.Name = "label3";
            label3.Size = new Size(97, 37);
            label3.TabIndex = 6;
            label3.Text = "Saniye";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 19, 19);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(429, 288);
            button1.Name = "button1";
            button1.Size = new Size(139, 53);
            button1.TabIndex = 7;
            button1.Text = "Sayacı Başlat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 19, 19);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Small Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(429, 360);
            button2.Name = "button2";
            button2.Size = new Size(139, 53);
            button2.TabIndex = 8;
            button2.Text = "İptal Et";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(19, 19, 19);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Small Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(939, 22);
            button3.Name = "button3";
            button3.Size = new Size(40, 17);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(19, 19, 19);
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(722, 553);
            label4.Name = "label4";
            label4.Size = new Size(262, 31);
            label4.TabIndex = 10;
            label4.Text = "Bu Program Belirtilen Süre Sonrasında Bilgisayarın Kapatılmasına Olanak Tanır.";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            button4.BackColor = Color.Olive;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(19, 19, 19);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sitka Small Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(893, 22);
            button4.Name = "button4";
            button4.Size = new Size(40, 17);
            button4.TabIndex = 11;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1000, 600);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Button button4;
    }
}