using System;

namespace TicTacToe
{
    class Program
    {

       
     
   
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Hello World!");

            //Type name = new type
            // tiger is a new object of the person class   
            Person tiger = new Person();


            Person jeannie = new Person();
            jeannie.SayHi();

            tiger.Dance();

            tiger.Name = "Hsu"; // set grabing the value of the name
            string name = tiger.Name; //grabing the value of the name

            Console.WriteLine(name);


            Console.WriteLine("Tiger " + tiger.SayHi());
            Console.WriteLine("Jeannie" + jeannie.SayHi());
            Console.WriteLine(tiger.Goodbye());
            Console.ReadLine();



        }

        



    }
}
