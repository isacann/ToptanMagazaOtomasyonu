using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Sinif
{

    public class Siparis : Talep
    {
        public int id { get; set; }
        public Siparis(int stokid,string isimm, string tcno, string telno, string adres, string urunkategori,
     string urunisim, int urunadet, decimal birimfiyat, decimal satistoplam)
        {
            this.id = stokid;
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

    public class SiparisTalep
    {
        private static SiparisTalep _instance;
        public List<Siparis> SiparisTalepListesi { get; set; }

        private SiparisTalep()
        {
            this.SiparisTalepListesi = new List<Siparis>();

        }
        public static SiparisTalep Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SiparisTalep();
                return _instance;
            }
        }

        public void SiparisTalepSil(Siparis silinecektalep)
        {
            this.SiparisTalepListesi.Remove(silinecektalep);
        }
    

    }

 
}