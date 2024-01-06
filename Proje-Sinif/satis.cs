using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Sinif
{
    public class Satis:Talep
    {

        public Satis(string isimm, string tcno, string telno, string adres, string urunkategori,
        string urunisim, int urunadet, decimal birimfiyat, decimal satistoplam)
        {
            this.isim = isimm;
            this.tcNo = tcno;
            this.telNo = telno;
            this.Adres = adres;
            this.UrunKategori = urunkategori;
            this.UrunIsim = urunisim;
            this.UrunAdet = urunadet;
            this.BirimFiyat = birimfiyat;
            this.ToplamFiyat = satistoplam;


        }

    }

    public class SatisTalep
    {
        private static SatisTalep _instance;
        public List<Satis> SatisTalepListesi {  get; set; }
        


        private SatisTalep()
        {
            SatisTalepListesi = new List<Satis>();


        }

        public static SatisTalep Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SatisTalep();
                return _instance;
            }
        }

        public void SatisTalepSil (Satis silinecektalep)
        {
            this.SatisTalepListesi.Remove(silinecektalep);
        }



    }




}
