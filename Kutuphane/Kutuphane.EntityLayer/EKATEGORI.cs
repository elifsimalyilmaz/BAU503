using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.EntityLayer
{
    public class EKATEGORI:IDisposable // KUTUPHANE ENTİTY LAYER ADINI VERDİĞİMİZ CLASS LİBRARY DLL OLUYOR ASLINDA.
        // DAL I VERDİĞİMİZ KISI ENTITY KISIM OLUYOR.
    {
        private int _ID;
        private string _ADI;

        public int ID { get => _ID; set => _ID = value; } // databaseden değil kendi verdiğimiz değişken(_ıd,_adı)üzerinden bağlanıcaz. katmanlı katmanı bağladoğımız için böyle yapıyoruz.
        public string ADI { get => _ADI; set => _ADI = value; }

        //public override string ToString()// TO STRİNG YAZINCA ADI YAZACAK.
        //{
        //    return this.ADI;
        //}

        public void Dispose()
        {
            GC.SuppressFinalize(this);

        }
    }
}
