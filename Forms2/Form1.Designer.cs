namespace Forms2
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
            txtYazili1 = new Label();
            txtYazili2 = new Label();
            txtPerformans1 = new Label();
            txtPerformans2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            lblOrtalama = new Label();
            lblDurum = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtYazili1
            // 
            txtYazili1.AutoSize = true;
            txtYazili1.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtYazili1.ForeColor = SystemColors.ControlDarkDark;
            txtYazili1.Location = new Point(42, 202);
            txtYazili1.Name = "txtYazili1";
            txtYazili1.Size = new Size(70, 21);
            txtYazili1.TabIndex = 0;
            txtYazili1.Text = "1.Yazılı";
            txtYazili1.Click += label1_Click;
            // 
            // txtYazili2
            // 
            txtYazili2.AutoSize = true;
            txtYazili2.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtYazili2.ForeColor = SystemColors.ControlDarkDark;
            txtYazili2.Location = new Point(42, 240);
            txtYazili2.Name = "txtYazili2";
            txtYazili2.Size = new Size(70, 21);
            txtYazili2.TabIndex = 1;
            txtYazili2.Text = "2.Yazılı";
            // 
            // txtPerformans1
            // 
            txtPerformans1.AutoSize = true;
            txtPerformans1.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtPerformans1.ForeColor = SystemColors.ControlDarkDark;
            txtPerformans1.Location = new Point(42, 277);
            txtPerformans1.Name = "txtPerformans1";
            txtPerformans1.Size = new Size(125, 21);
            txtPerformans1.TabIndex = 2;
            txtPerformans1.Text = "1.Performans";
            txtPerformans1.Click += label3_Click;
            // 
            // txtPerformans2
            // 
            txtPerformans2.AutoSize = true;
            txtPerformans2.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtPerformans2.ForeColor = SystemColors.ControlDarkDark;
            txtPerformans2.Location = new Point(42, 315);
            txtPerformans2.Name = "txtPerformans2";
            txtPerformans2.Size = new Size(125, 21);
            txtPerformans2.TabIndex = 3;
            txtPerformans2.Text = "2.Performans";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += OnlyAllowNumbers;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += OnlyAllowNumbers;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            textBox3.KeyPress += OnlyAllowNumbers;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            textBox4.KeyPress += OnlyAllowNumbers;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(42, 358);
            button1.Name = "button1";
            button1.Size = new Size(284, 38);
            button1.TabIndex = 8;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblOrtalama.ForeColor = SystemColors.ControlDarkDark;
            lblOrtalama.Location = new Point(420, 193);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(94, 21);
            lblOrtalama.TabIndex = 9;
            lblOrtalama.Text = "Ortalama:";
            lblOrtalama.Click += lblOrtalama_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblDurum.ForeColor = SystemColors.ControlDarkDark;
            lblDurum.Location = new Point(420, 240);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(74, 21);
            lblDurum.TabIndex = 10;
            lblDurum.Text = "Durum:";
            lblDurum.Click += lblDurum_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtYazili1);
            panel1.Controls.Add(lblDurum);
            panel1.Controls.Add(txtYazili2);
            panel1.Controls.Add(lblOrtalama);
            panel1.Controls.Add(txtPerformans1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPerformans2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(0, 1);
            panel1.MinimumSize = new Size(770, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 500);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rendição_d_de_um_homem_que_inclina_se_em_uma_marca_exclamação_vermelha_108618793;
            pictureBox1.Location = new Point(42, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.Location = new Point(106, 100);
            label1.Name = "label1";
            label1.Size = new Size(416, 41);
            label1.TabIndex = 11;
            label1.Text = "Yazılı Ortalaması Hesaplama";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(770, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(770, 500);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label txtYazili1;
        private Label txtYazili2;
        private Label txtPerformans1;
        private Label txtPerformans2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label lblOrtalama;
        private Label lblDurum;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
