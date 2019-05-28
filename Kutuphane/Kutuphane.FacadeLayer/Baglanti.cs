using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.FacadeLayer
{
    public class Baglanti
    {
        public static readonly SqlConnection Con = new SqlConnection("SERVER=.;DATABASE=Kutuphane;USER ID=sa;PASSWORD=123456");// DIŞARIDAN BAŞKA BİRİ TARAFINDAN DEĞİŞTİRİLEBİLMESİNİ İSTEMEDİĞİM İÇİN READONLY YAPIYORUM.

    }
}
