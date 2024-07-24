namespace Projektim
{
    partial class MaasHesaplama
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
            comboBox1 = new ComboBox();
            button3 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Yazılım", "IK", "Finans", "Tümü" });
            comboBox1.Location = new Point(22, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 28);
            comboBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.Linen;
            button3.Location = new Point(12, 204);
            button3.Name = "button3";
            button3.Size = new Size(233, 52);
            button3.TabIndex = 27;
            button3.Text = "Toplam Maaşı Göster";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(907, 433);
            dataGridView1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.Tan;
            label5.Location = new Point(22, 77);
            label5.Name = "label5";
            label5.Size = new Size(180, 29);
            label5.TabIndex = 30;
            label5.Text = "DEPARTMANLAR";
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Linen;
            button2.Location = new Point(1169, 2);
            button2.Name = "button2";
            button2.Size = new Size(38, 42);
            button2.TabIndex = 31;
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
            button1.Location = new Point(12, 393);
            button1.Name = "button1";
            button1.Size = new Size(233, 52);
            button1.TabIndex = 32;
            button1.Text = "Ana Sayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MaasHesaplama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1219, 543);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MaasHesaplama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaasHesaplama";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}