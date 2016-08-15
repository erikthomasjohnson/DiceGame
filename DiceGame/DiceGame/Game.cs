using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Game
    {
        Roll playGame = new Roll();
        public Game()
        {

        }
        public void RunGame()
        {
            Console.WriteLine("----------(Enter) to play game---------- or ----------Choose a dice to roll (4, 6, 8, 10, 20)---------- ");
            string userInputDice = Console.ReadLine();
            if (userInputDice == "")
            {
                PlayGame();
            }
            else
            {
                Roll runRoll = new Roll();
                foreach (int roll in runRoll.GetRoll(userInputDice))
                {
                    Console.WriteLine(roll);
                }
                Console.WriteLine("");
                Console.WriteLine("Would you like to play again? ('n' to exit)");
                if (Console.ReadLine() != "n")
                {
                    Console.WriteLine("");
                    RunGame();
                }
            }
        }
        public void PlayGame()
        {
            PlayGameIntro();
            PlayGameRoundOne();
            PlayGameRoundTwo();
            PlayGameRoundThree();
            PlayGameRoundFour();
            PlayGameRoundFive();
            PlayGameWinner();
        }
        public void PlayGameIntro()
        {
            Console.WriteLine("The Game is About to Begin ----- Please Wait for the Game to Initiate Thermo-Hyper Quantum 'Nano Optic Beta-Dice'!!!!!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Game Will Begin in 5 Seconds.....");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Game Will Begin in 4 Seconds.....");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Game Will Begin in 3 Seconds.....");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Game Will Begin in 2 Seconds.....");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("");
        }
        public void PlayGameRoundOne()
        {
            Console.WriteLine("Round 1 *****100 Points***** Four-Sided Dice: Correctly Guess One of Four Rolls: Choose a Number (1 - 4)");
            int userInputRoundOne = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);
            List<int> playGameRollOne = new List<int>();
            playGameRollOne = playGame.GetRollFour();
            foreach (int roll in playGameRollOne)
            {
                Console.WriteLine(roll);
            }
            if (userInputRoundOne == playGameRollOne[0] || userInputRoundOne == playGameRollOne[1] || userInputRoundOne == playGameRollOne[2] || userInputRoundOne == playGameRollOne[3])
            {
                Console.WriteLine("*****Correct*****");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Current Score = 100 Points");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                PlayGameLoser();
            }
        }
        public void PlayGameRoundTwo()
        {
            Console.WriteLine("Round 2 *****1,000 Points***** Six-Sided Dice: Correctly Guess One of Five Rolls: Choose a Number (1 - 6)");
            int userInputRoundTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);
            List<int> playGameRollTwo = new List<int>();
            playGameRollTwo = playGame.GetRollSix();
            foreach (int roll in playGameRollTwo)
            {
                Console.WriteLine(roll);
            }
            if (userInputRoundTwo == playGameRollTwo[0] || userInputRoundTwo == playGameRollTwo[1] || userInputRoundTwo == playGameRollTwo[2] || userInputRoundTwo == playGameRollTwo[3] || userInputRoundTwo == playGameRollTwo[4])
            {
                Console.WriteLine("*****Correct*****");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Current Score = 1,100 Points");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                PlayGameLoser();
            }
        }
        public void PlayGameRoundThree()
        {
            Console.WriteLine("Round 3 *****10,000 Points***** Eight-Sided Dice: Correctly Guess One of Six Rolls: Choose a Number (1 - 8)");
            int userInputRoundThree = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);
            List<int> playGameRollThree = new List<int>();
            playGameRollThree = playGame.GetRollEight();
            foreach (int roll in playGameRollThree)
            {
                Console.WriteLine(roll);
            }
            if (userInputRoundThree == playGameRollThree[0] || userInputRoundThree == playGameRollThree[1] || userInputRoundThree == playGameRollThree[2] ||
                userInputRoundThree == playGameRollThree[3] || userInputRoundThree == playGameRollThree[4] || userInputRoundThree == playGameRollThree[5])
            {
                Console.WriteLine("*****Correct*****");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Current Score = 11,100 Points");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                PlayGameLoser();
            }
        }
        public void PlayGameRoundFour()
        {
            Console.WriteLine("Round 4 *****100,000 Points***** Ten-Sided Dice: Correctly Guess One of Seven Rolls: Choose a Number (1 - 10)");
            int userInputRoundFour = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);
            List<int> playGameRollFour = new List<int>();
            playGameRollFour = playGame.GetRollTen();
            foreach (int roll in playGameRollFour)
            {
                Console.WriteLine(roll);
            }
            if (userInputRoundFour == playGameRollFour[0] || userInputRoundFour == playGameRollFour[1] || userInputRoundFour == playGameRollFour[2] ||
                userInputRoundFour == playGameRollFour[3] || userInputRoundFour == playGameRollFour[4] || userInputRoundFour == playGameRollFour[5])
            {
                Console.WriteLine("*****Correct*****");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Current Score = 111,100 Points");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                PlayGameLoser();
            }
        }
        public void PlayGameRoundFive()
        {
            Console.WriteLine("Final Round *****1,000,000 Points***** Twenty-Sided Dice: Correctly Guess One of Eight Rolls: Choose a Number (1 - 20)");
            int userInputRoundFive = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);
            List<int> playGameRollFive = new List<int>();
            playGameRollFive = playGame.GetRollTwenty();
            foreach (int roll in playGameRollFive)
            {
                Console.WriteLine(roll);
            }
            if (userInputRoundFive == playGameRollFive[0] || userInputRoundFive == playGameRollFive[1] || userInputRoundFive == playGameRollFive[2] ||
                userInputRoundFive == playGameRollFive[3] || userInputRoundFive == playGameRollFive[4] || userInputRoundFive == playGameRollFive[5] ||
                userInputRoundFive == playGameRollFive[6] || userInputRoundFive == playGameRollFive[7])
            {
                Console.WriteLine("*****Correct*****");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Final Score = 1,111,100 Points");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void PlayGameWinner()
        {
            Console.WriteLine("");
            Console.WriteLine("********** YOU WIN **********");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("********** YOU WIN **********");
            Console.WriteLine("");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("********** YOU WIN **********");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("********** YOU WIN **********");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("********** YOU WIN **********");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("********** YOU WIN **********");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("********** YOU WIN **********");
            Console.ReadLine();
        }
        public void PlayGameLoser()
        {
            Console.WriteLine("**********YOU LOSE**********");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Would you like to play again? ('n' to exit)");
            if (Console.ReadLine() != "n")
            {
                Console.WriteLine("");
                RunGame();
            }
        }
        
    }
}
