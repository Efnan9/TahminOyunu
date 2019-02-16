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
    public partial class TahmınEt : Form
    {
        public TahmınEt()
        {
            InitializeComponent();
            
        }
        private void TahmınEt_Load(object sender, EventArgs e) // form yüklendiğinde yazılım kendiliğinden random sayı üretir.
        {
            Random randnum = new Random();
            bool check;
            do
            {
                int randomNumber = randnum.Next(1000, 10000);// 4 basamaklı 1000-9999 arasında random sayı üretme
                check = DigitKontrol(randomNumber); // rakamları farklı mı diye kontrol etme
                if (check == true)
                {
                    Num.GlobalNum = randomNumber;// eğer rakamları farklı ise global num yazılım tarafından tutulan sayı oldu
                    break;
                }

            } while (check != true);// eğer değilse yeniden random sayı üret

            MessageBox.Show(Num.GlobalNum.ToString(), "Bilgilendirme Penceresi");
        }
        public class Num
        {
            public static int GlobalNum;// herhangi bir fonksiyondan global değere ulaşmak için class olarak tanımlama
        }
        private void Tahmınet_Click(object sender, EventArgs e)
        {
           
            bool checkNum;
            int num;
            if (int.TryParse(txtBox.Text, out num) && txtBox.Text != "" ) // kullanıcının sayı girdiği textbox ın boş olup olmaması 
            {                                                             // ya da girdiği değerin string değil sayı olması

                checkNum = DigitKontrol(num); // kullanıcının girdiği sayının rakamlarının farklı olup olmamasını kontrol etme
                if (checkNum == false) // eğer değilse rakamları farklı bir sayı girmesini önerme
                {
                    MessageBox.Show("Rakamları farklı sayı giriniz..!", "Bilgilendirme Penceresi");
                    txtBox.Text = "";
                }
                else
                {
                    CheckNumbers(num, Num.GlobalNum); // eğer rakamları farklı ise tahmin etme oyununa başlama
                }
            }
            else
            {
                //invalid
                MessageBox.Show("Lütfen rakam girdiğinize ya da boş bırakmadığınıza emin olunuz!!", "Bilgilendirme Penceresi");
            }
            


            

        }
        public void CheckNumbers(int num, int randomNumber)// num=Kullanıcının girdiği
                                                           // randomNumber=Bilgisayarın tuttuğu rakam
        {
            if (num == randomNumber) // kullanıcının yazdığı sayı ile bilgisayarın tuttuğu sayının eşleşmesi
            {
                MessageBox.Show("Sayıyı buldunuz..!!!!", "Bilgilendirme Penceresi");
                return;
            }
            if (num != randomNumber) // eşleşme yoksa eğer iki rakamı da digitlerine ayırma
            {
                int[] Numdig = new int[4]; // digit arrayleri olarak tanımlanma
                int[] RandNumdig = new int[4];

                int[] Sonuc = new int[2]; // sonuc arrayi olarak farklı ya da aynı basamak değeri tutması 

                int countBas = 0; // aynı basamak için tutulan count değeri
                int countFark = 0; // farklı basamak için tutulan count değeri

                Numdig = DigitYapma(num); // digit arrayleri olarak döndüler
                RandNumdig = DigitYapma(randomNumber);

                for (int i = 0; i < Numdig.Length; i++)
                {
                    for (int j = 0; j < Numdig.Length; j++) // hem sayılar hem de basamakları eşitse countbas++
                    {
                        if (Numdig[i] == RandNumdig[j] && i == j)
                        {
                            countBas++;
                            Sonuc[0] = countBas;
                        }
                        else if (Numdig[i] == RandNumdig[j]) // sayılar eşit ama basamakları farklıysa countFark--
                        {
                            if (i != j)
                            {
                                countFark--;
                                Sonuc[1] = countFark;
                            }
                        }
                    }
                }
                Sonuc_label.Visible = true;
                Sonuc_label.Text = "Aynı Basamak için sonuç: " + Sonuc[0] + " Farklı Basamak için sonuç: " + Sonuc[1]; // sonucu form da gösterme

            }
        }
        public int[] DigitYapma(int num) // gelen sayıyı digitlerine ayırıp array olarak döndürme
        {
            int[] Numdig = new int[4];
            int i = 0;
            while(num>0)
            {
                Numdig[i] = num % 10;
                i++;
                num = num / 10;
               
            }
            return Numdig;
        }




        public bool DigitKontrol(int num) // rakamların farklı olup olmamasını basamaklarına ayırarak kontrol etme
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
    }
}
