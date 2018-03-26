using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Person
    {

        private string Name //
        //this is the set up for a person 

        //access modifier, return type, calling the property name {getter , setter(changes) }
        public string Name { get; set; }



        public String SayHi()
        {
            return "hello";
        }

        public String Goodbye()
        {
            return "GoodBye";
        }

        public String Dance()
        {
            return "yes";
        }

    }
}
