using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi kalkulator Sederhana";

            Console.Write("1.Penambahan \n");
            Console.Write("2.Pengurangan \n");
            Console.Write("3.Pembagian \n");
            Console.Write("4.Perkalian \n");
            menu:

            Console.Write("Masukan Pilihan [1/2/3/4]: ");
            int pilih = int.Parse(Console.ReadLine());


            if (pilih > 4)
            {
                Console.WriteLine("Maaf pilihan tidak tersedia");
                
                Console.ReadKey();
                goto menu;
            }


            Console.Write("Input Nilai A : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input Nilai B : ");
            int b = int.Parse(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("hasil penjumlahan " + a + '+' + b + '=' + tambah(a, b));
                    break;
                case 2:
                    Console.WriteLine("hasil pengurangan " + a + '+' + b + '=' + kurang(a, b));
                    break;
                case 3:
                    Console.WriteLine("hasil pembagian " + a + '+' + b + '=' + bagi(a, b));
                    break;
                case 4:
                    Console.WriteLine("hasil perkalian " + a + '+' + b + '=' + kali(a, b));
                    break;
            }
            Console.WriteLine("tekan sembarang untuk keluar");
            Console.ReadKey();

            
        }


        static int tambah(int a, int b)
        {
            return a + b;
        }
        static int kurang(int a, int b)
        {
            return a - b;
        }
        static int kali(int a, int b)
        {
            return a * b;
        }
        static float bagi(float a, float b)
        {
            return a / b;
        }
    }
}