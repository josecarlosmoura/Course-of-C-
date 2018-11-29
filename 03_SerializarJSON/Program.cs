using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using _00_Biblioteca;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Zelia Domingues",
                Cpf = "11111111111",
                Email = "zelia.moura@gmail.com"
            };

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\jose.silva\\Documents\\Arquivos\\C#\\01_SerializarXML.json");

            streamWriter.WriteLine(javaScriptSerializer.Serialize(usuario));
            streamWriter.Close();
        }
    }
}
