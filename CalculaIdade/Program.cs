using CalculaIdade;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            x.Nome= Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");

            y.Nome= Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());

            if(x.Idade > x.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é : {x.Nome}");
            }
            else
                Console.WriteLine($"A Pessoa mais velha é : {y.Nome}");
       
        }
    }
}