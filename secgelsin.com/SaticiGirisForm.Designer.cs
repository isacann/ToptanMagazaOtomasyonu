namespace secgelsin.com
{
    partial class SaticiGirisForm
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
            btnSaticiLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSaticiSifre = new TextBox();
            txtSaticiKad = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 24);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 11;
            label3.Text = "SATICI";
            // 
            // btnSaticiLogin
            // 
            btnSaticiLogin.Location = new Point(114, 206);
            btnSaticiLogin.Name = "btnSaticiLogin";
            btnSaticiLogin.Size = new Size(118, 23);
            btnSaticiLogin.TabIndex = 10;
            btnSaticiLogin.Text = "Giriş Yap";
            btnSaticiLogin.UseVisualStyleBackColor = true;
            btnSaticiLogin.Click += btnSaticiLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 145);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 91);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtSaticiSifre
            // 
            txtSaticiSifre.Location = new Point(132, 142);
            txtSaticiSifre.Name = "txtSaticiSifre";
            txtSaticiSifre.Size = new Size(100, 23);
            txtSaticiSifre.TabIndex = 7;
            // 
            // txtSaticiKad
            // 
            txtSaticiKad.Location = new Point(132, 88);
            txtSaticiKad.Name = "txtSaticiKad";
            txtSaticiKad.Size = new Size(100, 23);
            txtSaticiKad.TabIndex = 6;
            // 
            // SaticiGirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(321, 280);
            Controls.Add(label3);
            Controls.Add(btnSaticiLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSaticiSifre);
            Controls.Add(txtSaticiKad);
            Name = "SaticiGirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaticiGirisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnSaticiLogin;
        private Label label2;
        private Label label1;
        private TextBox txtSaticiSifre;
        private TextBox txtSaticiKad;
    }
}