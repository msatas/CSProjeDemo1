using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncKitaplar { get; set; }

        public Uye()
        {
            OduncKitaplar = new List<Kitap>();
        }

        public void OduncAlma(Kitap kitap)
        {
            OduncKitaplar.Add(kitap);
        }

        public void OduncVerme(Kitap kitap)
        {
            OduncKitaplar.Remove(kitap);
        }
    }
}
