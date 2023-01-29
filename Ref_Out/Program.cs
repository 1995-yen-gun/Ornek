using System;
using System.ComponentModel;
using System.Threading;

namespace Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            ChangeValue(ref x);
            Console.WriteLine(x);

            int result;
            GetValue(out result);   
            Console.WriteLine(result);

            int a = 8;
            int b = 10;
            var sonuc = Add( a,b);
            Console.WriteLine(a);
            Console.WriteLine(result);
        }
        static void ChangeValue (ref int value )
        {
            value = value * 2;
        }
        static void GetValue (out int value)
        {
            value = 20;
        }

        static int Add( int a, int b)
        {
            a = 50;
            return  a+ b; 
           
        }
    }
}
