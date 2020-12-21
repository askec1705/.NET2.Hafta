using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapıları
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // adet (int) değişkeni, birimfiyat(int) değişkeni, Toplamtutar(int) değişkeni, ödemenizgerekentutar(double) değişkeni
            // Girilen sayı 20'den küçükse %5 indirim uygula
            // Girilen sayı 20 ile 50 arasında %10 indirim uygula
            // Girilen sayı 50 ile 70 arasında %15 indirim uygula
            // Girilen sayı 70 ile 100 arasında %25 indirim uygula

            // mesajlarda:
            // 1.Adım : "Toplam sipariş adediniz :" adet
            // 1.Adım : "Birim fiyatı :" birimfiyatı 
            // 1.Adım : "Toplam tutar :" toplamTutar
            // 1.Adım : "Yapılan indirim oranı :" indirimOranı
            // 1.Adım : "Ödemeniz gereken tutar :" ToplamTutar
        }
    }
}
