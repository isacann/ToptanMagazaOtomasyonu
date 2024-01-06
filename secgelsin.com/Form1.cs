namespace secgelsin.com
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            AdminGirisForm adminGirisForm = new AdminGirisForm();
            adminGirisForm.ShowDialog();
        }

        private void btnSaticiGiris_Click(object sender, EventArgs e)
        {

            SaticiGirisForm saticiGirisForm = new SaticiGirisForm();
            saticiGirisForm.ShowDialog();

        }

        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
            MusteriGirisForm musteriGirisForm = new MusteriGirisForm();
            musteriGirisForm.ShowDialog();
        }

        private void btnTalepDurum_Click(object sender, EventArgs e)
        {
            TalepSorgula talepSorgula = new TalepSorgula();
            talepSorgula.ShowDialog();
        }

      
    }
}