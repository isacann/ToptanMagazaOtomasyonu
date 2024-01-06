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
    public partial class SaticiGirisForm : Form
    {
        public SaticiGirisForm()
        {
            InitializeComponent();
        }

        private void btnSaticiLogin_Click(object sender, EventArgs e)
        {
           

           kullanici girisSatici = new kullanici(txtSaticiKad.Text, txtSaticiSifre.Text, "Satıcı");
            kullanici girisSonucu = KullaniciYonetim.Instance.KullaniciGiris(girisSatici);

            if (girisSonucu != null)
            {

                SaticiPanel saticiPanel = new SaticiPanel();
                saticiPanel.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre girdiniz");
            }

         

           

        }

    
    }
}
