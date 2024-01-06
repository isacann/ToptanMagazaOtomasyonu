using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Sinif
{
    public class stok
    {
        private static int idsayac = 0;


        public int s_stokid {  get; private set; }
        public string s_UrunKategori { get; set; }
        public string s_Urunismi { get; set; }
        public int s_UrunAdet { get; set; }
        public decimal s_BirimFiyat { get; set; }
        public decimal s_ToplamFiyat { get; set; }

        public stok(string urunkategori, string urunismi, int urunadet, decimal birimfiyat, decimal toplamFiyat)
        {
            this.s_stokid = idsayac++;
            this.s_UrunKategori = urunkategori;
            this.s_Urunismi = urunismi;
            this.s_UrunAdet = urunadet;
            this.s_BirimFiyat = birimfiyat;
            this.s_ToplamFiyat = toplamFiyat;

        }

    }

    public class Stoklar
    {
        private static Stoklar _instance;
        public List<stok> stoklistesi { get; set; }

        private Stoklar()
        {
            stoklistesi= new List<stok>();
        }
        public static Stoklar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Stoklar();
                return _instance;
            }
        }

        public void StokSil(stok yenistok)
        {
            stoklistesi.Remove(yenistok);
        }


    }

}
