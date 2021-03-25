using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDigitada;

            Console.WriteLine("---Data de aniversário--- \n");
            Console.WriteLine("Digite a data do seu nascimento no formato: AAAA,MM.DD");
            dataDigitada = Console.ReadLine();
            DateTime nascimentoUsuario = Convert.ToDateTime(dataDigitada);
            DateTime aniversarioDezoito = nascimentoUsuario.AddYears(18);
            Console.WriteLine($"O dia do seu nascimento foi: {nascimentoUsuario.ToLongDateString()}");
            Console.WriteLine($"Seu aniversário de 18 anos: {aniversarioDezoito.ToLongDateString()}");

          
        }
    }
}
