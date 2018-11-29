using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using _00_Biblioteca;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("C:\\Users\\jose.silva\\Documents\\Arquivos\\C#\\01_SerializarXML.json");
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

            Usuario usuario = (Usuario)javaScriptSerializer.Deserialize(streamReader.ReadToEnd().ToString(), typeof(Usuario));

            Console.WriteLine("Usário\n" +
                "Nome: {0}\n" +
                "CPF: {1}\n" +
                "Email: {2}",
                usuario.Nome, usuario.Cpf, usuario.Email);

            Console.ReadKey();
        }
    }
}
