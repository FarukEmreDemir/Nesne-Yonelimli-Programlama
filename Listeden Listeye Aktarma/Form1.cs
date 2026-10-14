using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Tıklama sırasını kronolojik olarak tutan liste
        List<object> tiklamaSirasi = new List<object>();

        public Form1()
        {
            InitializeComponent();
        }

        // 1. BUTON: 10-500 arası 20 sayı üretir, tekleri küçükten büyüğe, çiftleri büyükten küçüğe sıralar
        private void button1_Click(object sender, EventArgs e)
        {
            // ListBox'ları ve tıklama hafızasını temizle
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            tiklamaSirasi.Clear();

            Random rastgele = new Random();

            List<int> tekSayilar = new List<int>();
            List<int> ciftSayilar = new List<int>();

            // 10 ile 500 arasında (500 dahil) 20 adet rastgele sayı üret
            for (int i = 0; i < 20; i++)
            {
                int sayi = rastgele.Next(10, 501);

                if (sayi % 2 == 0)
                {
                    ciftSayilar.Add(sayi);
                }
                else
                {
                    tekSayilar.Add(sayi);
                }
            }

            // Tek olanları küçükten büyüğe sırala ve listBox2'ye ekle
            tekSayilar.Sort();
            foreach (int tek in tekSayilar)
            {
                listBox2.Items.Add(tek);
            }

            // Çift olanları büyükten küçüğe sırala ve listBox3'e ekle
            ciftSayilar.Sort();      // Küçükten büyüğe sıralar
            ciftSayilar.Reverse();   // Ters çevirerek büyükten küçüğe getirir
            foreach (int cift in ciftSayilar)
            {
                listBox3.Items.Add(cift);
            }
        }

        // 2. BUTON: listBox2 üzerinde tıklanma sırasına göre seçilen elemanları listBox3'e aktarır
        private void button2_Click(object sender, EventArgs e)
        {
            // Tıklanan sıraya göre listBox3'e aktarma
            foreach (var eleman in tiklamaSirasi)
            {
                listBox3.Items.Add(eleman);
            }
        }

        // listBox2'de her eleman tıklandığında veya seçimi kaldırıldığında sırayı günceller
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Yeni seçilen elemanı tıklama sırası listesine ekle
            foreach (var item in listBox2.SelectedItems)
            {
                if (!tiklamaSirasi.Contains(item))
                {
                    tiklamaSirasi.Add(item);
                }
            }

            // Seçimi iptal edilen elemanı listeden çıkar
            for (int i = tiklamaSirasi.Count - 1; i >= 0; i--)
            {
                if (!listBox2.SelectedItems.Contains(tiklamaSirasi[i]))
                {
                    tiklamaSirasi.RemoveAt(i);
                }
            }
        }

        // Tasarım kaynaklı hata vermemesi için boş bırakılan metot
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}