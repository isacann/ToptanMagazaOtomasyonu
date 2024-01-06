namespace secgelsin.com
{
    partial class AdminPanel
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
            btnKulControl = new Button();
            label1 = new Label();
            btnSatisControl = new Button();
            btnSiparisControl = new Button();
            btnStokControl = new Button();
            SuspendLayout();
            // 
            // btnKulControl
            // 
            btnKulControl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnKulControl.Location = new Point(45, 74);
            btnKulControl.Name = "btnKulControl";
            btnKulControl.Size = new Size(288, 123);
            btnKulControl.TabIndex = 2;
            btnKulControl.Text = "Kullanıcı İşlemleri";
            btnKulControl.UseVisualStyleBackColor = true;
            btnKulControl.Click += btnKulControl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(282, 5);
            label1.Name = "label1";
            label1.Size = new Size(281, 46);
            label1.TabIndex = 0;
            label1.Text = "YÖNETİM PANELİ";
            // 
            // btnSatisControl
            // 
            btnSatisControl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSatisControl.Location = new Point(532, 74);
            btnSatisControl.Name = "btnSatisControl";
            btnSatisControl.Size = new Size(288, 123);
            btnSatisControl.TabIndex = 3;
            btnSatisControl.Text = "Satış Talepleri";
            btnSatisControl.UseVisualStyleBackColor = true;
            btnSatisControl.Click += btnSatisControl_Click;
            // 
            // btnSiparisControl
            // 
            btnSiparisControl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisControl.Location = new Point(45, 308);
            btnSiparisControl.Name = "btnSiparisControl";
            btnSiparisControl.Size = new Size(288, 123);
            btnSiparisControl.TabIndex = 4;
            btnSiparisControl.Text = "Sipariş Talepleri";
            btnSiparisControl.UseVisualStyleBackColor = true;
            btnSiparisControl.Click += btnSiparisControl_Click;
            // 
            // btnStokControl
            // 
            btnStokControl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStokControl.Location = new Point(532, 308);
            btnStokControl.Name = "btnStokControl";
            btnStokControl.Size = new Size(288, 123);
            btnStokControl.TabIndex = 5;
            btnStokControl.Text = "Stok Durumu";
            btnStokControl.UseVisualStyleBackColor = true;
            btnStokControl.Click += btnStokControl_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(854, 520);
            Controls.Add(btnStokControl);
            Controls.Add(btnSiparisControl);
            Controls.Add(btnSatisControl);
            Controls.Add(btnKulControl);
            Controls.Add(label1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rdbMusteri;
        private RadioButton rdbSatici;
        private RadioButton rdbAdmin;
        private Button btnKullaniciEkle;
        private Label label3;
        private TextBox txtSifreEkle;
        private Label label2;
        private TextBox txtKadEkle;
        private Label lblKulYazdir;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kuladi;
        private DataGridViewTextBoxColumn sifre;
        private DataGridViewTextBoxColumn kulTuru;
        private Button btnKulControl;
        private Label label1;
        private Button btnSatisControl;
        private Button btnSiparisControl;
        private Button btnStokControl;
    }
}