using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Calculo
    {
        public double ValorA;
        public double ValorB;
        public double Resultado;

        public double CalcularSoma()
        {
            double soma = ValorA + ValorB;
            return soma;
        }
        public double CalcularSubtracao()
        {
            double subtracao = ValorA - ValorB;
            return subtracao;
        }
        public double CalcularMultiplicacao()
        {
            double multiplicacao = ValorA * ValorB;
            return multiplicacao;
        }
        public double RetornarMaior()
        {
            return Math.Max(ValorA, ValorB);
        }

        public double SomarGeral(double valor = 0)
        {

            Resultado = ValorA + ValorB + valor;
            return Resultado;
        }
        public void ImprimirResultado(int menu)
        {
            double soma = CalcularSoma();
            double subtracao = CalcularSubtracao();
            double multiplicacao = CalcularMultiplicacao();


            switch (menu)
            {
                case 1:
                    Console.Write($"Resultado da soma é:{soma}");
                    break;
                case 2:
                    Console.Write($"Resultado da subtração é:{subtracao}");
                    break;
                case 3:
                    Console.Write($"Resultado da multiplicação é:{multiplicacao}");
                    break;

            }

        }

        public void armazenarvalorA(double a)
        {
            ValorA = a;
        }
        public void armazenarvalorB(double b)
        {
            ValorB = b;
        }
    }
}