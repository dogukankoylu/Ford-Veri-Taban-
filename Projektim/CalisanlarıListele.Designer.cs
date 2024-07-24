namespace Projektim
{
    partial class CalisanlarıListele
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(425, 24);
            label1.Name = "label1";
            label1.Size = new Size(199, 40);
            label1.TabIndex = 1;
            label1.Text = "ÇALIŞANLAR";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Tan;
            dataGridView1.Location = new Point(55, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(979, 455);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Linen;
            button2.Location = new Point(1023, 12);
            button2.Name = "button2";
            button2.Size = new Size(38, 42);
            button2.TabIndex = 21;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.Linen;
            button3.Location = new Point(374, 528);
            button3.Name = "button3";
            button3.Size = new Size(279, 68);
            button3.TabIndex = 26;
            button3.Text = "Ana Sayfa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // CalisanlarıListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1101, 611);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalisanlarıListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalisanlarıListele";
            Load += CalisanlarıListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
    }
}