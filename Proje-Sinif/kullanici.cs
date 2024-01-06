using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Sinif
{

   
    public class kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string KullaniciTuru { get; set; }

        public kullanici(string kullaniciadi, string sifre, string kullanicituru) 
        { 
        this.KullaniciAdi = kullaniciadi;
        this.Sifre = sifre;
        this.KullaniciTuru = kullanicituru;
        
        }

    }

    public class KullaniciYonetim

    {
        private static KullaniciYonetim _instance;
        public List<kullanici> kullanicilistesi { get;  set; }
        

        private KullaniciYonetim()
        {
            kullanicilistesi = new List<kullanici>();
            kullanici varsayilanKullanici = new kullanici("admin", "admin", "Admin");
            KullaniciEkle(varsayilanKullanici);

        }

        public static KullaniciYonetim Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KullaniciYonetim();
                return _instance;
            }
        }

        public void KullaniciEkle(kullanici yeniKullanici)
        {
            this.kullanicilistesi.Add(yeniKullanici);
        }

        public void KullaniciSil(kullanici yeniKullanici)
        {
            this.kullanicilistesi.Remove(yeniKullanici);
        }

        public kullanici KullaniciGiris(kullanici girisKullanici)
           
        {
            return this.kullanicilistesi.Find(k => k.KullaniciAdi == girisKullanici.KullaniciAdi && k.Sifre == girisKullanici.Sifre && k.KullaniciTuru==girisKullanici.KullaniciTuru);
        }
    

    }




}
