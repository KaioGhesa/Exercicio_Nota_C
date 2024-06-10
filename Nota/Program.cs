
using System;
using System.Globalization;

namespace Nota
{
    internal class Program
    {
        static void Main(string[] args)

        {

            notas notas = new notas();

            Console.Write("Digite a nota do aluno: ");
            notas.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            notas.A1 = double.Parse(Console.ReadLine());
            notas.A2 = double.Parse(Console.ReadLine());
            notas.A3 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Nota Final = " + 
                notas.SomaNota().ToString("F2",CultureInfo.InvariantCulture));
            if (notas.Aprovado())
            {
                Console.WriteLine("Aluno: " + notas.Nome + " aprovado!!");
            }
            else
            {
                Console.WriteLine("Aluno: " + notas.Nome + " Reprovado");
                Console.WriteLine("Faltou: "
                    + notas.NotaRestante().ToString("F2",CultureInfo.InvariantCulture) +
                    " Pontos");
            }
        }
    }
}
