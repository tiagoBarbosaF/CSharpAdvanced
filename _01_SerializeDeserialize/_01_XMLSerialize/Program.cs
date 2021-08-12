using System;
using System.IO;
using System.Xml.Serialization;
using _00_Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_XMLSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User() { Name = "Tiago Barbosa", CPF = "111.111.111-11", Email = "tiago@gmail.com" };
            var serialize = new XmlSerializer(typeof(User));
            var stream = new StreamWriter(@"C:\Users\antonio.farias\source\repos\CSharp avancado\Files\01_XMLSerialize.xml");

            serialize.Serialize(stream, user);
        }
    }
}
