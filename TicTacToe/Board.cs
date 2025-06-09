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

        public Board()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
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
        public void ValidateMove(char symbol,char lastSymbol,int x, int y)
        {
            //if first move
            if (IsFirstMove(lastSymbol,symbol))
            {
               throw new Exception("Invalid first player");
            }
            //if not first move but player repeated
            else
            {
                if (symbol == lastSymbol)
                {
                    throw new Exception("Invalid next player");
                }
                //if not first move but play on an already played tile
                else if (TileAt(x, y).Symbol != ' ')
                {
                    throw new Exception("Invalid position");
                }
            }
        }
        public bool IsFirstMove(char lastSymbol,char symbol)
        {
            return lastSymbol == ' ' && symbol == 'O';
        }
    }
}
