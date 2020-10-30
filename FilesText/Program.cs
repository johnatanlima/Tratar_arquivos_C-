using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace FilesText
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamReader leitor =)
            //{

            //}

            // string meu = new StreamReader(@"C:\Users\johw2\ansi.txt", Encoding.UTF8).ReadLine();

            var arquivo = @"C:\Users\johw2\Desktop\Workspace .NET Core\Tratar_arquivos_CSharp\FilesText\ansi.txt";
            string temp = @"C:\Users\johw2\Desktop\Workspace .NET Core\Tratar_arquivos_CSharp\FilesText\temp.txt";
            
            string resultado = "";
            string varTemp = "";
            
            Encoding encoding = Encoding.Default;
            string original = "";

                using (StreamReader sr = new StreamReader(arquivo, Encoding.Default))
                {
                    original = sr.ReadToEnd();
                    encoding = sr.CurrentEncoding;
                    sr.Close();
                }

            if (encoding == Encoding.UTF8)
            {
                resultado = $"É pra sair tudo funfando! { original }";
            }
            else
            {
                varTemp = File.ReadAllText(arquivo, Encoding.UTF8);

                /*
                File.WriteAllText(temp, original, Encoding.Default);

                using (StreamReader sr = new StreamReader(temp, Encoding.Default))
                {
                    varTemp = sr.ReadToEnd();
                    //encoding = sr.CurrentEncoding;
                    sr.Close();
                }
                */

                resultado = varTemp; 

              //  byte[] BytesCodificados = encoding.GetBytes(original);
                /*string BytesCodificados = encoding.GetString(original); */    

                //byte[] BytesCorrigidos = Encoding.Convert(encoding, Encoding.UTF8, BytesCodificados);
                //String BytesCorrigidos = Enconding.Convert(encoding, Encoding.UTF, strBytesCodificados)
                
               // resultado = Encoding.UTF8.GetString(BytesCorrigidos);
            }

            Console.WriteLine($"\t Resolução é: { resultado }");

        }

    }
}
