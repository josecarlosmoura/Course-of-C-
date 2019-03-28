using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        private static readonly Stream streamTeste;

        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José Carlos de Moura",
                Cpf = "12312312312",
                Email = "josecarlos.moura@gmail.com"
            };

            //É NECESSÁRIO PASSAR O TIPO DO OBJETO. EXISTEM DUAS FORMA DE PEGAR ESSE TIPO.
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Usuario));
            //XmlSerializer xmlSerializer = new XmlSerializer(usuario.GetType());

            //QUANDO É UTLIZADO O CARACTERE "@", É ENTENDIDO QUE TUDO É UM STRING.
            //StreamWriter streamWriter = new StreamWriter(@"C:\Users\jose.silva\Documents\Arquivos\C#\01_SerializarXML.xml");
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\jose.silva\\Documents\\Arquivos\\C#\\01_SerializarXML.xml");

            xmlSerializer.Serialize(streamWriter, usuario);

            //
            using (StringWriter stream = new StringWriter())
            {
                xmlSerializer.Serialize(stream, usuario);

                string xmlSerialized = stream.ToString();              
            }
        }
    }
}
