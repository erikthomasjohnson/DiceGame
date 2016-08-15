using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Roll
    {
        Dice chooseDice = new Dice();
        public Roll()
        {

        }
        public List<int> GetRoll(string userInputDice)
        {
            if (userInputDice != "")
            {
                int userInput = int.Parse(userInputDice);
                Console.WriteLine("");
                while (userInput == 4 || userInput == 6 || userInput == 8 || userInput == 10 || userInput == 20)
                {
                    if (userInput == 4)
                    {
                        return GetRollFour();
                    }
                    else if (userInput == 6)
                    {
                        return GetRollSix();
                    }
                    else if (userInput == 8)
                    {
                        return GetRollEight();
                    }
                    else if (userInput == 10)
                    {
                        return GetRollTen();
                    }
                    else if (userInput == 20)
                    {
                        return GetRollTwenty();
                    }
                }
                Console.WriteLine("Invalid Entry");
                GetRoll(userInputDice);
                return GetRollTwenty();
            }
            else
            {
                return GetRollTwenty();
            }
            
        }
        public List<int> GetRollFour()
        {
            int rollIndexZero = chooseDice.FourSidedDice();
            Random randomZero = new Random();
            int sleepZero = randomZero.Next(600, 700);
            System.Threading.Thread.Sleep(sleepZero);
            int rollIndexOne = chooseDice.FourSidedDice();
            Random randomOne = new Random();
            int sleepOne = randomOne.Next(500, 600);
            System.Threading.Thread.Sleep(sleepOne);
            int rollIndexTwo = chooseDice.FourSidedDice();
            Random randomTwo = new Random();
            int sleepTwo = randomTwo.Next(400, 500);
            System.Threading.Thread.Sleep(sleepTwo);
            int rollIndexThree = chooseDice.FourSidedDice();
            List<int> rollIndexDiceFour = new List<int> { rollIndexZero, rollIndexOne, rollIndexTwo, rollIndexThree };
            return rollIndexDiceFour;
        }
        public List<int> GetRollSix()
        {
            int rollIndexZero = chooseDice.FourSidedDice();
            Random randomZero = new Random();
            int sleepZero = randomZero.Next(600, 700);
            System.Threading.Thread.Sleep(sleepZero);
            int rollIndexOne = chooseDice.SixSidedDice();
            Random randomOne = new Random();
            int sleepOne = randomOne.Next(500, 600);
            System.Threading.Thread.Sleep(sleepOne);
            int rollIndexTwo = chooseDice.SixSidedDice();
            Random randomTwo = new Random();
            int sleepTwo = randomTwo.Next(400, 500);
            System.Threading.Thread.Sleep(sleepTwo);
            int rollIndexThree = chooseDice.SixSidedDice();
            Random randomThree = new Random();
            int sleepThree = randomTwo.Next(300, 400);
            System.Threading.Thread.Sleep(sleepThree);
            int rollIndexFour = chooseDice.SixSidedDice();
            List<int> rollIndexDiceSix = new List<int> { rollIndexZero, rollIndexOne, rollIndexTwo, rollIndexThree, rollIndexFour };
            return rollIndexDiceSix;
        }
        public List<int> GetRollEight()
        {
            int rollIndexZero = chooseDice.FourSidedDice();
            Random randomZero = new Random();
            int sleepZero = randomZero.Next(600, 700);
            System.Threading.Thread.Sleep(sleepZero);
            int rollIndexOne = chooseDice.EightSidedDice();
            Random randomOne = new Random();
            int sleepOne = randomOne.Next(500, 600);
            System.Threading.Thread.Sleep(sleepOne);
            int rollIndexTwo = chooseDice.EightSidedDice();
            Random randomTwo = new Random();
            int sleepTwo = randomTwo.Next(400, 500);
            System.Threading.Thread.Sleep(sleepTwo);
            int rollIndexThree = chooseDice.EightSidedDice();
            Random randomThree = new Random();
            int sleepThree = randomTwo.Next(300, 400);
            System.Threading.Thread.Sleep(sleepThree);
            int rollIndexFour = chooseDice.EightSidedDice();
            Random randomFour = new Random();
            int sleepFour = randomTwo.Next(200, 300);
            System.Threading.Thread.Sleep(sleepFour);
            int rollIndexFive = chooseDice.EightSidedDice();
            List<int> rollIndexDiceEight = new List<int> { rollIndexZero, rollIndexOne, rollIndexTwo, rollIndexThree, rollIndexFour, rollIndexFive };
            return rollIndexDiceEight;
        }
        public List<int> GetRollTen()
        {
            int rollIndexZero = chooseDice.FourSidedDice();
            Random randomZero = new Random();
            int sleepZero = randomZero.Next(600, 700);
            System.Threading.Thread.Sleep(sleepZero);
            int rollIndexOne = chooseDice.TenSidedDice();
            Random randomOne = new Random();
            int sleepOne = randomOne.Next(500, 600);
            System.Threading.Thread.Sleep(sleepOne);
            int rollIndexTwo = chooseDice.TenSidedDice();
            Random randomTwo = new Random();
            int sleepTwo = randomTwo.Next(400, 500);
            System.Threading.Thread.Sleep(sleepTwo);
            int rollIndexThree = chooseDice.TenSidedDice();
            Random randomThree = new Random();
            int sleepThree = randomTwo.Next(300, 400);
            System.Threading.Thread.Sleep(sleepThree);
            int rollIndexFour = chooseDice.TenSidedDice();
            Random randomFour = new Random();
            int sleepFour = randomTwo.Next(200, 300);
            System.Threading.Thread.Sleep(sleepFour);
            int rollIndexFive = chooseDice.TenSidedDice();
            Random randomFive = new Random();
            int sleepFive = randomTwo.Next(100, 200);
            System.Threading.Thread.Sleep(sleepFive);
            int rollIndexSix = chooseDice.TenSidedDice();
            List<int> rollIndexDiceTen = new List<int> { rollIndexZero, rollIndexOne, rollIndexTwo, rollIndexThree, rollIndexFour, rollIndexFive, rollIndexSix };
            return rollIndexDiceTen;
        }
        public List<int> GetRollTwenty()
        {
            int rollIndexZero = chooseDice.FourSidedDice();
            Random randomZero = new Random();
            int sleepZero = randomZero.Next(600, 700);
            System.Threading.Thread.Sleep(sleepZero);
            int rollIndexOne = chooseDice.TwentySidedDice();
            Random randomOne = new Random();
            int sleepOne = randomOne.Next(500, 600);
            System.Threading.Thread.Sleep(sleepOne);
            int rollIndexTwo = chooseDice.TwentySidedDice();
            Random randomTwo = new Random();
            int sleepTwo = randomTwo.Next(400, 500);
            System.Threading.Thread.Sleep(sleepTwo);
            int rollIndexThree = chooseDice.TwentySidedDice();
            Random randomThree = new Random();
            int sleepThree = randomTwo.Next(300, 400);
            System.Threading.Thread.Sleep(sleepThree);
            int rollIndexFour = chooseDice.TwentySidedDice();
            Random randomFour = new Random();
            int sleepFour = randomTwo.Next(200, 300);
            System.Threading.Thread.Sleep(sleepFour);
            int rollIndexFive = chooseDice.TwentySidedDice();
            Random randomFive = new Random();
            int sleepFive = randomTwo.Next(100, 200);
            System.Threading.Thread.Sleep(sleepFive);
            int rollIndexSix = chooseDice.TwentySidedDice();
            Random randomSix = new Random();
            int sleepSix = randomTwo.Next(0, 100);
            System.Threading.Thread.Sleep(sleepSix);
            int rollIndexSeven = chooseDice.TwentySidedDice();
            List<int> rollIndexDiceTwenty = new List<int> { rollIndexZero, rollIndexOne, rollIndexTwo, rollIndexThree, rollIndexFour, rollIndexFive, rollIndexSix, rollIndexSeven };
            return rollIndexDiceTwenty;
        }
    }
}
