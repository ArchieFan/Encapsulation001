using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation001
{
    public class Cat
    {
        private int _Mood = 100;
        private int _Hungry = 100;
        private int _Energy = 100;

        public int Mood { 
            get { return _Mood; } 
        }

        public int Hungry { 
            get { return _Hungry; } 
        }

        public int Energy { 
            get { return _Energy; } 
        }

        public string sleep()
        {
            _Energy = _Energy + 10;
            _Hungry = _Hungry + 10;
            return "";
        }

        public string play()
        {
            _Mood = _Mood + 10;
            _Energy = _Energy - 10;
            return meow();
        }

        public string feed()
        {
            _Hungry = _Hungry - 10;
            _Mood = _Mood + 10;
            return meow();
        }

        private string meow()
        {
            return "Meow~";
        }
    }
}
