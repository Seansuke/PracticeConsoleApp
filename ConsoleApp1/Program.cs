using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            string desiredSumText = Console.ReadLine();
            Int32.TryParse(desiredSumText, out int desiredSum);

            RollTwoDice myDiceRoller = new RollTwoDice();
            List<DiceSetResult> rollTable = myDiceRoller.GetRollList(desiredSum);

            Console.WriteLine(myDiceRoller.DisplayRollsByList(rollTable));

            Console.ReadLine();

            Player playerOne = new Player();
            playerOne.Hp = 10;
            playerOne.AttackList.Add(new Attack() { Name = "Punch", Power = 10});
        }
    }
}
