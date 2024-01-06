using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Sinif
{

    public class TalepTakip
    {
        private static TalepTakip _instance;

        public List<int> kodbeklemelistesi {  get; set; }
        public List<int> kodkabullistesi { get; set; }
        public List<int> kodretlistesi { get; set; }

        private TalepTakip()
        {
            kodkabullistesi = new List<int>();
            kodretlistesi = new List<int>();
            kodbeklemelistesi = new List<int>();
        }

        public void Kabulet(int kod)
        {
            kodkabullistesi.Add(kod);
        }

        public void Reddet(int kod)
        {
            kodretlistesi.Add(kod);
        }
        public void BeklemeSil(int kod)
        {
            kodbeklemelistesi.Remove(kod);
        }
        public static TalepTakip Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TalepTakip();
                return _instance;
            }


        }

        


    }
}
