using TicTacToe;
using Xunit;

namespace TicTacToeTest
{
    public class TicTacToeMapTest
    {
        [Fact]
        public void GetDiagonalesTest()
        {
            //Arrange
            var board = new int[3, 3] { { 1, 0, 1 }, { 0, 2, 0 }, { 0, 0, 0 } };
            var map = new TicTacToeMap(board);
            //Act
            var diagonales = map.GetDiagonales();
            //Assert
            Assert.NotNull(diagonales);
            Assert.Equal(2, diagonales.Count());
            Assert.Equal(1, diagonales[0][0]);
            Assert.Equal(2, diagonales[0][1]);
            Assert.Equal(0, diagonales[0][2]);
            Assert.Equal(1, diagonales[1][0]);
            Assert.Equal(2, diagonales[1][1]);
            Assert.Equal(0, diagonales[1][2]);
        }

        [Fact]
        public void GetColumnsTest()
        {
            //Arrange
            var board = new int[3, 3] { { 1, 0, 1 }, { 0, 2, 0 }, { 0, 0, 0 } };
            var map = new TicTacToeMap(board);
            //Act
            var columns = map.GetColumns();
            //Assert
            Assert.NotNull(columns);
            Assert.Equal(3, columns.Count());
            Assert.Equal(1, columns[0][0]);
            Assert.Equal(0, columns[0][1]);
            Assert.Equal(0, columns[0][2]);
            Assert.Equal(0, columns[1][0]);
            Assert.Equal(2, columns[1][1]);
            Assert.Equal(0, columns[1][2]);
            Assert.Equal(1, columns[2][0]);
            Assert.Equal(0, columns[2][1]);
            Assert.Equal(0, columns[2][2]);
        }

        [Fact]
        public void GetRowsTest()
        {
            //Arrange
            var board = new int[3, 3] { { 1, 0, 1 }, { 0, 2, 0 }, { 0, 0, 0 } };
            var map = new TicTacToeMap(board);
            //Act
            var rows = map.GetRows();
            //Assert
            Assert.NotNull(rows);
            Assert.Equal(3, rows.Count());
            Assert.Equal(1, rows[0][0]);
            Assert.Equal(0, rows[0][1]);
            Assert.Equal(1, rows[0][2]);
            Assert.Equal(0, rows[1][0]);
            Assert.Equal(2, rows[1][1]);
            Assert.Equal(0, rows[1][2]);
            Assert.Equal(0, rows[2][0]);
            Assert.Equal(0, rows[2][1]);
            Assert.Equal(0, rows[2][2]);
        }
    }
}