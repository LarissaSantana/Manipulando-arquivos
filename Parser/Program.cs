using System;
using System.IO;

namespace ManipularTxt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Criando o arquivo
            // Declarando variável do tipo StreamWriter para abrir ou criar um arquivo para escrita 
            StreamWriter x;

            /* Colocando o caminho físico e o nome do arquivo a ser criado finalizando com .txt */
            string caminhoNome = @"C:\Users\larissa.santana\Documents\visual studio 2017\Projects\ExemploParser\arquivo.txt";


            /* Utilizando o método para criar um arquivo texto e associar o caminho e nome ao método */
            x = File.CreateText(caminhoNome);

            #endregion

            #region Escrevendo no arquivo
            /* WriteLine -> escreve e passa para a próxima linha */
            x.WriteLine("Recibo de pagamento");
            x.WriteLine();
            x.WriteLine();

            x.WriteLine("Recebi do Sr: Nome do pagador");
            x.WriteLine("a quantia de VALOR DO RECIBO (VALOR POR EXTENSO),");
            x.WriteLine("referente ao DESCRIÇÃO DO QUE FOI PAGO...");
            x.WriteLine("CIDADE, DATA");

            x.WriteLine();
            x.WriteLine();

            x.WriteLine("----------------------------------------------");
            x.WriteLine("Nome do pagador");
            x.WriteLine("CPF do pagador: CPF");

            x.WriteLine();

            /* Fechando o arquivo texto com o método .Close() */
            x.Close();

            #endregion

            #region Ler um arquivo txt existente e continuar escrevendo nele
            /*
            //StreamWriter x;

            string caminho = @"C:\Users\larissa.santana\Documents\Visual Studio 2017\Projects\ExemploParser\arquivo.txt";

            x = File.AppendText(caminho);

            //Continuar a escrever neste arquivo
            //Escrevendo a partir da última linha
            x.WriteLine();
            x.WriteLine("----------------------------------------------");
            x.WriteLine("Recebedor");
            x.WriteLine("CPF do recebedor: CPF");
            x.Close();
            */
            #endregion

            #region Abrir um arquivo texto e ler seu conteudo
            /*
            //StreamReader -> tipo de leitura de arquivo
            StreamReader arquivo;

            //Colocando o endereço físico
            string caminhoLeitura = @"C:\Users\larissa.santana\Documents\Visual Studio 2017\Projects\ExemploParser\arquivo.txt";

            //Abrindo um arquivo txt indicado
            arquivo = File.OpenText(caminhoLeitura);

            //EndOfStream retorna true caso esteja na ultima linha do arquivo
            while (arquivo.EndOfStream != true)
            {
                //Ler o conteúdo da linha
                string linha = arquivo.ReadLine();
                //Imprimindo o conteúdo
                Console.WriteLine(linha);
            }

            arquivo.Close();
            Console.ReadKey();
            */
            #endregion

            #region Ler uma linha por vez
            int counter = 0;
            string line;

            StreamReader arquivo;

            string caminho = @"C:\Users\larissa.santana\Documents\Visual Studio 2017\Projects\ExemploParser\arquivo.txt";

            //arquivo = File.OpenText();
            #endregion

            #region Abrindo o arquivo texto em um bloco de notas
            /*
            System.Diagnostics.Process.Start("notepad", caminho);
            #endregion

            #region Deletando um txt
            string caminhoArquivo = @"C:\Users\larissa.santana\Documents\Visual Studio 2017\Projects\ExemploParser\arquivo.txt";

            File.Delete(caminhoArquivo);
            */
            #endregion

        }

    }
}
