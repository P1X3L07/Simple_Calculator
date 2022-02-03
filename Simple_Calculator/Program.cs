using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Kalkulator");
            Console.WriteLine("Silahkan pilih operator anda: ");
            Console.WriteLine("1. Penjumlahan (+) \n2. Pengurangan \n3. Perkalian (x) \n4. Pembagian (/) \n5. Mod \n6. Div \n7. Pangkat ^");
            Console.WriteLine("8. Akar pangkat 2 \n9. Faktorial (!) \n10. log");
            Console.Write("Pilih input anda: ");
            Choice();

            Again();

            Console.ReadLine();
        }

        public static void Choice()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Plus();
            }
            else if (input == 2)
            {
                Minus();
            }
            else if (input == 3)
            {
                Perkalian();
            }
            else if (input == 4)
            {
                Divide();
            }
            else if (input == 5)
            {
                Mod();
            }
            else if (input == 6)
            {
                Div();
            }
            else if (input == 7)
            {
                Power();
            }
            else if(input == 8)
            {
                Sqrt();
            }
            else if(input == 9)
            {
                Factorial();
            }
            else if(input == 10)
            {
                log();
            }
        }

        public static void Plus()
        {
            Console.Write("Masukkan angka pertama: ");
            double pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            double kedua = Convert.ToInt32(Console.ReadLine());

            double result = pertama + kedua;
            Console.WriteLine(result);
        }
        public static void Minus()
        {
            Console.Write("Masukkan angka pertama: ");
            double pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            double kedua = Convert.ToInt32(Console.ReadLine());

            double result = pertama - kedua;
            Console.WriteLine(result);
        }
        public static void Perkalian()
        {
            Console.Write("Masukkan angka pertama: ");
            double pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            double kedua = Convert.ToInt32(Console.ReadLine());

            double result = pertama * kedua;
            Console.WriteLine(result);
        }
        public static void Divide()
        {
            Console.Write("Masukkan angka pertama: ");
            double pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            double kedua = Convert.ToInt32(Console.ReadLine());

            double result = pertama / kedua;
            Console.WriteLine(result);
        }
        public static void Mod()
        {
            Console.Write("Masukkan angka pertama: ");
            double pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            double kedua = Convert.ToInt32(Console.ReadLine());

            double result = pertama % kedua;
            Console.WriteLine(result);
        }
        public static void Div()
        {
            Console.Write("Masukkan angka pertama: ");
            int pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            int kedua = Convert.ToInt32(Console.ReadLine());

            int result = pertama / kedua;
            Console.WriteLine(result);
        }
        public static void Power()
        {
            Console.Write("Masukkan angka pertama: ");
            int pertama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            int kedua = Convert.ToInt32(Console.ReadLine());

            int result = pertama ^ kedua;
            Console.WriteLine(result);
        }
        public static void Sqrt()
        {
            Console.Write("Masukkan angka pertama: ");
            int pertama = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(pertama));
        }
        public static void Factorial()
        {
            Console.Write("Masukkan angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            while (angka > 0)
            {
                for (int i = 0; i > 0; i--)
                {
                    angka *= i;
                }
                Console.Write(angka);
            }

        }
        public static void log()
        {
            Console.Write("Masukkan angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());
        }


        public static void Again()
        {
            Console.Write("Apakah ingin menggunakan kalkulator lagi? (y/n) ");
            string ans = Console.ReadLine();
            while (ans != "y" && ans != "n")
            {
                Console.Write("Apakah ingin menggunakan kalkulator lagi? (y/n) ");
                Console.ReadLine();
            }
            
            if(ans == "y")
            {
                Main();
            }
            else if (ans == "n")
            {
                Console.Clear();
            }
        }
    }
}
