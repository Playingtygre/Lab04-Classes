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

 
       /* public void CanCreatePlayerOne(string testName, string testMarker, Player testPlayer)
        {
            Assert.Equal(testPlayer.Name, CanCreatePlayerOne(testName, testMarker));
        }*/
    }
}