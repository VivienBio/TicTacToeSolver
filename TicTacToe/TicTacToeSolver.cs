namespace TicTacToe
{
    public static class TicTacToeSolver
    {
        public static int? GetWinnerLine(List<int> line)
        {
            if (line.All(l => l == 1) || line.All(l => l == 2))
                return line.First();
            return null;
        }

        public static int? GetWinner(TicTacToeMap map)
        {   
           var lines = GetLines(map);

            foreach (var line in lines)
            {
                var winner = GetWinnerLine(line);
                if (winner.HasValue)
                    return winner.Value;
            }

            return null;
        }

        private static List<List<int>> GetLines(TicTacToeMap map)
        {
            var lines = new List<List<int>>();

            var rows = map.GetRows();
            var columns = map.GetColumns();
            var diagonales = map.GetDiagonales();

            lines.AddRange(rows);
            lines.AddRange(columns);
            lines.AddRange(diagonales);

            return lines;
        }
    }
}