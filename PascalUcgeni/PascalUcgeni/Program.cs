using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalUcgeni
{
    class Program
    {
        static void Main(string[] args)
        {
            baslangic:
            int sayi;
            Console.Clear();
            Console.Write("Hesaplanacak satır sayısını giriniz: ");
            string readLine = Console.ReadLine();
            if (!Int32.TryParse(readLine, out sayi))
            {
                Console.WriteLine("Girilen değer sayı değildir.");
                goto baslangic;
            }

            if (sayi <= 0)
            {
                Console.WriteLine($"Girilen değer sıfırdan büyük olmalıdır.");
                goto baslangic;
            }

            for (int i = 0; i < sayi; i++)
            {
                int c = 1;
                for (int e = 0; e < sayi - i; e++)
                {
                    Console.Write("   ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("    {0} ", c);
                    c = c * (i - x) / (x + 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
