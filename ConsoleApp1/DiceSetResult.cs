using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DiceSetResult
    {
        public int FirstRoll { get; set; }

        public int SecondRoll { get; set; }

        public int GetSum() 
        {
            return FirstRoll + SecondRoll;
        }
    }
}
