using System;

namespace ExceptionThrogh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita un numero: ");
            int numero = int.Parse(Console.ReadLine());
            try
            {
                cod(numero);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error"+e.Message);
            }
        }
        static void cod(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Digito: 1");
                    break;
                case 2:
                    Console.WriteLine("Digito: 2");
                    break;
                case 3:
                    Console.WriteLine("Digito: 3");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
