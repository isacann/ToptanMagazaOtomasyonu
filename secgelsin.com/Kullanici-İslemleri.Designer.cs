namespace secgelsin.com
{
    partial class Kullanici_İslemleri
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
            btnKulSil = new Button();
            dataGridKullanici = new DataGridView();
            rdbMusteri = new RadioButton();
            rdbSatici = new RadioButton();
            rdbAdmin = new RadioButton();
            btnKullaniciEkle = new Button();
            label3 = new Label();
            txtSifreEkle = new TextBox();
            label2 = new Label();
            txtKadEkle = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtUrunİsim = new TextBox();
            btnKatEkle = new Button();
            label5 = new Label();
            cmbKatListele = new ComboBox();
            btnUrunEkle = new Button();
            txtKategoriEkle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridKullanici).BeginInit();
            SuspendLayout();
            // 
            // btnKulSil
            // 
            btnKulSil.Location = new Point(12, 387);
            btnKulSil.Name = "btnKulSil";
            btnKulSil.Size = new Size(75, 23);
            btnKulSil.TabIndex = 21;
            btnKulSil.Text = "Sil";
            btnKulSil.UseVisualStyleBackColor = true;
            btnKulSil.Click += btnKulSil_Click;
            // 
            // dataGridKullanici
            // 
            dataGridKullanici.BackgroundColor = Color.Silver;
            dataGridKullanici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridKullanici.Location = new Point(12, 185);
            dataGridKullanici.Name = "dataGridKullanici";
            dataGridKullanici.ReadOnly = true;
            dataGridKullanici.RowTemplate.Height = 25;
            dataGridKullanici.Size = new Size(335, 178);
            dataGridKullanici.TabIndex = 20;
            // 
            // rdbMusteri
            // 
            rdbMusteri.AutoSize = true;
            rdbMusteri.Location = new Point(211, 102);
            rdbMusteri.Name = "rdbMusteri";
            rdbMusteri.Size = new Size(65, 19);
            rdbMusteri.TabIndex = 18;
            rdbMusteri.Text = "Müşteri";
            rdbMusteri.UseVisualStyleBackColor = true;
            // 
            // rdbSatici
            // 
            rdbSatici.AutoSize = true;
            rdbSatici.Checked = true;
            rdbSatici.Location = new Point(113, 102);
            rdbSatici.Name = "rdbSatici";
            rdbSatici.Size = new Size(53, 19);
            rdbSatici.TabIndex = 17;
            rdbSatici.TabStop = true;
            rdbSatici.Text = "Satıcı";
            rdbSatici.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            rdbAdmin.AutoSize = true;
            rdbAdmin.Location = new Point(23, 102);
            rdbAdmin.Name = "rdbAdmin";
            rdbAdmin.Size = new Size(61, 19);
            rdbAdmin.TabIndex = 16;
            rdbAdmin.Text = "Admin";
            rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(23, 144);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(75, 23);
            btnKullaniciEkle.TabIndex = 15;
            btnKullaniciEkle.Text = "ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 61);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 14;
            label3.Text = "Şifre";
            // 
            // txtSifreEkle
            // 
            txtSifreEkle.Location = new Point(113, 58);
            txtSifreEkle.MaxLength = 16;
            txtSifreEkle.Name = "txtSifreEkle";
            txtSifreEkle.Size = new Size(111, 23);
            txtSifreEkle.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 21);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 12;
            label2.Text = "Kullanıcı Adı";
            // 
            // txtKadEkle
            // 
            txtKadEkle.Location = new Point(113, 18);
            txtKadEkle.MaxLength = 16;
            txtKadEkle.Name = "txtKadEkle";
            txtKadEkle.Size = new Size(111, 23);
            txtKadEkle.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 22;
            label1.Text = "Kategori İsmi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 144);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 23;
            label4.Text = "Urun İsmi";
            // 
            // txtUrunİsim
            // 
            txtUrunİsim.Location = new Point(449, 145);
            txtUrunİsim.Name = "txtUrunİsim";
            txtUrunİsim.Size = new Size(135, 23);
            txtUrunİsim.TabIndex = 25;
            // 
            // btnKatEkle
            // 
            btnKatEkle.Location = new Point(449, 57);
            btnKatEkle.Name = "btnKatEkle";
            btnKatEkle.Size = new Size(107, 23);
            btnKatEkle.TabIndex = 26;
            btnKatEkle.Text = "Kategori Ekle";
            btnKatEkle.UseVisualStyleBackColor = true;
            btnKatEkle.Click += btnKatEkle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 102);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 27;
            label5.Text = "Kategori Seç";
            // 
            // cmbKatListele
            // 
            cmbKatListele.FormattingEnabled = true;
            cmbKatListele.Location = new Point(449, 102);
            cmbKatListele.Name = "cmbKatListele";
            cmbKatListele.Size = new Size(135, 23);
            cmbKatListele.TabIndex = 28;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(449, 185);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(108, 23);
            btnUrunEkle.TabIndex = 29;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // txtKategoriEkle
            // 
            txtKategoriEkle.Location = new Point(449, 18);
            txtKategoriEkle.Name = "txtKategoriEkle";
            txtKategoriEkle.Size = new Size(135, 23);
            txtKategoriEkle.TabIndex = 30;
            // 
            // Kullanici_İslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(630, 430);
            Controls.Add(txtKategoriEkle);
            Controls.Add(btnUrunEkle);
            Controls.Add(cmbKatListele);
            Controls.Add(label5);
            Controls.Add(btnKatEkle);
            Controls.Add(txtUrunİsim);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnKulSil);
            Controls.Add(dataGridKullanici);
            Controls.Add(rdbMusteri);
            Controls.Add(rdbSatici);
            Controls.Add(rdbAdmin);
            Controls.Add(btnKullaniciEkle);
            Controls.Add(label3);
            Controls.Add(txtSifreEkle);
            Controls.Add(label2);
            Controls.Add(txtKadEkle);
            Name = "Kullanici_İslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanici_İslemleri";
            Load += Kullanici_İslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridKullanici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKulSil;
        private DataGridView dataGridKullanici;
        private RadioButton rdbMusteri;
        private RadioButton rdbSatici;
        private RadioButton rdbAdmin;
        private Button btnKullaniciEkle;
        private Label label3;
        private TextBox txtSifreEkle;
        private Label label2;
        private TextBox txtKadEkle;
        private Label label1;
        private Label label4;
        private TextBox txtUrunİsim;
        private Button btnKatEkle;
        private Label label5;
        private ComboBox cmbKatListele;
        private Button btnUrunEkle;
        private TextBox txtKategoriEkle;
    }
}