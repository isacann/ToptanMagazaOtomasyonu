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
    public partial class SatisTalepleri : Form
    {

        private Stoklar stoklar = Stoklar.Instance;
        private stok yenistok;
        private TalepTakip taleptakip = TalepTakip.Instance;

        public int s_secilentalepkod;
        public string s_urunKategori;
        public string s_urunisim;
        public int s_urunAdet;
        public decimal s_birimFiyat;
        public decimal s_toplamFiyat;
        public void TalepSil()
        {
            Satis silinecektalep = dataGridSatis.SelectedRows[0].DataBoundItem as Satis;
            if (silinecektalep != null)
            {
                SatisTalep.Instance.SatisTalepSil(silinecektalep);


                dataGridSatis.DataSource = null;
                dataGridSatis.DataSource = SatisTalep.Instance.SatisTalepListesi;
            }
        }

        public SatisTalepleri()
        {
            InitializeComponent();
        }

        private void SatisTalepleri_Load(object sender, EventArgs e)
        {
            dataGridSatis.DataSource = SatisTalep.Instance.SatisTalepListesi;
        }

        private void dataGridSatis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow secilitalep = dataGridSatis.SelectedRows[0];
            s_urunKategori = secilitalep.Cells["UrunKategori"].Value.ToString();
            s_urunisim = secilitalep.Cells["UrunIsim"].Value.ToString();
            s_urunAdet = Convert.ToInt32(secilitalep.Cells["UrunAdet"].Value);
            s_birimFiyat = Convert.ToDecimal(secilitalep.Cells["BirimFiyat"].Value);
            s_secilentalepkod = Convert.ToInt16(secilitalep.Cells["TalepKod"].Value);
            s_toplamFiyat = Convert.ToDecimal(secilitalep.Cells["ToplamFiyat"].Value);

        }

        private void btnSatisKabul_Click(object sender, EventArgs e)
        {
            if (dataGridSatis.SelectedRows.Count > 0)
            {

              
                yenistok = new stok(s_urunKategori, s_urunisim, s_urunAdet, s_birimFiyat, s_toplamFiyat);
                stoklar.stoklistesi.Add(yenistok);

                taleptakip.Kabulet(s_secilentalepkod);
                taleptakip.BeklemeSil(s_secilentalepkod);
                TalepSil();
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün satırı seçiniz");
            }

        }

        private void btnSatisRet_Click(object sender, EventArgs e)
        {
            taleptakip.kodretlistesi.Add(s_secilentalepkod);
            TalepSil();
           
        }
       
      
    }
}
