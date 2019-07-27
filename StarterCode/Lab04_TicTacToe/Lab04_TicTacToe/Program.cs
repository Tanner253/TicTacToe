using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PlayGame();
        }
        /// <summary>
        /// activates the game - starts game
        /// </summary>
        static void PlayGame()
        {
            // TODO: Setup your game here. Create an introduction. 
            // Create your players, and instantiate your Game class. 
            // output to the console the winner
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.WriteLine("player One, Please enter your name");
            string p1 = Console.ReadLine();
            Player player1 = new Player
            {
                Name = p1,
                Marker = "X",
                IsTurn = true

            };
            Console.WriteLine("Player Two, Please enter your name");
            string p2 = Console.ReadLine();

            Player player2 = new Player
            {
                Name = p2,
                Marker = "O",
                IsTurn = false
            };

            Console.Clear();
            Console.WriteLine("Let's Play!");

            //start new game

            Game game = new Game(player1, player2);

            Player winner = game.Play();
            if (!(winner is null))
            {
                Console.WriteLine($"{winner.Name}, Has won the game! Better luck next time!");
            }
            else
            {
                Console.WriteLine("Well played! Tie game!");
                Console.WriteLine("Rematch? Y/N");
                string rematch = Console.ReadLine();
                switch (rematch)
                {
                    case "Y":
                        {
                            Game rematchGame = new Game(player1, player2);
                            rematchGame.Play();

                        }
                        break;
                    case "N":
                        {
                            Console.WriteLine("Thanks for playing!");
                        }
                        break;

                }



            }
        }
    }
}
