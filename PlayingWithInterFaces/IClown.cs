using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithInterFaces
{
    internal interface IClown
    {
        public string FunnyThingIHave { 
            get { return "big shoes"; }
        }
        public void Honk();
    }
}
