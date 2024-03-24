using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSProjeDemo1.Uye;

namespace CSProjeDemo1
{
    public interface IUye
    {
        string Ad { get; set; } 
        string Soyad { get; set; } 
        int UyeNumarasi { get; set; }
        List<Kitap> OduncKitaplar { get; set; }

        void OduncAlma(Kitap kitap);
        void OduncVerme(Kitap kitap);
    }
}
