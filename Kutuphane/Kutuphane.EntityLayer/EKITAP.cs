using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.EntityLayer
{
   public class EKITAP
    {
        private int _ID;
        private string _ADI;
        private string _YAZAR;
        private short _SAYFASAYISI;
        private int _KATEGORIID;
        private DateTime _GMT;
        private string _HOSTNAME;
        private string _KATEGORIADI;

        
        public string ADI { get => _ADI; set => _ADI = value; }
        public string YAZAR { get => _YAZAR; set => _YAZAR = value; }
        public short SAYFASAYISI { get => _SAYFASAYISI; set => _SAYFASAYISI = value; }
        public int KATEGORIID { get => _KATEGORIID; set => _KATEGORIID = value; }

        public DateTime GMT { get => _GMT; set => _GMT = value; }
        public string HOSTNAME { get => _HOSTNAME; set => _HOSTNAME = value; }
        public string KATEGORIADI { get => _KATEGORIADI; set => _KATEGORIADI = value; }
        public int ID { get => _ID; set => _ID = value; }
    }
}
