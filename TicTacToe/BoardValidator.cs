using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class BoardValidator
    {
        public void ValidateMove(char symbol, char lastSymbol, int x, int y,char symbolAtTile)
        {
            //if first move
            if (IsFirstMove(lastSymbol, symbol))
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
                else if (symbolAtTile != ' ')
                {
                    throw new Exception("Invalid position");
                }
            }
        }
        public bool IsFirstMove(char lastSymbol, char symbol)
        {
            return lastSymbol == PlayerSymbols.Empty && symbol == PlayerSymbols.O;
        }
    }
}
