using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Engin";
            //string student2 = "Derin";
            //string student3 = "Salih";

            //string[] students = new string[3];
            //{
            //    students[0] = "Engin";  Bu şekilde de yazabilirsin
            //    students[1] = "Defne";
            //    students[2] = "Salih";
            //}

            string[] students2 =  { "engin",  "canana", "ksfmkls" };  //Bu şekilde de array oluşturabilirsin

            
            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}

