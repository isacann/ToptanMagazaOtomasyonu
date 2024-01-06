using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secgelsin.com
{
    public partial class AdminPanel : Form
    {

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnKulControl_Click(object sender, EventArgs e)
        {
            Kullanici_İslemleri kullanici_İslemleri = new Kullanici_İslemleri();
            kullanici_İslemleri.ShowDialog();
        }

        private void btnSatisControl_Click(object sender, EventArgs e)
        {
            SatisTalepleri satisTalepleri = new SatisTalepleri();
            satisTalepleri.ShowDialog();
        }

        private void btnSiparisControl_Click(object sender, EventArgs e)
        {
            SiparisTalepleri siparisTalepleri = new SiparisTalepleri();
            siparisTalepleri.ShowDialog();

        }

        private void btnStokControl_Click(object sender, EventArgs e)
        {
            StokDurumu stokDurumu = new StokDurumu();
            stokDurumu.ShowDialog();
        }

    }
}
