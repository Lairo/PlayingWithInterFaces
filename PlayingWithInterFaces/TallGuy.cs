using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithInterFaces
{
    internal class TallGuy
    {
        public string Name;
        public int Height;

        public void TalkAboutYoruself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
}
