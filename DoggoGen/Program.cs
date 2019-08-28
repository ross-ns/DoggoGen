using System;
using System.Collections;
using System.Linq;

namespace DoggoGen
{
    class Program
    {
        static void Main(string[] args)
        {

            Doggo doggo = new Doggo();
            Console.WriteLine("DOGGO");
            Console.WriteLine("Name: " + doggo.Name);
            Console.WriteLine("Gender: " + doggo.Gender);
            Console.WriteLine("Age: " + doggo.Age);
            Console.WriteLine("Special ability: " + doggo.Ability);
            Console.WriteLine("Best fren: " + doggo.Fren);

            Console.WriteLine();

            Cat cat = new Cat();
            Console.WriteLine("CAT");
            Console.WriteLine(cat.Name);
            Console.WriteLine("Gender: " + cat.Gender);
            Console.WriteLine("Age: " + cat.Age);
            Console.WriteLine("Lives left: " + cat.Lives);
            Console.WriteLine("Intelligence: " + cat.Intelligence);
            Console.WriteLine("Special ability: " + cat.Ability);
            Console.WriteLine("Best fren: " + cat.Fren);

            Console.WriteLine();

            //Doggo[] doggos = new Doggo[1000];
            //Random random = new Random();

            //for (int i = 0; i < 1000; i++)
            //    doggos[i] = new Doggo(random);

            //var oldBoyes = doggos.Where(d => d.Age > 10)
            //                    .OrderByDescending(d => d.Age)
            //                    .Select(d => new { d.Name, d.Age })
            //                    .Take(1);

            //foreach (var oldBoye in oldBoyes)
            //    Console.WriteLine("The oldest is: {0} and they are {1} years old", oldBoye.Name, oldBoye.Age);

            //Console.WriteLine(oldBoyes.Count());


            //Doggo doggo = new Doggo();

            //Console.WriteLine("DoggoGen - Generate your dream doggo");
            //Console.WriteLine();
            //Console.WriteLine("Name: " + doggo.Name);
            //Console.WriteLine("Gender: Good " + doggo.Gender);
            //Console.WriteLine("Age: " + doggo.Age);
            //Console.WriteLine("Type: " + doggo.Type);
            //Console.WriteLine("Height: " + doggo.Height);
            //Console.WriteLine("Longth: " + doggo.Longth);
            //Console.WriteLine("Snoot span: " + doggo.Snoot);
            //Console.WriteLine("Colour: " + doggo.Colour);
            //Console.WriteLine("Special ability: " + doggo.Ability);
            //Console.WriteLine("Favourite toy: " + doggo.Toy);
            //Console.WriteLine("Best fren: " + doggo.Fren);
            //Console.WriteLine();
        }
    }
}
