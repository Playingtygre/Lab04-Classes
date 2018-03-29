using System;

namespace TicTacToe
{
    class Program
    {

       
     
   
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World, Lets Play TicTacToe");
            EnterPlayers();




           


        }

        // enters players names
        static void EnterPlayers()
        {
            Console.WriteLine("Lets Play TicTacToe: what is your name?");
            string PlayerOne = (Console.ReadLine());
            Console.WriteLine(PlayerOne + " " +"Greeting you will be X");

            Console.WriteLine("what is your name of player 2");
            string PlayerTwo = (Console.ReadLine());
            Console.WriteLine(PlayerTwo + " " + "Greeting you will be 0");
        } 

        



    }
}
