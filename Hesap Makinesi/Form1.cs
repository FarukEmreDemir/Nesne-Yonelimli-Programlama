using System;
using System.Windows.Forms;

namespace ders
{
    public partial class Form1 : Form
    {
        double ilkSayi = 0;
        string islem = "";
        bool ekranTemizlenecek = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void SayiEkle(string sayi)
        {
            if(ekranTemizlenecek)
            {
                txtEkran.Text = "";
                ekranTemizlenecek=false;
            }
            if (txtEkran.Text == "0") txtEkran.Text = "";
            txtEkran.Text += sayi;

        }
        private void IslemSec(string secilenIslem)
        {
            ilkSayi = Convert.ToDouble(txtEkran.Text);
            islem = secilenIslem;
            ekranTemizlenecek = true;
        }

        private void button1_Click(object sender, EventArgs e) { SayiEkle("1"); }
        private void button2_Click(object sender, EventArgs e) { SayiEkle("2"); }
        private void button3_Click(object sender, EventArgs e) { SayiEkle("3"); }
        private void button4_Click(object sender, EventArgs e) { SayiEkle("4"); }
        private void button5_Click(object sender, EventArgs e) { SayiEkle("5"); }
        private void button6_Click(object sender, EventArgs e) { SayiEkle("6"); }
        private void button7_Click(object sender, EventArgs e) { SayiEkle("7"); }
        private void button8_Click(object sender, EventArgs e) { SayiEkle("8"); }
        private void button9_Click(object sender, EventArgs e) { SayiEkle("9"); }
        private void button0_Click(object sender, EventArgs e) { SayiEkle("0"); }
        private void btnTopla_Click(object sender, EventArgs e) { IslemSec("+"); }
        private void btnCikar_Click(object sender, EventArgs e) { IslemSec("-"); }
        private void btnCarp_Click(object sender, EventArgs e) { IslemSec("*"); }
        private void btnBol_Click(object sender, EventArgs e) { IslemSec("/"); }
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(txtEkran.Text);
            double sonuc = 0;

            if (islem == "+") sonuc = ilkSayi + ikinciSayi;
            if (islem == "-") sonuc = ilkSayi - ikinciSayi;
            if (islem == "*") sonuc = ilkSayi * ikinciSayi;
            if (islem == "/") sonuc = ilkSayi / ikinciSayi;

            txtEkran.Text = sonuc.ToString();
            ilkSayi = sonuc;
            islem = "";
            ekranTemizlenecek = true;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
            ilkSayi = 0;
            islem = "";
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text.Length > 0)
            {
                txtEkran.Text = txtEkran.Text.Substring(0, txtEkran.Text.Length - 1);
            }
            if (txtEkran.Text == "")
            {
                txtEkran.Text = "0";
            }
        }
        private void btnNotka_Click(object sender, EventArgs e)
        {
            if(!txtEkran.Text.Contains(","))
            {
                txtEkran.Text += ",";
            }
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtEkran.Text);
            txtEkran.Text = (sayi / 100).ToString();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

   

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        
        

        private void txtEkran_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
