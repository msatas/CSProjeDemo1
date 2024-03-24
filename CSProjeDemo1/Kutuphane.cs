using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSProjeDemo1.Uye;


namespace CSProjeDemo1
{
    public class Kutuphane
    {
        private List<Kitap> kitaplar;
        public List<Kitap> OduncKitaplar;

        public Kutuphane()
        {
            kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }

        public void KitaplariListele()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlinabilir)
            {
                kitap.Durum = Durum.OduncVerildi;
                OduncKitaplar.Add(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı şu anda ödünç alınamaz.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncKitaplar.Contains(kitap))
            {
                kitap.Durum = Durum.OduncAlinabilir;
                OduncKitaplar.Remove(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı iade edildi.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı zaten ödünçte değil.");
            }
        }
    }
}

