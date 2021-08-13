using _01_Generics.Models;
using System;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car() { Brand = "Ford", Model = "F-150" };
            var house = new House() { City = "Fortaleza", Address = "Rua 123" };
            var user = new User() { Name = "Tiago Barbosa", Email = "tiago@gmail.com", Password = "123456" };

            Serializer.Serialize(car);
            Serializer.Serialize(house);
            Serializer.Serialize(user);

            var car2 = Serializer.Deserialize<Car>();
            var house2 = Serializer.Deserialize<House>();
            var user2 = Serializer.Deserialize<User>();

            Console.WriteLine($"Car - Brand: {car2.Brand}, Model: {car2.Model}");
            Console.WriteLine($"House - City: {house2.City}, Address: {house2.Address}");
            Console.WriteLine($"User - Name: {user2.Name}, E-mail: {user2.Email}");
        }
    }
}
