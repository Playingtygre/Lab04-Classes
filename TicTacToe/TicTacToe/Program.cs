using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");
            GetPlayerInfo();

        }

        // Input of player Names
        static void GetPlayerInfo()
        {
            Console.WriteLine("Player 1 what is your name?");
            string player1 = Console.ReadLine();
            Player player = CreatePlayer1(player1, "|X|");
            Console.WriteLine("Player 2 what is your name?");
            string player2 = Console.ReadLine();
            Player second = CreatePlayer2(player2, "|O|");
            //StartGame method invoked
            StartGame(player, second);
        }

       //Input Players
        static Player CreatePlayer1(string name, string marker)
        {
            Player player1 = new Player(name, marker);
            return player1;
        }

        static Player CreatePlayer2(string name, string marker)
        {
            Player player2 = new Player(name, marker);
            return player2;

        }

        /// creating 3x3 game board matrix
        static string[,] CreateBoard()
        {
            TheBoard board = new TheBoard();
            string[,] gameBoard = new string[,] { { board.Pos1, board.Pos2, board.Pos3 },
                { board.Pos4, board.Pos5, board.Pos6 },
                { board.Pos7, board.Pos8, board.Pos9 } };
            return gameBoard;
        }

        static void DisplayBoard(string[,] board)
        {
            //goes through the outer array
            for (int i = 0; i < 3; i++)
            {
                //goes through inner array
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.WriteLine(Environment.NewLine);
            }

        }

      
        static void StartGame(Player player1, Player player2)
        {
            string[,] board = CreateBoard();
            DisplayBoard(board);
            // Used to end the game in case of draw
            byte counter = 0;
            PlayerOneTurn(board, player1, player2, counter);
        }

       
        static void PlayerOneTurn(string[,] board, Player player1, Player player2, byte counter)
        {
            Console.WriteLine($"{player1.Name} it is your turn. Please choose a location.");
            string choice = Console.ReadLine();
            string selection = "|" + choice + "|";
            bool check = CheckIfSpaceOpen(selection, board);
            //if check is true, means the space is available
            //if check is false, means space is occupied
            if (check == false)
            {
                PlayerOneTurn(board, player1, player2, counter);
            }
            board = UpdateBoard(selection, board, player1);
            counter++;
            CheckForWinner(board, player1, player2, counter);
            PlayerTwoTurn(board, player1, player2, counter);
        }

      
        static void PlayerTwoTurn(string[,] board, Player player1, Player player2, byte counter)
        {
            Console.WriteLine($"{player2.Name} it is your turn. Please choose a location.");
            string choice = Console.ReadLine();
            string selection = "|" + choice + "|";
            bool check = CheckIfSpaceOpen(selection, board);
            //if check is true, means the space is available
            //if check is false, means space is occupied
            if (check == false)
            {
                PlayerTwoTurn(board, player1, player2, counter);
            }
            board = UpdateBoard(selection, board, player2);
            counter++;
            CheckForWinner(board, player2, player1, counter);
            PlayerOneTurn(board, player1, player2, counter);
        }

    
        static bool CheckIfSpaceOpen(string selection, string[,] board)
        {
            bool check = false;
            // arrays to pass current row values into
            string[] rowOne = new string[3];
            string[] rowTwo = new string[3];
            string[] rowThree = new string[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //puts all of the top row into rowOne
                    if (i == 0)
                    {
                        rowOne[j] = board[i, j];
                    }
                    //puts all of the middle row into rowTwo
                    if (i == 1)
                    {
                        rowTwo[j] = board[i, j];
                    }
                    //puts all of the bottom row into rowThree
                    if (i == 2)
                    {
                        rowThree[j] = board[i, j];
                    }
                }
            }
          
            if (Array.IndexOf(rowOne, selection) >= 0)
            {
                check = true;
            }
            if (Array.IndexOf(rowTwo, selection) >= 0)
            {
                check = true;
            }
            if (Array.IndexOf(rowThree, selection) >= 0)
            {
                check = true;
            }

            return check;

        }

    
        static string[,] UpdateBoard(string selection, string[,] board, Player player)
        {
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == selection)
                    {
                        board[i, j] = player.Mark;
                    }
                }
            }

            DisplayBoard(board);
            return board;
        }

      
        static void CheckForWinner(string[,] board, Player player, Player loser, byte counter)
        {
            for (int i = 0; i < 3; i++)
            {
                //checks for horizontal winner
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                {
                    Console.WriteLine($"{player.Name} Wins!!! Do you want to play again?");
                    string answer = Console.ReadLine().ToUpper();
                    EndOfGame(answer, player, loser);
                }
                //checks for vertical winner
                if (board[0, i] == board[1, i] && board[0, i] == board[2, i])
                {
                    Console.WriteLine($"{player.Name} Wins!!! Do you want to play again?");
                    string answer = Console.ReadLine().ToUpper();
                    EndOfGame(answer, player, loser);
                }

            }

            //check for diagonal winner
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                Console.WriteLine($"{player.Name} Wins!!! Do you want to play again?");
                string answer = Console.ReadLine().ToUpper();
                EndOfGame(answer, player, loser);
            }

            if (board[2, 0] == board[1, 1] && board[2, 0] == board[0, 2])
            {
                Console.WriteLine($"{player.Name} Wins!!! Do you want to play again?");
                string answer = Console.ReadLine().ToUpper();
                EndOfGame(answer, player, loser);
            }
            // check for a draw
            if (counter == 9)
            {
                Console.WriteLine("It is a draw!");
                string answer = Console.ReadLine().ToUpper();
                EndOfGame(answer, player, loser);
            }

        }

        static void EndOfGame(string answer, Player player1, Player player2)
        {
            if (answer == "Y" || answer == "YES")
            {
                Console.WriteLine($"{player1.Name} goes first.");
                StartGame(player1, player2);
            }
            else if (answer == "N" || answer == "NO")
            {
                Console.WriteLine("Thanks for playing! Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I will take that as a no...");
                Environment.Exit(0);
            }

        }



        public static string Convert(int number)
        {

            //If the number is divisible by 3 AND 5, then run this statemetn
            if (number % 3 == 0 && number % 5 == 0)
            {

                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                // Amanda 3.20.18 - Added this code per Janine on 3.15
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                //TODO:
                return "Buzz";
            }

            return number.ToString();
        }

    }
}
