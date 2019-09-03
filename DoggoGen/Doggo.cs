using System;
using System.Linq;

namespace DoggoGen
{
    class Doggo : Animal
    {
        public int Height { get; protected set; }
        public int Longth { get; protected set; }
        public string Type { get; protected set; }
        public double Snoot { get; protected set; }
        public string Colour { get; protected set; }
        public string Toy { get; protected set; }

        public Doggo()
        {
            GetName();
            GetAge();
            GetHeight();
            GetLongth();
            GetType();
            GetSnoot();
            GetColour();
            GetToy();
            GetFren();
        }

        private void GetName()
        {
            string[] names = { "Cookie Monster", "Ewok", "Artoo Dogtoo", "Chewbacca", "Muttley Cru", "Moneypenny",
                            "Biggie Smalls", "50 Scent", "Snoop Dog", "Kanye Westie", "Groucho Barks", "Markie Mark",
                            "Liberace", "Calamity Jane", "Mini-Pearl", "Cinder Ella", "Biggie Smalls", "James Earl Bones",
                            "Jabba the Mutt", "Ma Barker", "Mr. Bean", "Catherine Zeta Bones", "Indiana Bones", "Pablo Escobark",
                            "Anderson Pooper", "Ellen Degeneruff", "Al Poo-chino", "Scary Spice", "Jimmy Chew", "Woofgang Puck",
                            "Santa Paws", "Bustamove", "Speedy Gonzalez", "Fresh Prints", "Woofie Goldberg", "Hairy Paw-ter",
                            "Virginia Woof", "Ezra Hound", "Paw-casso", "Bark Twain", "Droolious Caesar", "Mary Puppins",
                            "Sniffy Longdroppings", "Miss Havisham", "Do-Little", "Winnie the Pooch", "Bilbo Waggins", "Andy Warhowl",
                            "George Bernard Paw", "Sherlock Bones", "Andre the Giant", "Chunk", "Dogzilla", "Hulk", "Samson", "Sumo",
                            "Atilla", "Bruiser", "Cujo", "King Kong", "Brutus", "Moose", "Chickpea", "Tiny", "Bon Bon", "Bear Burrito",
                            "Bitsy", "Munchkin", "Peanut", "Little Bunny Foo Foo", "Pee Wee", "Bitsy", "Nugget", "Sorbet", "Cupcake",
                            "Fluffernutter", "Meatball", "Noodles", "Tater", "Waffles", "Eggroll", "Pup Tart", "Tater Tot", "Nacho",
                            "Pickle", "Porkchop", "Charleston Chew", "Chickpea", "Latke", "Won Ton", "Nutella", "Kumquat", "Crouton",
                            "Maple Sizzup", "Sir Tabasco Hot Shot", "Snow-pee", "Sir Loin", "Gizmo", "Beta", "Dot Matrix", "Giga", "Quark",
                            "Applet", "FiFo", "WYSIWYG", "Byte", "Qwerty", "Napster", "Woofer", "Subwoofer", "Slo Moe",
                            "Lord Wafflestack of Buttercreme Shire", "Chunky Face Monkey Butt", "Herr Pickles Von Wiener Schnitzel",
                            "BlueperLuper Super Duper Dog", "Speed Queen Leontine Von Washateria", "Sir Mooska Moo Bernie",
                            "Dynamite Diesel Duddley Do", "Dunkle Doxie Graben Stein", "Lord Geoffrey Wiggleton of the Yorkshire Wiggletons",
                            "Smokey Bottom Jeans Boots With the Fur", "Lucky Goodsniffer", "Professor Wagglesworth", "Doctor Guiseppe Suppertime",
                            "Chauncey Von Poopsalot", "Howyadoin’ Mr. Beaujangles", "Alfredo Moonglow" };

            Name = names[Random.Next(0, names.Count())];
        }

        public override void GetGender()
        {
            var gender = Random.Next(0, 2);

            if (gender == 0)
                Gender = "Boye";
            else if (gender == 1)
                Gender = "Girle";
        }

        private void GetHeight()
        {
            Height = Random.Next(1, 100);
        }

        private void GetLongth()
        {
            Longth = Random.Next(1, 100);
        }

        private void GetType()
        {
            var size = Height * Longth;

            if (Age > 10 && size > 4000)
                Type = "Big ol' boofer";
            else if (Age < 3 && size < 200)
                Type = "Pupperino";
            else if (Age < 3)
                Type = "Pupper";
            else if (size < 200)
                Type = "Smol doggo";
            else if (size > 200 && size < 2000)
                Type = "Doggo";
            else if (size > 2000 && size < 4000)
                Type = "Woofer";
            else if (size > 4000)
                Type = "Boofer";
        }

        private void GetSnoot()
        {
            Snoot = Random.NextDouble();
        }

        private void GetAge()
        {
            Age = Random.Next(0, 20);
        }

        private void GetColour()
        {
            string[] colours = { "White", "Black", "Black and white", "Brown", "Ginger", "Blue" };

            Colour = colours[Random.Next(0, colours.Count())];
        }


        private void GetToy()
        {
            string[] toys = { "Tennis ball", "Frisbee", "Stick", "Ragger", "Nylabone", "Toilet roll tube", "Brick", "Football" };

            Toy = toys[Random.Next(0, toys.Count())];
        }

        private void GetFren()
        {
            string[] frens = { "Spot", "Socks", "Patch", "Blackie", "Brownie", "Coffee", "Cocoa", "Cinnamon", "Pepper", "Ginger","Bandit",
                                "Red", "Fluffy", "Freckles", "Scruffy", "Goldie", "Rusty", "Tiny", "Lady", "King", "Prince", "Princess",
                                "Cuddles", "Nibbles", "Wag", "Joker", "Joy", "Scooter", "Sparky", "Speedy", "Scamp", "Shadow", "Champ",
                                "Duke", "Fido", "Fluffy", "Lucky", "Rex", "Rover", "Scout", "Teddy", "Bailey", "Bella", "Buster", "Buddy",
                                "Charlie", "Chloe", "Cody", "Daisy", "Jack", "Jake", "Lola", "Lucy", "Maggie", "Max", "Molly", "Rocky",
                                "Sadie", "Sally", "Sophie", "Toby" };

            Fren = frens[Random.Next(0, frens.Count())];
        }
    }
}
