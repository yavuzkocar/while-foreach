using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) olan sayıların ortalamasını hesaplayıp yazdıran program
            // int n = int.Parse(Console.ReadLine());
            // int sayac = 1 ;
            // int toplam =  0 ;
            // while (sayac<=n)
            // {
            //   toplam += sayac ;
            //   sayac ++;
            

            // }
            // Console.WriteLine(toplam/n);
            
            //a dan z ye kadar olan harfleri konsola yazdır
            char karakter = 'a';
            while (karakter<'z')
            {
                 Console.Write(karakter);
                 karakter ++ ;
            }
           
            Console.WriteLine("****foreach****");
            {
                string[] meyveler = {"elma","armut","kivi","karpuz","üzüm"};
                foreach (var meyve in meyveler)
                {
                    Console.WriteLine(meyve);

                }

            }


        }
    }
}
