using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RollTwoDice
    {
        public RollTwoDice() 
        {
            
        }
        public RollTwoDice(int desiredSum)
        {
            DisplayRolls(desiredSum);
        }

        public void DisplayRolls(int desiredSum)
        {
            // TODO - Validator
            int actualSum;
            // TODO - Prevent user error, use NOT dowhile
            do
            {
                Random myRandom = new Random();
                int firstDiceRoll = myRandom.Next(1, 6);
                int secondDiceRoll = myRandom.Next(1, 6);
                actualSum = firstDiceRoll + secondDiceRoll;
                Console.WriteLine($"{firstDiceRoll} and {secondDiceRoll} = {actualSum}");
            } while (actualSum != desiredSum);
        }

        public string DisplayRolls(int[,] rollTable)
        {
            string rollText = "";
            for (int i = 0; i < rollTable.GetLength(0); i++)
            {
                if (rollTable[i, 0] == 0)
                {
                    break;
                }
                rollText += (string.Format("{0} and {1} = {2}", rollTable[i, 0], rollTable[i, 1], rollTable[i, 2]));
            }
            return rollText;
        }
        public string DisplayRollsByList(List<DiceSetResult> diceList)
        {
            string rollText = "";
            foreach (DiceSetResult dice in diceList)
            {
                rollText += $"{dice.FirstRoll} and {dice.SecondRoll} = {dice.GetSum()}" + Environment.NewLine;
            }
            return rollText;
        }

        public int[,] GetRolls(int desiredSum)
        {
            int[,] diceRollTable = new int[99, 3];

            // TODO - Validator
            int actualSum;
            int i = 0;
            // TODO - Prevent user error, use NOT dowhile
            do
            {
                Random myRandom = new Random();
                int firstDiceRoll = myRandom.Next(1, 6);
                int secondDiceRoll = myRandom.Next(1, 6);
                actualSum = firstDiceRoll + secondDiceRoll;
                diceRollTable[i, 0] = firstDiceRoll;
                diceRollTable[i, 1] = secondDiceRoll;
                diceRollTable[i, 2] = firstDiceRoll + secondDiceRoll;
                i++;
            } while (actualSum != desiredSum);
            return diceRollTable;
        }

        public List<DiceSetResult> GetRollList(int desiredSum)
        {
            List<DiceSetResult> diceList = new List<DiceSetResult>();

            // TODO - Validator
            int actualSum;

            // TODO - Prevent user error, use NOT dowhile
            do
            {
                Random myRandom = new Random();
                DiceSetResult newRoll = new DiceSetResult();
                newRoll.FirstRoll = myRandom.Next(1, 6);
                newRoll.SecondRoll = myRandom.Next(1, 6);
                diceList.Add(newRoll);
                actualSum = newRoll.GetSum();
            } while (actualSum != desiredSum);
            return diceList;
        }

        public void DisplayRolls(int[] desiredSumList)
        {
            // TODO - Overloader
        }
    }
}
