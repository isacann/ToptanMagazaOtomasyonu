using Proje_Sinif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secgelsin.com
{
    public partial class TalepSorgula : Form
    {
        public TalepSorgula()
        {
            InitializeComponent();
        }



        private void btnTalepAra_Click(object sender, EventArgs e)
        {
            int girilenkod = Convert.ToInt16(textBox1.Text);

            int bekleyen = TalepTakip.Instance.kodbeklemelistesi.Find(v => v == girilenkod);
            int kabul = TalepTakip.Instance.kodkabullistesi.Find(v => v == girilenkod);
            int ret = TalepTakip.Instance.kodretlistesi.Find(v => v == girilenkod);

            if (kabul == girilenkod)
            {
                MessageBox.Show("Talebiniz Kabul Edilmiştir");


            }
            else if (ret == girilenkod)
            {
                MessageBox.Show("Talebiniz Reddilmiştir");
            }
            else if (bekleyen == girilenkod)
            {
                MessageBox.Show("Talebiniz Değerlendirmede");
            }
            else
            {
                MessageBox.Show("Talep Kodu Bulunamadı");
            }


        }
    }
}
