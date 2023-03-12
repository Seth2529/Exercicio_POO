using Exercicio3;

ManipularArquivo Arquivo = new ManipularArquivo();
Arquivo.EnderecoNomeArquivo = "Escreva o diretório para chegar no arquivo desejado";
Arquivo.Conteudo = "Este é o conteúdo do arquivo .txt";

bool salvar = Arquivo.SalvarDadoseArquivos();
if (salvar)
{
    Console.WriteLine("Mudanças salva com êxito.");
}
else
{
    Console.WriteLine("As mudanças não conseguiram ser aplicadas");
}

string pesquisararquivo = Arquivo.PesquisarConteudoArquivo(Arquivo.EnderecoNomeArquivo);
if (pesquisararquivo != "")
{
    Console.WriteLine("Arquivo encontrado com sucesso!");
    Console.WriteLine(pesquisararquivo);
}
else
{
    Console.WriteLine("Arquivo não encontrado");
}

Console.ReadKey();