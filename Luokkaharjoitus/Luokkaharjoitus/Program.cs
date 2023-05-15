using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokkaharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a new instance of the Dice class
            Dice noppa1 = new Dice(6);
            Dice noppa2 = new Dice(6);
            Dice playerDice = new Dice(6);

            // Roll the dice for the first time
            noppa1.Roll();
            noppa2.Roll();
            playerDice.Roll();

            noppa1.Roll();
            noppa2.Roll();
            playerDice.Roll();

            
            noppa2.Roll();
            playerDice.Roll();

            noppa1.Roll();
            
            playerDice.Roll();

            // Create the board
            char[,] board = new char[3, 3];

            // Initialize the board
            InitializeBoard(board);

            // Display the board
            DisplayBoard(board);

            // Keep track of the score for each player
            int[] scores = new int[3];

            // Start the game
            for (int i = 0; i < 9; i++)
            {
                // Determine whose turn it is
                int player = i % 3 + 1;

                // Make the move for the current player
                MakeMove(board, player, noppa1, noppa2, playerDice);

                // Update the score for the current player
                scores[player - 1] += CalculateScore(board, player);

                // Display the updated board
                DisplayBoard(board);
            }

            // Determine the winner
            int winner = 1;
            int maxScore = scores[0];
            for (int i = 1; i < 3; i++)
            {
                if (scores[i] > maxScore)
                {
                    winner = i + 1;
                    maxScore = scores[i];
                }
            }

            // Print the winner
            Console.WriteLine("Player {0} won with a score of {1}!", winner, maxScore);

            // Wait for user input to exit
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void InitializeBoard(char[,] board)
        {
            // Fill the board with empty spaces

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void DisplayBoard(char[,] board)
        {
            Console.Clear();

            // Display the board
            Console.WriteLine("  1 2 3");
            Console.WriteLine(" -------");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + 1 + "|");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col] + "|");
                }
                Console.WriteLine("\n -------");
            }
        }
        static void MakeMove(char[,] board, int player, Dice noppa1, Dice noppa2, Dice playerDice)
        {
            Console.WriteLine("Player {0}'s turn:", player);
            Console.WriteLine("Press any key to throw dice...");
            Console.ReadKey();

            // Roll the dice for the current player
            int diceResult = 0;
            if (player == 1)
            {
                noppa1.Roll();
                noppa1.Roll();
                noppa1.Roll();
                noppa2.Roll();
                noppa2.Roll();
                diceResult = noppa1.Value;
            }
            else if (player == 2)
            {
                noppa2.Roll();
                noppa2.Roll();
                diceResult = noppa2.Value;
            }
            else if (player == 3)
            {
                playerDice.Roll();
                playerDice.Roll();
                playerDice.Roll();
                playerDice.Roll();
                diceResult = playerDice.Value;
            }

            // Update the board with the dice result
            UpdateBoard(board, player, diceResult);

            // Display the updated board
            DisplayBoard(board);


        }

        static int CalculateScore(char[,] board, int player)
        {
            int score = 0;

            // Check for horizontal lines
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == player.ToString()[0] &&
                    board[row, 1] == player.ToString()[0] &&
                    board[row, 2] == player.ToString()[0])
                {
                    score++;
                }
            }

            // Check for vertical lines
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == player.ToString()[0] &&
                    board[1, col] == player.ToString()[0] &&
                    board[2, col] == player.ToString()[0])
                {
                    score++;
                }
            }

            // Check for diagonal lines
            if (board[0, 0] == player.ToString()[0] &&
                board[1, 1] == player.ToString()[0] &&
                board[2, 2] == player.ToString()[0])
            {
                score++;
            }

            if (board[0, 2] == player.ToString()[0] &&
                board[1, 1] == player.ToString()[0] &&
                board[2, 0] == player.ToString()[0])
            {
                score++;
            }

            return score;
        }

        static void UpdateBoard(char[,] board, int player, int diceResult)
        {
            // Find the first empty cell and mark it with the player's number
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                    {
                        board[row, col] = player.ToString()[0];
                        return;
                    }
                }
            }
        }

    }
}
