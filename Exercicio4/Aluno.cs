using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicio1
{
    class Aluno
    {
        public string Ra;
        public string Nome;
        public decimal NotaProva;
        public decimal NotaTrabalho;
        public decimal NotaFinal;
        public decimal NotaTotal;

        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;
            NotaTotal = NotaProva + NotaTrabalho;
        }
        public bool CalcularNotaFinal()
        {
            if (NotaTotal < 14)
            {
                Console.WriteLine("\nAluno(a) reprovado.");
                Console.WriteLine($"Nota necessária para passar é: {12 - NotaFinal}");

                return true;
            }
            Console.WriteLine("\nAluno(a) aprovado!");
            return false;
        }
        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota totalizada do(a) aluno(a) {Nome} com RA ({Ra}) é de: {(NotaTotal).ToString("N2")}\n");
        }
        public void ReceberDados()
        {
            Console.Write("Digite o Ra do aluno: ");
            Ra = Console.ReadLine();

            Console.Write("Digite o Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o valor da Prova: ");
            NotaProva = Decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor do trabalho: ");
            NotaTrabalho = Decimal.Parse(Console.ReadLine());

        }
    }
}