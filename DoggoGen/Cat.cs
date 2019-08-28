﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggoGen
{
    class Cat : Animal
    {
        public int Lives;
        public int Intelligence;

        public Cat()
        {
            GetName();
            GetAge();
            GetLives();
            GetFren();
        }

        private void GetName()
        {
            // Name is derived from the Animal class
            string[] names = { "Tom", "Ginger", "Simba", "Felix", "Tigger", "Gardfiel", "Charlie", "Mr. Bigglesworth", "Mufasa",
                            "Azrael", "Salem" };
            Name = "Name: " + names[Random.Next(0, names.Count())];
        }

        private void GetAge()
        {
            // Age is derived from the Animal class
            Age = Random.Next(0, 30);
        }

        private void GetLives()
        {
            // Lives is unique to Cats
            Lives = Random.Next(1, 9);
        }

        private void GetIntelligence()
        {
            // Intelligence is unique to Cats
            Intelligence = Random.Next(0, 2);
        }

        private void GetFren()
        {
            Fren = "None";
        }
    }
}
