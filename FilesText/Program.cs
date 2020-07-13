using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace FilesText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t TRABALHANDO COM CLASSE FILE \n\n");

            Console.Write(" Digite o texto para salvar no txt -> ");
            string texto = Console.ReadLine();

            //  string cam = Path.GetFileName(Directory.GetCurrentDirectory());

            //  var diretorio = Directory.EnumerateFiles(cam);

            /* UMA DAS MANEIRAD PRA CRIAR UM ARQUIVO E SALVAR O CONTEUDO DA VARIAVEL NESSE ARQUIVO DE TEXTO
                                
                    File.WriteAllText("arquivo.txt", texto);

                    string[] linhas = File.ReadAllLines("arquivo.txt");

                    int i = 0;

                    foreach (var linha in linhas)
                    {
                        Console.WriteLine($"Linha {i} conteudo -> {linha}");

                        i++;
                    }
            */

            /* VERIFICAR SE O ARQUIVO JÁ EXSTE, E TOMAR ALGUM AÇÃO EM CIMA DISTO

            if (!File.Exists("arquivo.txt"))
            {
                File.WriteAllText("arquivo.txt", texto);
               
            }
            else
                Console.WriteLine("O arquivo.txt já existe \n\n");

            Console.WriteLine("\t UTILIZANDO UM ARRAY DE BYTES PARA LER O ARQUIVO.TXT \n");

            byte[] bytes = File.ReadAllBytes("arquivo.txt");

            foreach (var caractere in bytes)
            {
                Console.Write(caractere);
                Console.WriteLine("---------------------------------------------");
            }

            Console.WriteLine("Usando casting... \n");
            foreach(var caractere in bytes)
            {
                Console.Write((char)caractere);
            }
            */

            //TRABALHANDO COM ENUMERAÇÕES
            Console.WriteLine(" \t --- TRABALHANDO COM ENUMERAÇÕES --- \n\n ");


            Console.Write("Informe o seu tipo de cliente: (Físico) ou (Jurídico): ");

            string cliente = Console.ReadLine();

            TipoCliente tipo;

            if(cliente.ToUpper() == "FÍSICO")
            {
                tipo = TipoCliente.Pessoa_Fisica;
                Console.WriteLine($"Ok! Você é uma pessoa física! -> {tipo}");
            }
            else if (cliente.ToUpper() == "JURÍDICO")
            {
                tipo = TipoCliente.Pessoa_Juridica;
                Console.WriteLine($"Ok! Você é uma pessoa jurídica! -> {tipo}");

            }
            else
                Console.WriteLine("NENHUM VALOR ENCONTRADO. TENTE NOVAMENTE!");
            
          
        }

        enum TipoCliente
        {
            Pessoa_Fisica,
            Pessoa_Juridica
        }
    }
}
