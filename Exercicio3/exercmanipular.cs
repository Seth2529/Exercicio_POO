using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class ManipularArquivo
    {
        public string Conteudo;
        public string EnderecoNomeArquivo;

        public bool SalvarDadoseArquivos()
        {
            try
            {
                if(!File.Exists(EnderecoNomeArquivo))
                    File.Create(EnderecoNomeArquivo).Close();
                
                StreamWriter sw = new StreamWriter(EnderecoNomeArquivo);
                sw.WriteLine(Conteudo);
                sw.Close();
                return true;
            }
            catch(Exception ex){
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public string PesquisarConteudoArquivo(string Endereco)
        {
            if (!File.Exists(Endereco))
                return "";
            
            StreamReader sr = new StreamReader(Endereco);
            string conteudo = sr.ReadToEnd();
            sr.Close();
            return conteudo;

            
        }
    }
}