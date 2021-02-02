using System;
using System.Globalization;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Estudante[] estudante = new Estudante[10];

            for (i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                estudante[quarto] = new Estudante(nome, email);

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Quartos alugados: ");

            for (i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine(i + ": " + estudante[i] );
                }
            }
        }
    }
}
