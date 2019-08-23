using System;

namespace DoggoGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var doggo = new GenerateDoggo();

            Console.WriteLine("DoggoGen - Generate your dream doggo");
            Console.WriteLine();
            Console.WriteLine("Name: " + doggo.Name);
            Console.WriteLine("Gender: Good " + doggo.Gender);
            Console.WriteLine("Age: " + doggo.Age);
            Console.WriteLine("Type: " + doggo.Type);
            Console.WriteLine("Height: " + doggo.Height);
            Console.WriteLine("Longth: " + doggo.Longth);
            Console.WriteLine("Snoot span: " + doggo.Snoot);
            Console.WriteLine("Colour: " + doggo.Colour);
            Console.WriteLine("Special ability: " + doggo.Ability);
            Console.WriteLine("Favourite toy: " + doggo.Toy);
            Console.WriteLine("Best fren: " + doggo.Fren);
            Console.WriteLine();
        }
    }
}
