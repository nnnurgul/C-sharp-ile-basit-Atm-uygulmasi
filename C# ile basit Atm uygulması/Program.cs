using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ile_basit_Atm_uygulması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000;
            Console.WriteLine("Atm ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi Giriniz");
            string secim = Console.ReadLine();
             
            if(secim=="1")
            { 
                Console.WriteLine("Şuan ki Bakiyeniz:"+bakiye);
                Console.ReadLine();
            }
            else if(secim=="2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("Kalan tutar:" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                    Console.ReadLine();

                }
            }
            else if( secim=="3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                int yatırıacak_tutar = Convert.ToInt32(Console.ReadLine());
                  
                Console.WriteLine("Yeni Bakiyeniz:" +(yatırıacak_tutar+bakiye));
                Console.ReadLine();
            }
            else if (secim == "q")
            {
                Console.WriteLine("Atm den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı.İyi günler...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                Console.ReadLine();
            }

        }
    }
}
