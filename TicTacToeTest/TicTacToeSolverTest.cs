using TicTacToe;
using Xunit;

namespace TicTacToeTest
{
    public class TicTacToeSolverTest
    {
        [Fact]
        public void GetWinnerLineTest_Player1Win()
        {
            //Arrange
            var line = new List<int>(){ 1,1,1};
            //Act
            var winner = TicTacToeSolver.GetWinnerLine(line);
            //Assert
            Assert.NotNull(winner);
            Assert.Equal(1, winner);
        }

        [Fact]
        public void GetWinnerLineTest_NoWinner()
        {
            //Arrange
            var line = new List<int>() { 1, 2, 1 };
            //Act
            var winner = TicTacToeSolver.GetWinnerLine(line);
            //Assert
            Assert.Null(winner);     
        }

        [Fact]
        public void GetWinnerTest_NoWinner()
        {
            //Arrange
          var  board = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            var map = new TicTacToeMap(board);
            //Act
            var winner = TicTacToeSolver.GetWinner(map);
            //Assert
            Assert.Null(winner);        
        }


        [Fact]
        public void GetWinnerTest_Player1WinColumn()
        {
            //Arrange
            var board = new int[3, 3] { { 2, 0, 1 }, { 0, 0, 1 }, { 0, 2, 1 } };
            var map = new TicTacToeMap(board);
            //Act
            var winner = TicTacToeSolver.GetWinner(map);
            //Assert
            Assert.NotNull(winner);
            Assert.Equal(1, winner);
        }


        [Fact]
        public void GetWinnerTest_Player1WinRow()
        {
            //Arrange
            var board = new int[3, 3] { { 2, 2, 0 }, { 1, 1, 1 }, { 2, 0, 0 } };
            var map = new TicTacToeMap(board);
            //Act
            var winner = TicTacToeSolver.GetWinner(map);
            //Assert
            Assert.NotNull(winner);
            Assert.Equal(1, winner);
        }


        [Fact]
        public void GetWinnerTest_Player1WinDiagonal()
        {
            //Arrange
            var board = new int[3, 3] { { 0, 0, 1 }, { 2, 1, 2 }, { 1, 1, 2 } };
            var map = new TicTacToeMap(board);
            //Act
            var winner = TicTacToeSolver.GetWinner(map);
            //Assert
            Assert.NotNull(winner);
            Assert.Equal(1, winner);
        }
    }
}