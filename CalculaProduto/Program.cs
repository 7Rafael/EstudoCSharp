using CalculaProduto;
using System;
using System.Globalization;
using System.Xml;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto product;
            product = new Produto();

            Console.WriteLine("Enter the product info");

            Console.WriteLine("Name: ");
            product.Name = Console.ReadLine();

            Console.WriteLine("price");
            product.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Unit avaliable");   
            product.Unit = int.Parse(Console.ReadLine());

            Console.WriteLine(product);

     /*
            Console.WriteLine("Enter the number to Add to the storage");
            product.addProduct = double.Parse(Console.ReadLine());
            
            product.AddProduct();
            Console.WriteLine($"teste: {product.Unit}")
            product.removeProduct = double.Parse(Console.ReadLine());

            product.RemoveProduct();
     */
        }
    }
}