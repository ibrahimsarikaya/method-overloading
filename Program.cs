using System;

namespace method_overloading // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Out parametreleri
            string sayi="999";
            
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine(outSayi);
            }
            else 
            {
                Console.WriteLine("Basarısız");
            }
            metotlar instance = new metotlar();
            instance.Topla(2,3,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);

            //Method overloading 
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            //
        }
    }
    class metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam=a+b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}