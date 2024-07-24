namespace Projektim
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1324, 627);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(186, 12);
            button1.Name = "button1";
            button1.Size = new Size(156, 43);
            button1.TabIndex = 1;
            button1.Text = "Çalışan Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(378, 12);
            button2.Name = "button2";
            button2.Size = new Size(188, 43);
            button2.TabIndex = 1;
            button2.Text = "Çalışan Çıkar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(593, 12);
            button3.Name = "button3";
            button3.Size = new Size(205, 43);
            button3.TabIndex = 1;
            button3.Text = "Çalışanları Listele";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(821, 12);
            button4.Name = "button4";
            button4.Size = new Size(248, 43);
            button4.TabIndex = 1;
            button4.Text = "Toplam Maaşı Hesapla";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Tan;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1250, 12);
            button5.Name = "button5";
            button5.Size = new Size(62, 43);
            button5.TabIndex = 1;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 627);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}