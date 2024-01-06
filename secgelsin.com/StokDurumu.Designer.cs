namespace secgelsin.com
{
    partial class StokDurumu
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
            dataAdminStok = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataAdminStok).BeginInit();
            SuspendLayout();
            // 
            // dataAdminStok
            // 
            dataAdminStok.BackgroundColor = Color.Silver;
            dataAdminStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAdminStok.Location = new Point(49, 49);
            dataAdminStok.Name = "dataAdminStok";
            dataAdminStok.ReadOnly = true;
            dataAdminStok.RowTemplate.Height = 25;
            dataAdminStok.Size = new Size(674, 289);
            dataAdminStok.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 37);
            label1.TabIndex = 11;
            label1.Text = "STOK DURUMU";
            // 
            // StokDurumu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(763, 450);
            Controls.Add(label1);
            Controls.Add(dataAdminStok);
            Name = "StokDurumu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StokDurumu";
            Load += StokDurumu_Load;
            ((System.ComponentModel.ISupportInitialize)dataAdminStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataAdminStok;
        private Label label1;
    }
}