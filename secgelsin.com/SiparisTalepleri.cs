using Proje_Sinif;
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
    public partial class SiparisTalepleri : Form
    {
        public SiparisTalepleri()
        {
            InitializeComponent();
        }

        public int secilenid;
        public int secilentalepkod;

        public void TalepSil()
        {
            Siparis silinecektalep = dataGridSiparis.SelectedRows[0].DataBoundItem as Siparis;
            if (silinecektalep != null)
            {
                SiparisTalep.Instance.SiparisTalepSil(silinecektalep);


                dataGridSiparis.DataSource = null;
                dataGridSiparis.DataSource = SiparisTalep.Instance.SiparisTalepListesi;
            }
        }

        private void SiparisTalepleri_Load(object sender, EventArgs e)
        {
            dataGridSiparis.DataSource = SiparisTalep.Instance.SiparisTalepListesi;
        }

        private void dataGridSiparis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow secilitalep = dataGridSiparis.SelectedRows[0];
            secilenid = Convert.ToInt16(secilitalep.Cells["id"].Value);
            secilentalepkod = Convert.ToInt16(secilitalep.Cells["TalepKod"].Value);
        }

        private void btnSiparisKabul_Click(object sender, EventArgs e)
        {

            if (dataGridSiparis.Rows.Count > 0)
            {

                Stoklar.Instance.stoklistesi.RemoveAll(p => p.s_stokid == secilenid);
                TalepTakip.Instance.Kabulet(secilentalepkod);
                TalepTakip.Instance.BeklemeSil(secilentalepkod);
                TalepSil();

            }

            else
            {
                MessageBox.Show("Ürün Satırı Seçiniz");
            }
        }

        private void btnSiparisRet_Click(object sender, EventArgs e)
        {
            TalepTakip.Instance.Kabulet(secilentalepkod);
            TalepTakip.Instance.BeklemeSil(secilentalepkod);
            TalepSil();
        }
    }
}



