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
    public partial class MusteriGirisForm : Form
    {
        public MusteriGirisForm()
        {
            InitializeComponent();
        }

        private void btnMusteriLogin_Click(object sender, EventArgs e)
        {
             kullanici girisMusteri = new kullanici(txtMusteriKad.Text,txtMusteriSifre.Text,"Müşteri");
            kullanici girisSonucu = KullaniciYonetim.Instance.KullaniciGiris(girisMusteri);

            if(girisSonucu != null )
            {
                MusteriPanel musteriPanel = new MusteriPanel();
                musteriPanel.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre girdiniz");
            }

            

            
            
        }
    }
}
