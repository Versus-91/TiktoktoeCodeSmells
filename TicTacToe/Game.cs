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

        public char Winner()
        {   //if the positions in first row are taken
            if(_board.TileAt(0, 0).Symbol != PlayerSymbols.Empty &&
               _board.TileAt(0, 1).Symbol != PlayerSymbols.Empty &&
               _board.TileAt(0, 2).Symbol != PlayerSymbols.Empty)
               {
                    //if first row is full with same symbol
                    if (_board.TileAt(0, 0).Symbol == 
                        _board.TileAt(0, 1).Symbol &&
                        _board.TileAt(0, 2).Symbol == 
                        _board.TileAt(0, 1).Symbol )
                        {
                            return _board.TileAt(0, 0).Symbol;
                        }
               }
                
             //if the positions in first row are taken
             if(_board.TileAt(1, 0).Symbol != PlayerSymbols.Empty &&
                _board.TileAt(1, 1).Symbol != PlayerSymbols.Empty &&
                _board.TileAt(1, 2).Symbol != PlayerSymbols.Empty)
                {
                    //if middle row is full with same symbol
                    if (_board.TileAt(1, 0).Symbol == 
                        _board.TileAt(1, 1).Symbol &&
                        _board.TileAt(1, 2).Symbol == 
                        _board.TileAt(1, 1).Symbol)
                        {
                            return _board.TileAt(1, 0).Symbol;
                        }
                }

            //if the positions in first row are taken
             if(_board.TileAt(2, 0).Symbol != PlayerSymbols.Empty &&
                _board.TileAt(2, 1).Symbol != PlayerSymbols.Empty &&
                _board.TileAt(2, 2).Symbol != PlayerSymbols.Empty)
                {
                    //if middle row is full with same symbol
                    if (_board.TileAt(2, 0).Symbol == 
                        _board.TileAt(2, 1).Symbol &&
                        _board.TileAt(2, 2).Symbol == 
                        _board.TileAt(2, 1).Symbol)
                        {
                            return _board.TileAt(2, 0).Symbol;
                        }
                }

            return PlayerSymbols.Empty;
        }
    }
}