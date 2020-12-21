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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminKontrol_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text == "admin")
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Tekrar Deneyiniz");
            }
        }

        private void btnNotKontrol_Click(object sender, EventArgs e)
        {
                double not = double.Parse(txtDeger.Text);
                if (not < 0)
                {
                    MessageBox.Show("0'dan küçük değer giremezsiniz");
                }
                else if (not > 100)
                {
                    MessageBox.Show("100'den büyük değer giremezsiniz");
                }
                else
                {
                    MessageBox.Show("Notunuz : " + not);
                }
            
        }

        private void btnTekCiftKontrol_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtDeger.Text);
            if ((sayi % 2) == 1) 
            {
                MessageBox.Show("Sayı Tektir");
            }
            else
            {
                MessageBox.Show("Sayı Çifttir");
            }
        }

        private void btnDegerKontrol_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text.Length == 11)
            {
                MessageBox.Show("Kayıt Onaylandı");
            }
            else
            {
                MessageBox.Show("Tekrar Deneyiniz");
            }
        }
    }
}
