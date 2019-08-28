using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggoGen
{
    class Birb : Animal
    {
        public string Song { get; protected set; }
        public string Phrase { get; protected set; }
        public string Food { get; protected set; }

        public Birb()
        {
            GetName();
            GetAge();
            GetSong();
            GetPhrase();
            GetFood();
        }

        private void GetName()
        {
            string[] names = { "Alex", "Tweety", "Zazu", "Gunter", "Kevin", "Mordecai" };

            Name = names[Random.Next(0, names.Count())];
        }

        private void GetAge()
        {
            Age = Random.Next(0, 50);
        }

        private void GetSong()
        {
            string[] songs = { "Addams Family Theme", "Chocobo's Theme", "iPhone ringtone", "Another One Bites the Dust", "Imperial March" };

            Song = songs[Random.Next(0, songs.Count())];
        }

        private void GetPhrase()
        {
            string[] phrases = { "Ok Google beep", "What you doing", "What the hell was that?", "Peekaboo" };

            Phrase = phrases[Random.Next(0, phrases.Count())];
        }

        private void GetFood()
        {
            Food = "Seed";
        }
    }
}
