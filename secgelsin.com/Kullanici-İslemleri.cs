using Proje_Sinif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secgelsin.com
{

    public partial class Kullanici_İslemleri : Form
    {

        private KullaniciYonetim kullaniciyonet = KullaniciYonetim.Instance;
        private kullanici yenikullanici;
        private magaza magaza = magaza.Instance;

        public Kullanici_İslemleri()
        {
            InitializeComponent();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (txtKadEkle.Text == "" || txtSifreEkle.Text == "")
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
            else
            {

                string secilentur = GetSecilentur(rdbAdmin, rdbMusteri, rdbSatici);

                string GetSecilentur(params RadioButton[] radioButtons)
                {
                    foreach (RadioButton radioButton in radioButtons)
                    {
                        if (radioButton.Checked)
                        {
                            return radioButton.Text;
                        }
                    }
                    return "null";

                }

                yenikullanici = new kullanici(txtKadEkle.Text, txtSifreEkle.Text, secilentur);
                kullaniciyonet.KullaniciEkle(yenikullanici);

                dataGridKullanici.DataSource = null;
                dataGridKullanici.DataSource = kullaniciyonet.kullanicilistesi;

                txtKadEkle.Text = "";
                txtSifreEkle.Text = "";
            }

        }

        private void btnKulSil_Click(object sender, EventArgs e)
        {

            if (dataGridKullanici.SelectedRows.Count > 0)
            {
                kullanici secilikullanici = dataGridKullanici.SelectedRows[0].DataBoundItem as kullanici;

                if (secilikullanici != null)
                {
                    KullaniciYonetim.Instance.KullaniciSil(secilikullanici);


                    dataGridKullanici.DataSource = null;
                    dataGridKullanici.DataSource = kullaniciyonet.kullanicilistesi;
                }

            }
            else
            {
                MessageBox.Show("bir kullanıcı seçiniz");
            }



        }

        private void Kullanici_İslemleri_Load(object sender, EventArgs e)
        {
            dataGridKullanici.DataSource = null;
            dataGridKullanici.DataSource = kullaniciyonet.kullanicilistesi;
            cmbKatListele.DisplayMember = "Adi";
            magaza.kategoriler.ForEach(kat => cmbKatListele.Items.Add(kat.Adi));
        }

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriEkle.Text == "")
            {
                MessageBox.Show("Kategori ismi giriniz");
            }
            else
            {
                string kategoriadi = txtKategoriEkle.Text;
                kategori yenikategori = new kategori(kategoriadi);
                magaza.KategoriEkle(yenikategori);
                cmbKatListele.Items.Clear();
                cmbKatListele.DisplayMember = "Adi";
                magaza.kategoriler.ForEach(kat => cmbKatListele.Items.Add(kat.Adi));

                MessageBox.Show("Kategori başarıyla eklendi");
                txtKategoriEkle.Text = "";
            }
        }


        private void btnUrunEkle_Click(object sender, EventArgs e)

        {
            if (cmbKatListele.SelectedIndex < 0 || txtUrunİsim.Text == "")
            {
                MessageBox.Show("kategori seçiniz ve urun ismi giriniz");
            }

            else
            {
                string secilenKategori = cmbKatListele.SelectedItem.ToString();
                string urunadi = txtUrunİsim.Text;

                kategori bulunankategori = magaza.kategoriler.Find(p => p.Adi == secilenKategori);

                if (bulunankategori != null)
                {
                    bulunankategori.UrunEkle(urunadi);
                }

                MessageBox.Show("Ürün Başarıyla Eklendi");
                txtUrunİsim.Text = "";
            }
        }
    }
}
