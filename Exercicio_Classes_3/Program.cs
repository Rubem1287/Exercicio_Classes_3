using System;
using System.Globalization;
namespace Exercicio_Classes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno : ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno : ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (aluno.Soma() >= 60.0)
            {
                Console.Write("Nota Final = " + aluno.Soma().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.Write("Nota Final = " + aluno.Soma().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.WriteLine("REPROVADO");
                Console.Write("Faltaram " + aluno.Falta().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
        }
    }
}
