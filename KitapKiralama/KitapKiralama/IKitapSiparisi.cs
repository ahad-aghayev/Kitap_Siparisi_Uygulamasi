using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapKiralama
{
    internal interface IKitapSiparisi
    {
        string Kitap { get; set; }
        int GunSayisi { get; set; }
        bool Indirim { get; set; }
        decimal KitapUcreti { get; set; }
        decimal Fiyat { get; set; }
        decimal Hesapla();
    }
}
