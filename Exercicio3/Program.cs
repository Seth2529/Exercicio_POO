using Exercicio3;

ManipularArquivo Arquivo = new ManipularArquivo();
Arquivo.Conteudo = "Ghost";
Arquivo.EnderecoNomeArquivo = @"C:\Users\erics\Documents\arquivo\arquivo.txt";

if (Arquivo.SalvarDadoseArquivos())
{
    Console.WriteLine("Arquivo modificado com êxito!");
}
Console.WriteLine(Arquivo.PesquisarConteudoArquivo(Arquivo.EnderecoNomeArquivo))
    
