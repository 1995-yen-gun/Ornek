using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            string productDescription = "Amasya Apple";
            int productPrice = 54;

            Product product = new Product();

            product.Name= "Apple";
            product.Description="Amasya Apple";
            product.Price= 54;

            Product[] products = new Product[] {product};

            foreach (var prod in products)   
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(productDescription);
                Console.WriteLine(productPrice);
                Console.WriteLine(product);
                Console.WriteLine("---*********-----");
            }
                
                    
        }
    }
}
