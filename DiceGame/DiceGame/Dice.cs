using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Dice
    {
        public Dice()
        {

        }
        public int FourSidedDice()
        {
            Random random = new Random();
            int roll = random.Next(1, 5);
            return roll;
        }
        public int SixSidedDice()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            return roll;
        }
        public int EightSidedDice()
        {
            Random random = new Random();
            int roll = random.Next(1, 9);
            return roll;
        }
        public int TenSidedDice()
        {
            Random random = new Random();
            int roll = random.Next(1, 11);
            return roll;
        }
        public int TwentySidedDice()
        {
            Random random = new Random();
            int roll = random.Next(1, 21);
            return roll;
        }
    }
}
