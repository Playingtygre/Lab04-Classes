using System;
using Xunit;
using TicTacToe;
using static TicTacToe.Program;


namespace TicTacToeTest
{
    public class UnitTest1
    {

        [Fact]
        public void CanReturn1()
        {
            Assert.Equal("1", Convert(1));
        }

        [Theory]
        [InlineData("Tiger")]
        [InlineData("John")]
        [InlineData("Tony")]
        [InlineData("Josh")]
        [InlineData("Daniel")]
        public void CanReturnName(string name)
        {
            Player player1 = new Player(name, "F");
            
            Assert.Equal(name, CreatePlayer1(name, "F").Name);
        }


        //calling the method 1 paremeters; need a compare marker
        [Theory]
        [InlineData("X")]
        [InlineData("O")]
        [InlineData("B")]
        [InlineData("Y")]
        // unit test marker = x passes thru thsi method CanReturnMark
        public void CanReturnMark(string marker)
        {
            Player player1 = new Player("Rickard", marker);
            Player actualPlayer = CreatePlayer1("Rickard", marker);
            string actualPlayerMark = actualPlayer.Mark;

            Assert.Equal(marker, actualPlayerMark);
        }
        
    }//bottom of the unit test
    // method and instatnce must match the argument.
    //method call is like a player object. 
}