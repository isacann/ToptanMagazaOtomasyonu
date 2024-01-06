namespace secgelsin.com
{
    partial class MusteriPanel
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnSiparisTalep = new Button();
            richTxtAliciAdres = new RichTextBox();
            txtAliciTel = new TextBox();
            txtAliciTc = new TextBox();
            txtAliciİsim = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            dataMusteriStok = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMusteriStok).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 2);
            label1.Name = "label1";
            label1.Size = new Size(270, 46);
            label1.TabIndex = 2;
            label1.Text = "MÜŞTERİ PANELİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 28);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 4;
            label2.Text = "STOK DURUMU";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LimeGreen;
            groupBox1.Controls.Add(btnSiparisTalep);
            groupBox1.Controls.Add(richTxtAliciAdres);
            groupBox1.Controls.Add(txtAliciTel);
            groupBox1.Controls.Add(txtAliciTc);
            groupBox1.Controls.Add(txtAliciİsim);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(64, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(718, 240);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sipariş İşlemleri";
            // 
            // btnSiparisTalep
            // 
            btnSiparisTalep.Location = new Point(433, 74);
            btnSiparisTalep.Name = "btnSiparisTalep";
            btnSiparisTalep.Size = new Size(146, 48);
            btnSiparisTalep.TabIndex = 26;
            btnSiparisTalep.Text = "Sipariş Talebi Gönder";
            btnSiparisTalep.UseVisualStyleBackColor = true;
            btnSiparisTalep.Click += btnSiparisTalep_Click;
            // 
            // richTxtAliciAdres
            // 
            richTxtAliciAdres.Location = new Point(81, 164);
            richTxtAliciAdres.Name = "richTxtAliciAdres";
            richTxtAliciAdres.Size = new Size(227, 63);
            richTxtAliciAdres.TabIndex = 17;
            richTxtAliciAdres.Text = "";
            // 
            // txtAliciTel
            // 
            txtAliciTel.Location = new Point(144, 122);
            txtAliciTel.MaxLength = 11;
            txtAliciTel.Name = "txtAliciTel";
            txtAliciTel.Size = new Size(119, 23);
            txtAliciTel.TabIndex = 16;
            // 
            // txtAliciTc
            // 
            txtAliciTc.Location = new Point(144, 74);
            txtAliciTc.MaxLength = 11;
            txtAliciTc.Name = "txtAliciTc";
            txtAliciTc.Size = new Size(119, 23);
            txtAliciTc.TabIndex = 15;
            // 
            // txtAliciİsim
            // 
            txtAliciİsim.Location = new Point(144, 27);
            txtAliciİsim.Name = "txtAliciİsim";
            txtAliciİsim.Size = new Size(119, 23);
            txtAliciİsim.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 125);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 13;
            label5.Text = "Alıcı Tel No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 167);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Adres :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 77);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 11;
            label3.Text = "Alıcı Tc/Vergi No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 30);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 10;
            label6.Text = "Alıcı İsim :";
            // 
            // dataMusteriStok
            // 
            dataMusteriStok.BackgroundColor = Color.Silver;
            dataMusteriStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMusteriStok.Location = new Point(64, 51);
            dataMusteriStok.Name = "dataMusteriStok";
            dataMusteriStok.ReadOnly = true;
            dataMusteriStok.RowTemplate.Height = 25;
            dataMusteriStok.Size = new Size(718, 188);
            dataMusteriStok.TabIndex = 3;
            dataMusteriStok.CellMouseClick += dataMusteriStok_CellMouseClick;
            // 
            // MusteriPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(836, 500);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dataMusteriStok);
            Controls.Add(label1);
            Name = "MusteriPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusteriPanel";
            Load += MusteriPanel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataMusteriStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RichTextBox richTxtAliciAdres;
        private TextBox txtAliciTel;
        private TextBox txtAliciTc;
        private TextBox txtAliciİsim;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Button btnMusStokListele;
        private Button btnSiparisTalep;
        public DataGridView dataMusteriStok;
    }
}