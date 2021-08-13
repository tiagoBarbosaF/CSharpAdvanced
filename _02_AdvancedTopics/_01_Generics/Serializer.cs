using System;
using System.IO;
using System.Web.Script.Serialization;

namespace _01_Generics
{
    public class Serializer
    {
        public static void Serialize(Object obj)
        {
            var sw = new StreamWriter(@"C:\Users\antonio.farias\source\repos\CSharp avancado\Files\03_" + obj.GetType().Name + ".txt");
            var serializer = new JavaScriptSerializer();
            var objSerialized = serializer.Serialize(obj);

            sw.Write(objSerialized);
            sw.Close();
        }

        public static T Deserialize<T>()
        {
            var sr = new StreamReader(@"C:\Users\antonio.farias\source\repos\CSharp avancado\Files\03_" + typeof(T).Name + ".txt");
            var contents = sr.ReadToEnd();
            var serializer = new JavaScriptSerializer();
            var obj = (T)serializer.Deserialize(contents, typeof(T));

            return obj;
        }
    }
}
