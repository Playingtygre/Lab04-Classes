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

        /*
        [Theory]
        [InlineData("phil", "X", "phil")]

        public void CanCreatePlayerOne(string testName, string testMarker, Player testPlayer)
        {
            Assert.Equal(testPlayer.Name, CanCreatePlayerOne(testName, testMarker));
        }*/

        
        [Theory]

        [InlineData("Tiger", "X")]
        public void CanReturnName(string name, string marker)
        {
            Assert.Equal(CreatePlayer1(name, marker));
        }


        /*
        [Theory]
        [InlineData("i", 3)]

        public void CanReturn(string selection, string[,] board)
        {
            Assert.True(CheckIfSpaceOpen(selection, board));
        }*/

        /*
        [Theory]
        [InlineData(3)]
        public void CanReturn(int value)
        {
            Assert.Equal("Fizz", Convert(value));
        }*/




    }
}