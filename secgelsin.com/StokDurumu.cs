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
    public partial class StokDurumu : Form
    {
        public StokDurumu()
        {
            InitializeComponent();
        }

        private void StokDurumu_Load(object sender, EventArgs e)
        {
            dataAdminStok.DataSource = Stoklar.Instance.stoklistesi;
        }
    }
}
