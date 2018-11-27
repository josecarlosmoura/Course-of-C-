using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\jose.silva\Documents\Arquivos\C#\01_SerializarXML.xml");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Usuario));

            Usuario usuario = (Usuario)xmlSerializer.Deserialize(streamReader);

            Console.WriteLine("Usário\n" +
                "Nome: {0}\n" +
                "CPF: {1}\n" +
                "Email: {2}",
                usuario.Nome, usuario.Cpf, usuario.Email);

            Console.ReadKey();
        }
    }
}
