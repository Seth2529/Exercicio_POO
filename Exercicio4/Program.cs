using Exercicio1;

Console.WriteLine("Qual a quantidade de alunos a serem digitados?");
int numeroalunos = int.Parse(Console.ReadLine());

List<Aluno> AlunosLista = new List<Aluno>();
for (int i = 0; i < numeroalunos; i++)
{
    Console.Clear();
    Console.WriteLine("\nDigite os dados do {0}° aluno", i + 1);
    Aluno a = new Aluno();
    a.ReceberDados();
    a.CalcularMedia();
    AlunosLista.Add(a);

}

Console.WriteLine("\n Notas Finais");
foreach (Aluno a in AlunosLista)
{
    a.CalcularNotaFinal();
    a.ImprimirNotaFinal();
}

Calculadora calculadora = new Calculadora();
calculadora.ExecutarCalculadora();

Console.ReadLine();