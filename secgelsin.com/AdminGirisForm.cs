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
    public partial class AdminGirisForm : Form
    {

        public AdminGirisForm()
        {
            InitializeComponent();

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
           kullanici adminGiris = new kullanici(txtAdminKad.Text, txtAdminSifre.Text, "Admin");

            kullanici girisSonucu = KullaniciYonetim.Instance.KullaniciGiris(adminGiris);

            if (girisSonucu != null)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre girdiniz");
            }
           

            

        }


    }
}
