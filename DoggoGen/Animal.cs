using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggoGen
{
    class Animal
    {
        internal Random Random = new Random();
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public string Gender { get; protected set; }
        public string Fren { get; protected set; }
        public string Ability { get; protected set; }

        public Animal()
        {
            GetGender();
            GetAbility();
        }

        public virtual void GetGender()
        {
            var gender = Random.Next(0, 2);

            if (gender == 0)
                Gender = "Boy";
            else if (gender == 1)
                Gender = "Girl";
        }

        private void GetAbility()
        {
            string[] abilities = { "Adaptability", "Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anticipation",
                                "Arena Trap", "Aroma Veil", "Aura Break", "Bad Dreams", "Battery", "Battle Armor", "Battle Bond",
                                "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cacophony", "Cheek Pouch", "Chlorophyll",
                                "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Competitive", "Compound Eyes", "Contrary",
                                "Corrosion", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dazzling", "Defeatist",
                                "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Drizzle", "Drought", "Dry Skin",
                                "Early Bird", "Effect Spore", "Electric Surge", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body",
                                "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard",
                                "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Grass Pelt", "Grassy Surge",
                                "Guts", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Huge Power", "Hustle", "Hydration",
                                "Hyper Cutter", "Ice Body", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out",
                                "Inner Focus", "Insomnia", "Intimidate", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz",
                                "Leaf Guard", "Levitate", "Light Metal", "Lightning Rod", "Limber", "Liquid Ooze", "Liquid Voice",
                                "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale",
                                "Mega Launcher", "Merciless", "Minus", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie",
                                "Multiscale", "Multitype", "Mummy", "Natural Cure", "Neuroforce", "No Guard", "Normalize", "Oblivious",
                                "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal",
                                "Poison Point"};

            Ability = abilities[Random.Next(0, abilities.Count())];
        }
    }
}
