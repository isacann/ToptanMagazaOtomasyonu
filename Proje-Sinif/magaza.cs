using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Sinif
{
   
    public class magaza
    {


        private static magaza _instance; 
        public List <kategori>  kategoriler {  get; set; }

        private magaza()
        {
            kategoriler= new List <kategori>();
        }

        public static magaza Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new magaza();
                return _instance;
            }
        }

        public void KategoriEkle(kategori yenikategori)
        {
            
            kategoriler.Add(yenikategori);
        }
    

    }


    public class kategori
    {
        public string Adi;
        public List<urun> urunler { get; set; }

        public kategori(string kategoriadi)
        {
            this.Adi=kategoriadi;
            urunler= new List<urun>();
            
        }


        public void UrunEkle(string urunadi)
        {
            urun yeniurun = new urun(urunadi);
            urunler.Add(yeniurun);
        }

        public List<urun> UrunleriGetir()
        {
            return urunler;
        }



    }


    public class urun
    {
        public string Adi {  get; set; }

        public urun(string urunadi)
        {
            this.Adi= urunadi;
        }
    }






}



