using System;
using System.Globalization;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int repitir = 0;
            do
            {
                bool On = false;
                int times = 0;
                int x;

                Console.WriteLine("Escolha entre 1 e 2");
                x = int.Parse(Console.ReadLine());

                if (x == 1)
                    On = true;
                else if (x == 2)
                    Console.WriteLine("desligado");
                else
                    Console.WriteLine("Numero inesperado");
                while (On == true && times < 3)
                {
                    Console.WriteLine("ligado");
                    times++;
                }
                Console.WriteLine("digite 0 para recomeçar");
                repitir = int.Parse(Console.ReadLine());
            } while (repitir == 0);                                   
        }
    }
}
