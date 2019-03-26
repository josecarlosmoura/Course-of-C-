using _05_Generics.Entities;
using System;

namespace _05_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car { Brand = "Fiat", Model = "Uno" };

            House houseOne = new House { City = "Uberlândia", Adress = "João Naves de Ávila" };

            User userOne = new User { Name = "José", Email = "jose.silva@cedrotech.com", Password = "1234" };

            Serializer.Serialize(carOne);
            Serializer.Serialize(houseOne);
            Serializer.Serialize(userOne);

            Car carTwo = Serializer.Deserialize<Car>();
            House houseTwo = Serializer.Deserialize<House>();
            User userTwo = Serializer.Deserialize<User>();

            Console.WriteLine($"Car two = {carTwo.Brand} - {carTwo.Model}");

            Console.WriteLine($"House two = {houseTwo.City} - {houseTwo.Adress}");

            Console.WriteLine($"User tow = {userTwo.Name} - {userTwo.Email}");

            Console.ReadKey();
        }

    }
}
