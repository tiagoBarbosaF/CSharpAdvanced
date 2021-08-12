using _00_Library;
using System;
using System.IO;
using System.Web.Script.Serialization;

namespace _04_JSONDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new StreamReader(@"C:\Users\antonio.farias\source\repos\CSharp avancado\Files\02_JSONSerialize.json");
            var fileLines = stream.ReadToEnd();
            var serialize = new JavaScriptSerializer();
            var user = (User)serialize.Deserialize(fileLines, typeof(User));

            Console.WriteLine($"User Name: {user.Name}, CPF: {user.CPF}, E-mail: {user.Email}");
        }
    }
}
