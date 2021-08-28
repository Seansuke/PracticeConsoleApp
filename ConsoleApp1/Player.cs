using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Player
    {
        public Player()
        {
            AttackList = new List<Attack>();
        }

        public int Hp { get; set; }
        public List<Attack> AttackList { get; set; }
    }
}
