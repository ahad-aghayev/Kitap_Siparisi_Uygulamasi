using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKitap.Items.Add("Fareler ve İnsanlar John Steinbeck :Günlük Fiyatı: 50 Tl");
            cmbKitap.Items.Add("Gece Yarısı Kütüphanesi Matt Haig: Günlük Fiyatı: 60 Tl");
            cmbKitap.Items.Add("Beyaz Zambaklar Ülkesinde Grigory Petrov: Günlük Fiyatı: 55 Tl");
            cmbKitap.Items.Add("Yıldız Yaralanması Perihan Mağden: Günlük Fiyatı: 45 Tl");
            cmbKitap.Items.Add("Puslu Kıtalar Atlası İhsan Oktay Anar: Günlük Fiyatı: 70 Tl");
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            KitapKiralama kitapKiralama = new KitapKiralama();
            kitapKiralama.GunSayisi = int.Parse(txtGunSayi.Text);
            kitapKiralama.Kitap = cmbKitap.Text;
            kitapKiralama.Indirim = checkBxIndirim.Checked;
            decimal Fiyat = kitapKiralama.Hesapla();
            if (kitapKiralama.GunSayisi >= 22)
            {
                MessageBox.Show("En Fazla 21 gün kiralanabilir ");
            }
            else
                MessageBox.Show("Fiyat Tutarı: " + Fiyat +
                    " \nSeçilen Kitap :" + kitapKiralama.Kitap +
                    " \nKiralanacak Gün Sayısı: " + kitapKiralama.GunSayisi + " Gün");

        }
    }
}
