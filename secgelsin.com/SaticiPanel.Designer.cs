namespace secgelsin.com
{
    partial class SaticiPanel
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
            groupBox1 = new GroupBox();
            btnSatisHesap = new Button();
            cmbUrunisim = new ComboBox();
            lblSatisTalepKontrol = new Label();
            btnSatisTalepGonder = new Button();
            txtUrunBirimFyt = new TextBox();
            txtUrunAdet = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cmbUrunKategori = new ComboBox();
            richTxtSaticiAdres = new RichTextBox();
            label6 = new Label();
            txtSaticiTel = new TextBox();
            txtSaticiTc = new TextBox();
            txtSaticisim = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 46);
            label1.TabIndex = 1;
            label1.Text = "SATICI PANELİ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SandyBrown;
            groupBox1.Controls.Add(btnSatisHesap);
            groupBox1.Controls.Add(cmbUrunisim);
            groupBox1.Controls.Add(lblSatisTalepKontrol);
            groupBox1.Controls.Add(btnSatisTalepGonder);
            groupBox1.Controls.Add(txtUrunBirimFyt);
            groupBox1.Controls.Add(txtUrunAdet);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbUrunKategori);
            groupBox1.Controls.Add(richTxtSaticiAdres);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSaticiTel);
            groupBox1.Controls.Add(txtSaticiTc);
            groupBox1.Controls.Add(txtSaticisim);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 374);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Satış İşlemleri";
            // 
            // btnSatisHesap
            // 
            btnSatisHesap.Location = new Point(597, 154);
            btnSatisHesap.Name = "btnSatisHesap";
            btnSatisHesap.Size = new Size(75, 23);
            btnSatisHesap.TabIndex = 22;
            btnSatisHesap.Text = "Hesapla";
            btnSatisHesap.UseVisualStyleBackColor = true;
            btnSatisHesap.Click += btnSatisHesap_Click;
            // 
            // cmbUrunisim
            // 
            cmbUrunisim.FormattingEnabled = true;
            cmbUrunisim.Location = new Point(459, 85);
            cmbUrunisim.Name = "cmbUrunisim";
            cmbUrunisim.Size = new Size(141, 23);
            cmbUrunisim.TabIndex = 21;
            // 
            // lblSatisTalepKontrol
            // 
            lblSatisTalepKontrol.AutoSize = true;
            lblSatisTalepKontrol.BackColor = Color.Black;
            lblSatisTalepKontrol.ForeColor = Color.Transparent;
            lblSatisTalepKontrol.Location = new Point(698, 158);
            lblSatisTalepKontrol.Name = "lblSatisTalepKontrol";
            lblSatisTalepKontrol.Size = new Size(17, 15);
            lblSatisTalepKontrol.TabIndex = 20;
            lblSatisTalepKontrol.Text = "\"\"";
            // 
            // btnSatisTalepGonder
            // 
            btnSatisTalepGonder.Location = new Point(453, 243);
            btnSatisTalepGonder.Name = "btnSatisTalepGonder";
            btnSatisTalepGonder.Size = new Size(127, 52);
            btnSatisTalepGonder.TabIndex = 19;
            btnSatisTalepGonder.Text = "Satış Talebi Gönder";
            btnSatisTalepGonder.UseVisualStyleBackColor = true;
            btnSatisTalepGonder.Click += btnSatisTalepGonder_Click;
            // 
            // txtUrunBirimFyt
            // 
            txtUrunBirimFyt.Location = new Point(459, 178);
            txtUrunBirimFyt.Name = "txtUrunBirimFyt";
            txtUrunBirimFyt.Size = new Size(121, 23);
            txtUrunBirimFyt.TabIndex = 18;
            // 
            // txtUrunAdet
            // 
            txtUrunAdet.Location = new Point(459, 131);
            txtUrunAdet.Name = "txtUrunAdet";
            txtUrunAdet.Size = new Size(121, 23);
            txtUrunAdet.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(345, 181);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 13;
            label9.Text = "Birim Fiyat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(345, 131);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 12;
            label8.Text = "Adet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 88);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 11;
            label7.Text = "Ürün İsim/Marka";
            // 
            // cmbUrunKategori
            // 
            cmbUrunKategori.FormattingEnabled = true;
            cmbUrunKategori.Location = new Point(459, 36);
            cmbUrunKategori.Name = "cmbUrunKategori";
            cmbUrunKategori.Size = new Size(141, 23);
            cmbUrunKategori.TabIndex = 10;
            cmbUrunKategori.SelectedIndexChanged += cmbUrunKategori_SelectedIndexChanged;
            // 
            // richTxtSaticiAdres
            // 
            richTxtSaticiAdres.Location = new Point(64, 178);
            richTxtSaticiAdres.Name = "richTxtSaticiAdres";
            richTxtSaticiAdres.Size = new Size(229, 75);
            richTxtSaticiAdres.TabIndex = 9;
            richTxtSaticiAdres.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 41);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 8;
            label6.Text = "Ürün Kategorisi";
            // 
            // txtSaticiTel
            // 
            txtSaticiTel.Location = new Point(127, 136);
            txtSaticiTel.MaxLength = 11;
            txtSaticiTel.Name = "txtSaticiTel";
            txtSaticiTel.Size = new Size(119, 23);
            txtSaticiTel.TabIndex = 6;
            // 
            // txtSaticiTc
            // 
            txtSaticiTc.Location = new Point(127, 88);
            txtSaticiTc.MaxLength = 11;
            txtSaticiTc.Name = "txtSaticiTc";
            txtSaticiTc.Size = new Size(119, 23);
            txtSaticiTc.TabIndex = 5;
            // 
            // txtSaticisim
            // 
            txtSaticisim.Location = new Point(127, 41);
            txtSaticisim.Name = "txtSaticisim";
            txtSaticisim.Size = new Size(119, 23);
            txtSaticisim.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 139);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 3;
            label5.Text = "Satıcı Tel No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 181);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "Adres :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 91);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 1;
            label3.Text = "Satıcı Tc/Vergi No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Satıcı İsim :";
            // 
            // SaticiPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(836, 488);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "SaticiPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaticiPanel";
            Load += SaticiPanel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtSaticiTel;
        private TextBox txtSaticiTc;
        private TextBox txtSaticisim;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private RichTextBox richTxtSaticiAdres;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cmbUrunKategori;
        private TextBox txtUrunBirimFyt;
        private TextBox txtUrunAdet;
        private Button btnSatisTalepGonder;
        private ComboBox cmbUrunisim;
        private Label lblSatisTalepKontrol;
        private Button btnSatisHesap;
    }
}