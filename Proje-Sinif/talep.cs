using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Sinif
{
  public class Talep
    {

        public Talep()
        {
            Random random = new Random();
            int kod = random.Next(100, 1000);
            TalepKod= kod;
        }

   

        public string isim {  get; protected set; }
        public string tcNo { get; protected set; }
        public string telNo { get; protected set; }
        public string Adres { get; protected set; }
        public string UrunKategori { get; protected set; }
        public string UrunIsim { get; protected set; }
        public int UrunAdet { get; protected set; }
        public decimal BirimFiyat { get; protected set; }
        public decimal ToplamFiyat { get; protected set; }
        public int TalepKod { get; private set; }

    }




}
