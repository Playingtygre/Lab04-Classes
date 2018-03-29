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

        [InlineData("Tiger", "X")]
        public void CanReturnName(string name, string marker)
        {
            Assert.Equal(CreatePlayer1 (name, marker));
        }


  
    }
}