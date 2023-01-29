using System;
using System.Linq;

namespace YeniCalısma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var result = Add2();  
            //Console.WriteLine(result);

            //int sayi1 = 20;
            //int sayi2 = 100;
            //var result =Add3(ref sayi1, sayi2);
            //Console.WriteLine(result);
            //Console.WriteLine(sayi1);
            //Console.WriteLine(Multiply(2, 4, 5));

            //Console.WriteLine(Add4(1,2,3,4,5,6));
            //SayHello();
            //Console.ReadKey();

            //Console.WriteLine("1.sayıyı Gir: ");
            //double sayi1=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2. sayıyı gir: ");
            //double  sayi2=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("3. sayıyı gir: ");
            //double sayi3 = Convert.ToDouble(Console.ReadLine());

            //double sonuc = MultiplySayilar(sayi1,sayi2,sayi3);
            //Console.WriteLine("Sonuç: " + sonuc);

            Console.WriteLine("Sum of number is:" + AddNumbers(1, 2, 3, 4, 5));
            Console.ReadKey();


        }
        static int Add2(int sayi1 = 75, int sayi2 = 85)
        {
            var result = sayi1 + sayi2;
            return result;
        }

        static int Add3(ref int sayi1, int sayi2)
        {
            sayi1 = 450;
            return sayi1 + sayi2;

        }
        static int Multiply(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 * sayi2 + sayi3;
        }

        //static int Add4(int sayi1, int sayi2, int sayi3)
        //{
        //    return sayi1 + sayi2;
        //}

        static int Add4(params int[] sayilar)
        {
            return sayilar.Sum();
        }


        static void SayHello()
        {
            Console.WriteLine("Merhaba Dünya!");
        }

        static double MultiplySayilar(double sayi1, double sayi2, double sayi3)
        {
            return sayi1 / sayi2 * sayi3;
        }
        static int AddNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }
    }
}