using Exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio1
{
    public class Calculadora
    {
        private Calculo calcular = new Calculo();

        public static void LerValores(Calculo varcalculo)
        {
            Console.Write("Digite o primeiro valor (A): ");
            varcalculo.armazenarvalorA(double.Parse(Console.ReadLine()));
            Console.Write("Digite o segundo valor (B): ");
            varcalculo.armazenarvalorB(double.Parse(Console.ReadLine()));
        }
        public void ExecutarCalculadora()
        {
            int escolha = 0;

            do
            {
                Console.WriteLine("Operações presentes no menu:");
                Console.WriteLine("Soma      -     (Digite 1)");
                Console.WriteLine("Subtração   -   (Digite 2)");
                Console.WriteLine("Multiplicação - (Digite 3)");
                Console.WriteLine("Maior valor  -  (Digite 4)");
                Console.WriteLine("Soma geral   -  (Digite 5)");
                Console.WriteLine("Sair do menu -  (Digite 6)");


                Console.WriteLine("A operação escolhida para ser realizada é: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        LerValores(calcular);
                        calcular.CalcularSoma();
                        calcular.ImprimirResultado(1);
                        break;

                    case 2:
                        Console.Clear();
                        LerValores(calcular);
                        calcular.CalcularSubtracao();
                        calcular.ImprimirResultado(2);
                        break;

                    case 3:
                        Console.Clear();
                        LerValores(calcular);
                        calcular.CalcularMultiplicacao();
                        calcular.ImprimirResultado(3);
                        break;

                    case 4:
                        Console.Clear();
                        LerValores(calcular);
                        double maiorvalor = calcular.RetornarMaior();
                        Console.WriteLine("O maior valor dos dois numeros é: " + maiorvalor);
                        break;

                    case 5:
                        Console.Clear();
                        LerValores(calcular);
                        Console.Write("Digite um terceiro valor (C): ");
                        double valor = double.Parse(Console.ReadLine());

                        calcular.SomarGeral(valor);
                        Console.WriteLine($"A soma geral é: " + calcular.Resultado);
                        break;

                    case 6:
                        Console.WriteLine("Saindo do menu de operações");
                        break;

                    default:
                        Console.WriteLine("Número da operação incorreto!");
                        break;
                }

                Console.WriteLine();
            } while (escolha != 6);
        }
    }

}