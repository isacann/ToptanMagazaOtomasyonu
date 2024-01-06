using Proje_Sinif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secgelsin.com
{
    public partial class MusteriPanel : Form
    {

        private static SiparisTalep siparisTalep = SiparisTalep.Instance;
        private Siparis yeniSiparis;

        public int secilenid;
        public int girilenurunadet;
        public string secilenkategori;
        public string secilenisim;
        public decimal secilenbirimfyt;
        public int secilenurunadet;
        public decimal secilentoplamfyt;
        public MusteriPanel()
        {
            InitializeComponent();
        }

        private void MusteriPanel_Load(object sender, EventArgs e)
        {
            dataMusteriStok.DataSource = Stoklar.Instance.stoklistesi;
        }

        private void dataMusteriStok_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow secilenurun = dataMusteriStok.SelectedRows[0];
            secilenkategori = secilenurun.Cells["s_UrunKategori"].Value.ToString();
            secilenisim = secilenurun.Cells["s_Urunismi"].Value.ToString();
            secilenbirimfyt = Convert.ToDecimal(secilenurun.Cells["s_BirimFiyat"].Value);
            secilenurunadet = Convert.ToInt16(secilenurun.Cells["s_UrunAdet"].Value);
            secilentoplamfyt = Convert.ToDecimal(secilenurun.Cells["s_ToplamFiyat"].Value);
            secilenid = Convert.ToInt16(secilenurun.Cells["s_stokid"].Value);

        }

        public void btnSiparisTalep_Click(object sender, EventArgs e)
        {
            if (dataMusteriStok.SelectedRows.Count == 0)
            {
                MessageBox.Show("soktan bir ürün seçiniz");
            }

            else if (txtAliciİsim.Text == "" || txtAliciTc.Text == "" || txtAliciTel.Text == "" || richTxtAliciAdres.Text == "")

            {

                MessageBox.Show("lütfen boş alan bırakmayınız");

            }


            else
            {
                yeniSiparis = new Siparis(secilenid, txtAliciİsim.Text, txtAliciTc.Text, txtAliciTel.Text,
                 richTxtAliciAdres.Text, secilenkategori, secilenisim, secilenurunadet,
                 secilenbirimfyt, secilentoplamfyt);
               

                siparisTalep.SiparisTalepListesi.Add(yeniSiparis);
                int kod = yeniSiparis.TalepKod;
                TalepTakip.Instance.kodbeklemelistesi.Add(kod);
                MessageBox.Show("Sipariş talebiniz gönderildi talep kodunuz:" + kod);

                txtAliciTc.Text = "";
                txtAliciTel.Text = "";
                txtAliciİsim.Text = "";
                richTxtAliciAdres.Text = "";

            }



        }



    }
}

