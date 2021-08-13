using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_LinqObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<User>();
            list.Add(new User() { Name = "Tiago", Email = "tiago@gmail.com" });
            list.Add(new User() { Name = "Rakel", Email = "rakel@outlook.com" });
            list.Add(new User() { Name = "José", Email = "jose@gmail.com" });
            list.Add(new User() { Name = "João", Email = "joao@outlook.com" });
            list.Add(new User() { Name = "Rafael", Email = "rafael@gmail.com" });
            list.Add(new User() { Name = "Maisa", Email = "mais@outlook.com" });
            list.Add(new User() { Name = "Beatriz", Email = "beatriz@gmail.com" });

            var filteredList = list.Where(x => x.Email.Contains("@outlook.com")).OrderBy(x => x.Email).Select(x => x);
            foreach (var item in filteredList)
            {
                Console.WriteLine($"Name: {item.Name} - Email: {item.Email}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
