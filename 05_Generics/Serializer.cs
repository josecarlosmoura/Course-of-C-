using Newtonsoft.Json;
using System.IO;
using System.Web;

namespace _05_Generics
{
    public class Serializer
    {
        public static void Serialize(object obj)
        {
            StreamWriter stream = new StreamWriter($@"C:\Users\jose.silva\Documents\Particular\Courses\Course-of-CSharp\05_Generics\Arquivos\03_{obj.GetType().Name}.txt");

            string objSerialize = JsonConvert.SerializeObject(obj);

            stream.Write(objSerialize);
            stream.Close();
        }

        public static T Deserialize<T>()
        {
            StreamReader stream = new StreamReader($@"C:\Users\jose.silva\Documents\Particular\Courses\Course-of-CSharp\05_Generics\Arquivos\03_{typeof(T).Name}.txt");

            string content = stream.ReadToEnd();

            return (T)JsonConvert.DeserializeObject(content, typeof(T));
        }
    }
}
