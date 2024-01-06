namespace secgelsin.com
{
    partial class SatisTalepleri
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
            dataGridSatis = new DataGridView();
            btnSatisKabul = new Button();
            btnSatisRet = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridSatis).BeginInit();
            SuspendLayout();
            // 
            // dataGridSatis
            // 
            dataGridSatis.AllowUserToAddRows = false;
            dataGridSatis.AllowUserToDeleteRows = false;
            dataGridSatis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSatis.BackgroundColor = Color.Silver;
            dataGridSatis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSatis.Location = new Point(34, 66);
            dataGridSatis.Name = "dataGridSatis";
            dataGridSatis.ReadOnly = true;
            dataGridSatis.RowTemplate.Height = 25;
            dataGridSatis.Size = new Size(826, 224);
            dataGridSatis.TabIndex = 0;
            dataGridSatis.CellMouseClick += dataGridSatis_CellMouseClick;
            // 
            // btnSatisKabul
            // 
            btnSatisKabul.BackColor = Color.Lime;
            btnSatisKabul.Location = new Point(223, 324);
            btnSatisKabul.Name = "btnSatisKabul";
            btnSatisKabul.Size = new Size(161, 79);
            btnSatisKabul.TabIndex = 1;
            btnSatisKabul.Text = "KABUL ET";
            btnSatisKabul.UseVisualStyleBackColor = false;
            btnSatisKabul.Click += btnSatisKabul_Click;
            // 
            // btnSatisRet
            // 
            btnSatisRet.BackColor = Color.Red;
            btnSatisRet.Location = new Point(462, 324);
            btnSatisRet.Name = "btnSatisRet";
            btnSatisRet.Size = new Size(161, 79);
            btnSatisRet.TabIndex = 2;
            btnSatisRet.Text = "REDDET";
            btnSatisRet.UseVisualStyleBackColor = false;
            btnSatisRet.Click += btnSatisRet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 10;
            label1.Text = "SATIŞ TALEPLERİ";
            // 
            // SatisTalepleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(872, 450);
            Controls.Add(label1);
            Controls.Add(btnSatisRet);
            Controls.Add(btnSatisKabul);
            Controls.Add(dataGridSatis);
            Name = "SatisTalepleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SatisTalepleri";
            Load += SatisTalepleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSatis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridSatis;
        private Button btnSatisKabul;
        private Button btnSatisRet;
        private Label label1;
    }
}