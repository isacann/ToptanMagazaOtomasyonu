using Proje_Sinif;

namespace secgelsin.com
{
    public partial class SaticiPanel : Form
    {

        private SatisTalep SatisTalep = SatisTalep.Instance;
        private Satis yeniSatis;

        public SaticiPanel()
        {
            InitializeComponent();
        }

        decimal satistoplam;

        private void btnSatisTalepGonder_Click(object sender, EventArgs e)
        {
            if (txtSaticisim.Text == "" || txtSaticiTc.Text == "" || txtSaticiTel.Text == "" || richTxtSaticiAdres.Text == ""
             || cmbUrunKategori.SelectedIndex < 0 || cmbUrunisim.SelectedIndex < 0 || txtUrunAdet.Text == "" || txtUrunBirimFyt.Text == "")
            {
                MessageBox.Show("lütfen boş alan bırakmayınız");
            }

            else
            {

                string secilenKategori = cmbUrunisim.Text;
                string secilenUrun = cmbUrunKategori.Text;

                satistoplam = (Convert.ToDecimal(txtUrunAdet.Text) * Convert.ToDecimal(txtUrunBirimFyt.Text));

                yeniSatis = new Satis(txtSaticisim.Text, txtSaticiTc.Text, txtSaticiTel.Text, richTxtSaticiAdres.Text,
                    secilenKategori, secilenUrun, Convert.ToUInt16(txtUrunAdet.Text), Convert.ToDecimal(txtUrunBirimFyt.Text), satistoplam);


                SatisTalep.SatisTalepListesi.Add(yeniSatis);

                int kod = yeniSatis.TalepKod;
                TalepTakip.Instance.kodbeklemelistesi.Add(kod);
                MessageBox.Show("Talebiniz gönderildi, talep kodunuz:" + kod);

                txtSaticisim.Clear();
                txtSaticiTc.Clear();
                txtSaticiTel.Clear();
                richTxtSaticiAdres.Clear();
                cmbUrunisim.Text = "";
                cmbUrunKategori.Text = "";
                txtUrunBirimFyt.Clear();
                txtUrunAdet.Clear();
            }

        }

        private void btnSatisHesap_Click(object sender, EventArgs e)
        {
            satistoplam = (Convert.ToDecimal(txtUrunAdet.Text) * Convert.ToDecimal(txtUrunBirimFyt.Text));
            lblSatisTalepKontrol.Text = satistoplam.ToString() + " TL";
        }

        private void SaticiPanel_Load(object sender, EventArgs e)
        {
            cmbUrunKategori.DisplayMember = "Adi";
            magaza.Instance.kategoriler.ForEach(kat => cmbUrunKategori.Items.Add(kat.Adi));
        }

        private void cmbUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            string secilikategori = cmbUrunKategori.SelectedItem.ToString();

            kategori bulunankategori = magaza.Instance.kategoriler.Find(p => p.Adi == secilikategori);

            if (bulunankategori != null)
            {
                cmbUrunisim.Items.Clear();
                cmbUrunisim.DisplayMember = "Adi";
                bulunankategori.urunler.ForEach(u => cmbUrunisim.Items.Add(u.Adi));
            }

        }
    }
}
