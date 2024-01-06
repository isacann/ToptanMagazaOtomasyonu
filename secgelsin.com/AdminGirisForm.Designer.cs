namespace secgelsin.com
{
    partial class AdminGirisForm
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
            txtAdminKad = new TextBox();
            txtAdminSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAdminLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtAdminKad
            // 
            txtAdminKad.Location = new Point(132, 80);
            txtAdminKad.Name = "txtAdminKad";
            txtAdminKad.Size = new Size(100, 23);
            txtAdminKad.TabIndex = 0;
            // 
            // txtAdminSifre
            // 
            txtAdminSifre.Location = new Point(132, 134);
            txtAdminSifre.Name = "txtAdminSifre";
            txtAdminSifre.Size = new Size(100, 23);
            txtAdminSifre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 83);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 137);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre :";
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Location = new Point(114, 198);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(118, 23);
            btnAdminLogin.TabIndex = 4;
            btnAdminLogin.Text = "Giriş Yap";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 30);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 5;
            label3.Text = "ADMİN";
            // 
            // AdminGirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(321, 280);
            Controls.Add(label3);
            Controls.Add(btnAdminLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdminSifre);
            Controls.Add(txtAdminKad);
            Name = "AdminGirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminGirisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdminKad;
        private TextBox txtAdminSifre;
        private Label label1;
        private Label label2;
        private Button btnAdminLogin;
        private Label label3;
    }
}