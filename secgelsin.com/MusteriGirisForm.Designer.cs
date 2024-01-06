namespace secgelsin.com
{
    partial class MusteriGirisForm
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
            label3 = new Label();
            btnMusteriLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtMusteriSifre = new TextBox();
            txtMusteriKad = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(107, 30);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 17;
            label3.Text = "MÜŞTERİ";
            // 
            // btnMusteriLogin
            // 
            btnMusteriLogin.Location = new Point(120, 213);
            btnMusteriLogin.Name = "btnMusteriLogin";
            btnMusteriLogin.Size = new Size(118, 23);
            btnMusteriLogin.TabIndex = 16;
            btnMusteriLogin.Text = "Giriş Yap";
            btnMusteriLogin.UseVisualStyleBackColor = true;
            btnMusteriLogin.Click += btnMusteriLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 152);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 15;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 98);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 14;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtMusteriSifre
            // 
            txtMusteriSifre.Location = new Point(138, 149);
            txtMusteriSifre.Name = "txtMusteriSifre";
            txtMusteriSifre.Size = new Size(100, 23);
            txtMusteriSifre.TabIndex = 13;
            // 
            // txtMusteriKad
            // 
            txtMusteriKad.Location = new Point(138, 95);
            txtMusteriKad.Name = "txtMusteriKad";
            txtMusteriKad.Size = new Size(100, 23);
            txtMusteriKad.TabIndex = 12;
            // 
            // MusteriGirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(321, 280);
            Controls.Add(label3);
            Controls.Add(btnMusteriLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMusteriSifre);
            Controls.Add(txtMusteriKad);
            ForeColor = Color.Black;
            Name = "MusteriGirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusteriGirisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnMusteriLogin;
        private Label label2;
        private Label label1;
        private TextBox txtMusteriSifre;
        private TextBox txtMusteriKad;
    }
}