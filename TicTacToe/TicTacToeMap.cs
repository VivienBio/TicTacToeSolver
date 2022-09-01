namespace TicTacToe
{
    public class TicTacToeMap
    {
        public int[,] Map { get; private set; }
        public int Length { get; private set; }

        public TicTacToeMap(int[,] map)
        {
            Length = map.GetLength(1);
            Map = map;
        }

        public List<List<int>> GetDiagonales()
        {
            var diagonales = new List<List<int>>();
            var diag1 = new List<int>();
            var diag2 = new List<int>();
            for (var i = 0; i < Length; i++)
            {
                diag1.Add(Map[i, i]);
                diag2.Add(Map[i, Length - i - 1]);
            }
            diagonales.Add(diag1);
            diagonales.Add(diag2);   
            return diagonales;
        }

        public List<List<int>> GetColumns()
        {
            var columns = new List<List<int>>();
            for (var columnNumber = 0; columnNumber < Length; columnNumber++)
            {
                var c = Enumerable.Range(0, Length)
                    .Select(x => Map[x, columnNumber])
                    .ToList();
                columns.Add(c);
            }
            return columns;
        }

        public List<List<int>> GetRows()
        {
            var rows = new List<List<int>>();
            for (var rowNumber = 0; rowNumber < Length; rowNumber++)
            {         
                var c = Enumerable.Range(0, Length)
                    .Select(x => Map[rowNumber, x])
                    .ToList();
                rows.Add(c);
            }
            return rows;
        }
    }
}