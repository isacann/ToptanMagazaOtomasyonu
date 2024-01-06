namespace secgelsin.com
{
    partial class TalepSorgula
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
            groupBox1 = new GroupBox();
            btnTalepAra = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(btnTalepAra);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(87, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sorgula";
            // 
            // btnTalepAra
            // 
            btnTalepAra.Location = new Point(205, 136);
            btnTalepAra.Name = "btnTalepAra";
            btnTalepAra.Size = new Size(153, 49);
            btnTalepAra.TabIndex = 2;
            btnTalepAra.Text = "Sorgula";
            btnTalepAra.UseVisualStyleBackColor = true;
            btnTalepAra.Click += btnTalepAra_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 74);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 34);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 77);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 0;
            label1.Text = "TALEP KODU";
            // 
            // TalepSorgula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(738, 407);
            Controls.Add(groupBox1);
            Name = "TalepSorgula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TalepSorgula";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTalepAra;
        private TextBox textBox1;
        private Label label1;
    }
}