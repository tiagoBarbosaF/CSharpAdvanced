using _00_Library;
using System.IO;
using System.Web.Script.Serialization;

namespace _03_JSONSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User() { Name = "Rakel Moreira", CPF = "222.222.222-22", Email = "rakel@gmail.com" };
            var serialize = new JavaScriptSerializer();
            string serializeObject = serialize.Serialize(user);
            var sw = new StreamWriter(@"C:\Users\antonio.farias\source\repos\CSharp avancado\Files\02_JSONSerialize.json");

            sw.WriteLine(serializeObject);
            sw.Close();
        }
    }
}
