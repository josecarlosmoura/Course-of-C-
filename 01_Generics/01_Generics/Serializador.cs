using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace _01_Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            StreamWriter streamWriter = new StreamWriter($@"C:\Users\jose.silva\Documents\Particular\Courses\Course-of-CSharp\05_Generics\Arquivos\03_{obj.GetType().Name}.txt");

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string ojbSerializado = serializer.Serialize(obj);

            streamWriter.Write(ojbSerializado);
            streamWriter.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader streamReader = new StreamReader($@"C:\Users\jose.silva\Documents\Particular\Courses\Course-of-CSharp\05_Generics\Arquivos\03_{typeof(T).Name}.txt");

            string conteudo = streamReader.ReadToEnd();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return (T)serializer.Deserialize(conteudo, typeof(T));
        }
    }
}
