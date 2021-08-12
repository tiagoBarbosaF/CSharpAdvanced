using _00_Library;
using System;
using System.IO;
using System.Xml.Serialization;

namespace _02_XMLDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new StreamReader(@"C:\Users\antonio.farias\source\repos\CSharp avancado\Files\01_XMLSerialize.xml");
            var serialize = new XmlSerializer(typeof(User));
            var user = (User)serialize.Deserialize(stream);

            Console.WriteLine($"User Name: {user.Name}, CPF: {user.CPF}, E-mail: {user.Email}");
        }
    }
}
