using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        private List<Tile> _plays = new List<Tile>();
        public const int rowSize = 3;
        public Board()
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < rowSize; j++)
                {
                    _plays.Add(new Tile { X = i, Y = j});
                }
            }
        }
        public Tile TileAt(int x, int y)
        {
            return _plays.Single(tile => tile.X == x && tile.Y == y);
        }

        public void AddTileAt(char symbol, int x, int y)
        {
            _plays.Single(tile => tile.X == x && tile.Y == y).Symbol = symbol;
        }

    }
}
