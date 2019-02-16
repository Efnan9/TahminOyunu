using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahminOyunu
{
    public partial class TahmınEttır : Form
    {
        public TahmınEttır()
        {
            InitializeComponent();
        }
        public class Num // global random sayıyı tutan class
        {
            public static int GlobalNum;
            public static bool BesUret = false; // 1,2,3,4,0 rakamlarının içerdiğini göstermek amaçlı
            public static bool BırUret = false; // 0-10 arasındaki rakamları içerdiğini göstermek amaçlı

        }
        public bool DigitKontrol(int num) // Rakamları farklı olup olmamasını basamaklara ayıp kontrol etme
        {

            int denemeNum = num;
            int binler = denemeNum / 1000;
            denemeNum = denemeNum - (binler * 1000);
            int yuzler = denemeNum / 100;
            denemeNum = denemeNum - (yuzler * 100);
            int onlar = denemeNum / 10;
            denemeNum = denemeNum - (onlar * 10);
            int birler = denemeNum;
            if ((binler == yuzler || binler == onlar || binler == birler) || (yuzler == onlar || yuzler == birler) || (onlar == birler))
                return false;
            else
                return true;
        }

        private void Basla_Click(object sender, EventArgs e) // Oyun başlayınca 1,2,3,4 rakamlarının olup olmamasını test etme
        {
            lblRakam.Visible = true;
            lblRakam.Text = "1234";
            btnDogru.Visible = true;
            lblAynı.Visible = true;
            lblFarklı.Visible = true;
            txtAynı.Visible = true;
            txtFarklı.Visible = true;
            Tekrar.Visible = true;


        }
        public void RandomBesUret() // Rakamları sadece 5 ile 9 arasında olan sayı türetme
        {
            Random randnum = new Random();
            bool check = false;
            do
            {
                int bas1 = randnum.Next(5, 10);
                int bas2 = randnum.Next(0, 10);
                int bas3 = randnum.Next(0, 10);
                int bas4 = randnum.Next(0, 10);
                if ((bas2 >= 5 || bas2 == 0) && (bas3 >= 5 || bas3 == 0) && (bas4 >= 5 || bas4 == 0)) 
                 {  
                    //Binler basamağı hariç hepsi 0 olabilir ve 5 dende büyük olmaları gerekir.
                    int randSayı = bas1 * 1000 + bas2 * 100 + bas3 * 10 + bas4;
                    check = DigitKontrol(randSayı); // Rakamların farklı olup olmamasını kontrol etme
                    if (check == true)
                    {
                        Num.GlobalNum = randSayı;
                        break;
                    }
                }

            } while (check != true);
            Num.BesUret = true; // Rakamları 5 ile 9 arasında olan sayı üretildiğini göstermek için bool 
            lblRakam.Text = Num.GlobalNum.ToString(); // Yeni oluşan sayı forma yazıldı
        }
        public void RandomBırUret() // Rakamları 1 ile 10 arasında olan sayı üretildi
        {
            Random randnum = new Random();
            bool check=false;
            int bas1 = 1;
            do
            {
                bas1 = randnum.Next(0, 10);
                int bas2 = randnum.Next(0, 10);
                int bas3 = randnum.Next(0, 10);
                int bas4 = randnum.Next(0, 10);
               
                    if (bas1 != 0) // Binler basamağı 0 olamaz.
                    {

                        int randSayı = bas1 * 1000 + bas2 * 100 + bas3 * 10 + bas4;
                        check = DigitKontrol(randSayı); // Rakamların farklı olup olmamasını kontrol etme
                        if (check == true)
                        {
                            Num.GlobalNum = randSayı;
                            break;
                        }
                    }
            } while (check != true || bas1 == 0);
            Num.BırUret = true; // Rakamları 0 ile 4 arasında olan sayı üretildiğini göstermek için bool 
            lblRakam.Text = Num.GlobalNum.ToString(); // Yeni oluşan sayı forma yazıldı
        }


        private void btnDogru_Click(object sender, EventArgs e) // Yazılım doğru bilirse ana menüye dön oyun bitti
        {
            Form1 goster = new Form1();
            goster.ShowDialog();
        }

        private void Tekrar_Click(object sender, EventArgs e)
        {
            int aynı;
            int farklı;
            if (int.TryParse(txtAynı.Text, out aynı) && txtAynı.Text != "" && txtFarklı.Text != "" && (int.TryParse(txtFarklı.Text, out farklı)))  // Boş değilse ya da rakam girdilerse
            {
                farklı = farklı * -1; 
                if (aynı < 0 || aynı > 3 || farklı < -3 || farklı > 0) // Girilen rakamlar aynı basamak için (0-3) arasında farklı basamak için (-3 -1) arasında olup olmamasını kontrol etme
                {
                    MessageBox.Show("Lütfen Kutucuklara Aynı basamak için(0-3)arası Farklı basamak için (-3,-1) arası rakamlar giriniz", "Bilgilendirme Penceresi");
                    txtAynı.Text = "";
                    txtFarklı.Text = "";
                }
                if (aynı == 0 && farklı == 0 && lblRakam.Text == "1234") // Eğer sayı 1234 rakamlarından birini içermiyorsa 5,6,7,8,9 rakamlarını içerenleri üret
                {
                    RandomBesUret();
                }
                else if (Num.BesUret == true && (farklı == 0 || farklı == -1 || farklı == -2 || farklı == -3) && (aynı == 0 || aynı == 1 || aynı == 2 || aynı == 3))
                {
                    //Eğer 5,6,7,8,9 rakamlarını içerip aynı veya farklı da bir değişim varsa rakamı ya swap et ya da yeni rakamlarla random sayı oluştur
                    Num.GlobalNum = Swap(Num.GlobalNum, farklı, aynı);
                    lblRakam.Text = Num.GlobalNum.ToString();
                }
                else if (Num.BesUret == false && (farklı == 0 || farklı == -1 || farklı == -2 || farklı == -3) && (aynı == 0 || aynı == 1 || aynı == 2 || aynı == 3))
                {

                    RandomBırUret();
                    Num.GlobalNum = SwapTum(Num.GlobalNum, farklı, aynı);
                    lblRakam.Text = Num.GlobalNum.ToString();
                }
            }
            else
                MessageBox.Show("Lütfen Kutucukları Boş Bırakmadığınızdan ya da rakam girdiğinizden emin olunuz!!", "Bilgilendirme Penceresi");
        }

        public int[] DigitYapma(int num) // Sayıyı digitlerine ayırma 
        {
            int[] Numdig = new int[4];
            int i = 0;
            while (num > 0)
            {
                Numdig[i] = num % 10;
                i++;
                num = num / 10;

            }
            return Numdig;
        }

        Random randnum = new Random();

        public int Swap(int num, int farklı, int aynı) // Aynı ya da farklı basamak sayısına göre swap ya da yeni sayılar üretme
        {
            bool check = false;
            farklı = farklı * -1;
            int[] digits = new int[4];

            do
            {
                digits = DigitYapma(num); // Gelen sayıyı digitlere ayırma
                for (int j = 0; j < 4; j++)
                {
                    // Farklı basamakta olan sayıyı sabit tutup yeni rakamları oluşturma bulmak için her basamak için farklı 3 rakam
                    int rakam = digits[j];
                    if (farklı == 0) // Eğer hiç farklı basamakta yoksa yeni 4 tane rakam üretme
                    {
                        for (int i = 1; i < 4 - farklı; i++)// Farklı basamak sayısını çıkartıp kalanlar kadar yeni sayı üretme
                        {
                            do // 5 den küçük ve 0 hariç olanları eleme 
                            {
                                if (digits[i] < 5 && digits[i] != 0)
                                    digits[i] = randnum.Next(0, 10);

                            } while (digits[i] < 5 && digits[i] != 0 != false);
                        }
                            int randSayı = SayıYapma(digits); // Yeni oluşan rakamlarla sayıyı oluşturma

                            check = DigitKontrol(randSayı); // Yeni oluşan sayının rakamları farklı olup olmamasını kontrol etme
                            if (check == true)
                            {
                                Num.GlobalNum = randSayı;
                                break;
                            }
                        
                    }
                    else // Eğer 1 tane bile farklı basamak var ise biri sabit diğerleri yeni rakam
                    {
                        for (int i = 1; i <= 4 - farklı; i++) // Farklı basamak sayısını çıkartıp kalanlar kadar yeni sayı üretme
                        {
                            digits[i] = randnum.Next(0, 10);
                            do // 5 den küçük ve 0 hariç olanları eleme 
                            {
                                if (digits[i] < 5 && digits[i] != 0)
                                    digits[i] = randnum.Next(0, 10);

                            } while (digits[i] < 5 && digits[i] != 0 !=false);
                            
                        }
                            int randSayı = SayıYapma(digits);
                            check = DigitKontrol(randSayı); // Yeni oluşan sayının rakamları farklı olup olmamasını kontrol etme
                            if (check == true)
                            {
                                Num.GlobalNum = randSayı;
                                break;
                            }
                        }
                    }

            } while (check != true);
            return Num.GlobalNum;
        }
        public int SwapTum(int num, int farklı, int aynı) // Aynı ya da farklı basamak sayısına göre swap ya da yeni sayılar üretme
        {
            bool check = false;
            farklı = farklı * -1;
            int[] digits = new int[4];

            do
            {
                digits = DigitYapma(num); // Gelen sayıyı digitlere ayırma
                for (int j = 0; j < 4; j++)
                {
                    // Farklı basamakta olan sayıyı sabit tutup yeni rakamları oluşturma bulmak için her basamak için farklı 3 rakam
                    int rakam = digits[j];
                    if (farklı == 0) // Eğer hiç farklı basamakta yoksa yeni 4 tane rakam üretme
                    {
                        for (int i = 1; i < 4 - farklı; i++)// Farklı basamak sayısını çıkartıp kalanlar kadar yeni sayı üretme
                        {
                            digits[i] = randnum.Next(0, 10);
                                                              
                        }
                        int randSayı = SayıYapma(digits); // Yeni oluşan rakamlarla sayıyı oluşturma

                        check = DigitKontrol(randSayı); // Yeni oluşan sayının rakamları farklı olup olmamasını kontrol etme
                        if (check == true)
                        {
                            Num.GlobalNum = randSayı;
                            break;
                        }

                    }
                    else // Eğer 1 tane bile farklı basamak var ise biri sabit diğerleri yeni rakam
                    {
                        for (int i = 1; i <= 4 - farklı; i++) // Farklı basamak sayısını çıkartıp kalanlar kadar yeni sayı üretme
                        {
                            digits[i] = randnum.Next(0, 10);

                        }
                        int randSayı = SayıYapma(digits);
                        check = DigitKontrol(randSayı); // Yeni oluşan sayının rakamları farklı olup olmamasını kontrol etme
                        if (check == true)
                        {
                            Num.GlobalNum = randSayı;
                            break;
                        }
                    }
                }

            } while (check != true);
            return Num.GlobalNum;
        }
        public int SayıYapma(int[] arr)
        {
            int randSayı = arr[0] * 1000 + arr[1] * 100 + arr[2] * 10 + arr[3];
            return randSayı;
        }
    }
}

            
           
       
  


         