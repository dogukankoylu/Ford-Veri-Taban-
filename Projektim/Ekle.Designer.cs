namespace Projektim
{
    partial class Ekle
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
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            calisanekletb = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 145);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 34);
            textBox1.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Linen;
            button2.Location = new Point(1082, 24);
            button2.Name = "button2";
            button2.Size = new Size(38, 42);
            button2.TabIndex = 20;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.Linen;
            button1.Location = new Point(275, 400);
            button1.Name = "button1";
            button1.Size = new Size(279, 68);
            button1.TabIndex = 19;
            button1.Text = "Çalışan Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.Tan;
            label6.Location = new Point(113, 260);
            label6.Name = "label6";
            label6.Size = new Size(75, 29);
            label6.TabIndex = 13;
            label6.Text = "MAAŞ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.Tan;
            label5.Location = new Point(745, 102);
            label5.Name = "label5";
            label5.Size = new Size(141, 29);
            label5.TabIndex = 14;
            label5.Text = "DEPARTMAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Tan;
            label4.Location = new Point(426, 260);
            label4.Name = "label4";
            label4.Size = new Size(116, 29);
            label4.TabIndex = 15;
            label4.Text = "CİNSİYET";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Tan;
            label3.Location = new Point(745, 260);
            label3.Name = "label3";
            label3.Size = new Size(178, 29);
            label3.TabIndex = 16;
            label3.Text = "DOĞUM TARİHİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(432, 102);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 17;
            label2.Text = "SOYİSİM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(113, 102);
            label1.Name = "label1";
            label1.Size = new Size(67, 29);
            label1.TabIndex = 18;
            label1.Text = "İSİM";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(745, 145);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 34);
            textBox2.TabIndex = 11;
            // 
            // calisanekletb
            // 
            calisanekletb.Location = new Point(113, 145);
            calisanekletb.Multiline = true;
            calisanekletb.Name = "calisanekletb";
            calisanekletb.Size = new Size(208, 34);
            calisanekletb.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ERKEK", "KADIN" });
            comboBox1.Location = new Point(417, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 28);
            comboBox1.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(745, 312);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 312);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 34);
            textBox3.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.Linen;
            button3.Location = new Point(634, 400);
            button3.Name = "button3";
            button3.Size = new Size(279, 68);
            button3.TabIndex = 25;
            button3.Text = "Ana Sayfa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1144, 574);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(calisanekletb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox calisanekletb;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Button button3;
    }
}