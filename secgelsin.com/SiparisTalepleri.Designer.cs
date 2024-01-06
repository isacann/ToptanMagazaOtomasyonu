namespace secgelsin.com
{
    partial class SiparisTalepleri
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
            btnSiparisRet = new Button();
            btnSiparisKabul = new Button();
            dataGridSiparis = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridSiparis).BeginInit();
            SuspendLayout();
            // 
            // btnSiparisRet
            // 
            btnSiparisRet.BackColor = Color.Red;
            btnSiparisRet.Location = new Point(448, 305);
            btnSiparisRet.Name = "btnSiparisRet";
            btnSiparisRet.Size = new Size(161, 79);
            btnSiparisRet.TabIndex = 6;
            btnSiparisRet.Text = "REDDET";
            btnSiparisRet.UseVisualStyleBackColor = false;
            btnSiparisRet.Click += btnSiparisRet_Click;
            // 
            // btnSiparisKabul
            // 
            btnSiparisKabul.BackColor = Color.Lime;
            btnSiparisKabul.Location = new Point(234, 305);
            btnSiparisKabul.Name = "btnSiparisKabul";
            btnSiparisKabul.Size = new Size(161, 79);
            btnSiparisKabul.TabIndex = 5;
            btnSiparisKabul.Text = "KABUL ET";
            btnSiparisKabul.UseVisualStyleBackColor = false;
            btnSiparisKabul.Click += btnSiparisKabul_Click;
            // 
            // dataGridSiparis
            // 
            dataGridSiparis.BackgroundColor = Color.Silver;
            dataGridSiparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSiparis.Location = new Point(34, 49);
            dataGridSiparis.Name = "dataGridSiparis";
            dataGridSiparis.ReadOnly = true;
            dataGridSiparis.RowTemplate.Height = 25;
            dataGridSiparis.Size = new Size(826, 224);
            dataGridSiparis.TabIndex = 4;
            dataGridSiparis.CellMouseClick += dataGridSiparis_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 9;
            label1.Text = "SİPARİŞ TALEPLERİ";
            // 
            // SiparisTalepleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(872, 450);
            Controls.Add(label1);
            Controls.Add(btnSiparisRet);
            Controls.Add(btnSiparisKabul);
            Controls.Add(dataGridSiparis);
            Name = "SiparisTalepleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SiparisTalepleri";
            Load += SiparisTalepleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSiparis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSiparisRet;
        private Button btnSiparisKabul;
        private DataGridView dataGridSiparis;
        private Label label1;
    }
}