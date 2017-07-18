using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Agenda
{
    public static class cl_geral
    {

        public static string versao = "V.1.0.0";

        //lista de contatos
        public static List<cl_contato> LISTA_CONTATOS;

        public static void ControiListaDeContatos() {

            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            //cria lista vazia
            LISTA_CONTATOS = new List<cl_contato>();
   
            if (File.Exists(nome_ficheiro))
                {   
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                
                while (!ficheiro.EndOfStream)
                {
                    string nome = ficheiro.ReadLine();
                    string numero = ficheiro.ReadLine();

                    cl_contato novo_contato = new cl_contato();
                    novo_contato.nome = nome;
                    novo_contato.numero = numero;

                    LISTA_CONTATOS.Add(novo_contato);
                }

                ficheiro.Dispose();
            }              
        }

        public static void GravarUmNovoRegistro(string _nome, string _numero)
        {
            //gravar um novo registro (ficheiro e lista)
            //lista
            LISTA_CONTATOS.Add(new cl_contato{ nome = _nome, numero = _numero });

            //ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro() {

            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false, Encoding.Default);

            foreach (cl_contato contato in LISTA_CONTATOS)
            {
                ficheiro.WriteLine(contato.nome);
                ficheiro.WriteLine(contato.numero);
            }
            ficheiro.Dispose();
        }
    }
}
