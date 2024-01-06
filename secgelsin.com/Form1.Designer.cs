namespace secgelsin.com
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
            btnAdminGiris = new Button();
            btnSaticiGiris = new Button();
            btnMusteriGiris = new Button();
            btnTalepDurum = new Button();
            SuspendLayout();
            // 
            // btnAdminGiris
            // 
            btnAdminGiris.BackColor = Color.Gray;
            btnAdminGiris.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdminGiris.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdminGiris.ForeColor = Color.Transparent;
            btnAdminGiris.Location = new Point(42, 13);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(215, 182);
            btnAdminGiris.TabIndex = 0;
            btnAdminGiris.Text = "ADMİN GİRİŞ";
            btnAdminGiris.UseVisualStyleBackColor = false;
            btnAdminGiris.Click += btnAdminGiris_Click;
            // 
            // btnSaticiGiris
            // 
            btnSaticiGiris.BackColor = Color.DarkOrange;
            btnSaticiGiris.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaticiGiris.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaticiGiris.ForeColor = Color.Transparent;
            btnSaticiGiris.Location = new Point(622, 13);
            btnSaticiGiris.Name = "btnSaticiGiris";
            btnSaticiGiris.Size = new Size(215, 182);
            btnSaticiGiris.TabIndex = 1;
            btnSaticiGiris.Text = "SATICI GİRİŞ";
            btnSaticiGiris.UseVisualStyleBackColor = false;
            btnSaticiGiris.Click += btnSaticiGiris_Click;
            // 
            // btnMusteriGiris
            // 
            btnMusteriGiris.BackColor = Color.DarkGreen;
            btnMusteriGiris.BackgroundImageLayout = ImageLayout.Zoom;
            btnMusteriGiris.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriGiris.ForeColor = Color.Transparent;
            btnMusteriGiris.Location = new Point(42, 316);
            btnMusteriGiris.Name = "btnMusteriGiris";
            btnMusteriGiris.Size = new Size(228, 182);
            btnMusteriGiris.TabIndex = 2;
            btnMusteriGiris.Text = "MÜŞTERİ GİRİŞ";
            btnMusteriGiris.UseVisualStyleBackColor = false;
            btnMusteriGiris.Click += btnMusteriGiris_Click;
            // 
            // btnTalepDurum
            // 
            btnTalepDurum.BackColor = Color.DarkRed;
            btnTalepDurum.BackgroundImageLayout = ImageLayout.Zoom;
            btnTalepDurum.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnTalepDurum.ForeColor = Color.Transparent;
            btnTalepDurum.Location = new Point(622, 316);
            btnTalepDurum.Name = "btnTalepDurum";
            btnTalepDurum.Size = new Size(215, 182);
            btnTalepDurum.TabIndex = 3;
            btnTalepDurum.Text = "TALEP SORGULA";
            btnTalepDurum.UseVisualStyleBackColor = false;
            btnTalepDurum.Click += btnTalepDurum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            BackgroundImage = Properties.Resources.welcome;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(910, 530);
            Controls.Add(btnTalepDurum);
            Controls.Add(btnMusteriGiris);
            Controls.Add(btnSaticiGiris);
            Controls.Add(btnAdminGiris);
            Name = "Form1";
            Text = "Seç Gelsin";
           
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdminGiris;
        private Button btnSaticiGiris;
        private Button btnMusteriGiris;
        private Button btnTalepDurum;
    }
}