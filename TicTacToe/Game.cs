using System;
using System.Linq;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Game
    {
        private char _lastSymbol = PlayerSymbols.Empty;
        private Board _board = new Board();
        private BoardValidator _boardValidator = new BoardValidator();


        public void Play(char symbol, int x, int y)
        {
            // update game state
            _boardValidator.ValidateMove(symbol, _lastSymbol, x, y, _board.TileAt(x, y).Symbol);
            _lastSymbol = symbol;
            _board.AddTileAt(symbol, x, y);
        }

        public char Winner(){
            for (int i = 0; i < Board.rowSize; i++)
            {
                //if the positions in row are taken
                if (!IsEmptyRow(i, _board))
                {
                    //if row is full with same symbol
                    if (AreRowSymbolsEqual(i, _board))
                    {
                        return _board.TileAt(i, 0).Symbol;
                    }
                }
            }


            return PlayerSymbols.Empty;
        }
        private bool IsEmptyRow(int rowIndex, Board board) {
            return board.TileAt(rowIndex, 0).Symbol == PlayerSymbols.Empty &&
                  board.TileAt(rowIndex, 1).Symbol == PlayerSymbols.Empty &&
                  board.TileAt(rowIndex, 2).Symbol == PlayerSymbols.Empty;
        }
        private bool AreRowSymbolsEqual(int rowIndex, Board board)
        {
            return _board.TileAt(rowIndex, 0).Symbol ==
                        _board.TileAt(rowIndex, 1).Symbol &&
                        _board.TileAt(rowIndex, 2).Symbol ==
                        _board.TileAt(rowIndex, 1).Symbol;
        }
    }
}