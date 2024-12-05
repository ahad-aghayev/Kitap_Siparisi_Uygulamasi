using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapKiralama
{
    internal class KitapKiralama : IKitapSiparisi
    {
        public int GunSayisi { get; set; }
        public decimal KitapUcreti { get; set; }
        public decimal Fiyat { get; set; }
        public string Kitap { get; set; }
        public bool Indirim { get; set; }

        public decimal Hesapla()
        {
            try
            {
                //Kitap Ücreti alınacak
                if (Kitap == "Fareler ve İnsanlar John Steinbeck :Günlük Fiyatı: 50 Tl")
                {
                    KitapUcreti = 50;
                }
                else if (Kitap == "Gece Yarısı Kütüphanesi Matt Haig: Günlük Fiyatı: 60 Tl")
                {
                    KitapUcreti = 60;
                }
                else if (Kitap == "Beyaz Zambaklar Ülkesinde Grigory Petrov: Günlük Fiyatı: 55 Tl")
                {
                    KitapUcreti = 55;
                }
                else if (Kitap == "Yıldız Yaralanması Perihan Mağden: Günlük Fiyatı: 45 Tl")
                {
                    KitapUcreti = 45;
                }
                else if (Kitap == "Puslu Kıtalar Atlası İhsan Oktay Anar: Günlük Fiyatı: 70 Tl")
                {
                    KitapUcreti = 70;
                }
                if (Indirim)
                {
                    return Fiyat = KitapUcreti * GunSayisi * 0.9m; ;
                }
                else
                {
                    return Fiyat = KitapUcreti * GunSayisi;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" Üzügünüz hata oluştu: " + ex.Message);
            }
        }
    }
}
