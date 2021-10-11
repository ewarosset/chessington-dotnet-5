using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            List<Square> moves = new List<Square>();
            
            
            // rightdown row+1 col +1
            
            for (int index = 1; index <= 7; index++)
            {
                var col = currentSquare.Col + index;
                var row = currentSquare.Row + index;
                {
                    Console.WriteLine("row: " + row + "col: " + col);

                    if (!board.IsWithinBoardInt(row, col))
                    {
                        continue;
                    }

                    if (currentSquare == new Square(row, col))
                    {
                        continue;
                    }

                    var nextSquare = new Square(row, col);
                    var nextPiece = board.GetPiece(nextSquare);

                    if (nextPiece != null && nextPiece.Player == Player)
                    {
                        break;
                    }
                    
                    if (nextPiece != null && nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                        break;
                    }
                    
                    moves.Add(nextSquare);
                }
            }
            // leftup row-1, col-1
            
            for (int index = 1; index <= 7; index++)
            {
                var col = currentSquare.Col - index;
                var row = currentSquare.Row - index;
                {
                    Console.WriteLine("row: " + row + "col: " + col);

                    if (!board.IsWithinBoardInt(row, col))
                    {
                        continue;
                    }

                    if (currentSquare == new Square(row, col))
                    {
                        continue;
                    }

                    var nextSquare = new Square(row, col);
                    var nextPiece = board.GetPiece(nextSquare);

                    if (nextPiece != null && nextPiece.Player == Player)
                    {
                        break;
                    }
                    
                    if (nextPiece != null && nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                        break;
                    }
                    
                    moves.Add(nextSquare);
                }
            }
            
            // leftdown row+1, col-1
            
            for (int index = 1; index <= 7; index++)
            {
                var col = currentSquare.Col - index;
                var row = currentSquare.Row + index;
                {
                    Console.WriteLine("row: " + row + "col: " + col);

                    if (!board.IsWithinBoardInt(row, col))
                    {
                        continue;
                    }

                    if (currentSquare == new Square(row, col))
                    {
                        continue;
                    }

                    var nextSquare = new Square(row, col);
                    var nextPiece = board.GetPiece(nextSquare);

                    if (nextPiece != null && nextPiece.Player == Player)
                    {
                        break;
                    }
                    
                    if (nextPiece != null && nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                        break;
                    }
                    
                    moves.Add(nextSquare);
                }
            }
            
            // down row+1, col

            for (int index = 1; index <= 7; index++)
            {
                var col = currentSquare.Col;
                var row = currentSquare.Row + index;
                {
                    Console.WriteLine("row: " + row + "col: " + col);

                    if (!board.IsWithinBoardInt(row, col))
                    {
                        continue;
                    }

                    if (currentSquare == new Square(row, col))
                    {
                        continue;
                    }

                    var nextSquare = new Square(row, col);
                    var nextPiece = board.GetPiece(nextSquare);

                    if (nextPiece != null && nextPiece.Player == Player)
                    {
                        break;
                    }
                    
                    if (nextPiece != null && nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                        break;
                    }
                    
                    moves.Add(nextSquare);
                }
            }
            
            // up row-1 col
            
            for (int index = 1; index <= 7; index++)
            {
                var col = currentSquare.Col;
                var row = currentSquare.Row - index;
                {
                    Console.WriteLine("row: " + row + "col: " + col);

                    if (!board.IsWithinBoardInt(row, col))
                    {
                        continue;
                    }

                    if (currentSquare == new Square(row, col))
                    {
                        continue;
                    }

                    var nextSquare = new Square(row, col);
                    var nextPiece = board.GetPiece(nextSquare);

                    if (nextPiece != null && nextPiece.Player == Player)
                    {
                        break;
                    }
                    
                    if (nextPiece != null && nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                        break;
                    }
                    
                    moves.Add(nextSquare);
                }
            }
            
            
            // right row, col+1
            
            for (int index = 1; index <= 7; index++)
            {
                var col = currentSquare.Col + index;
                var row = currentSquare.Row;
                {
                    Console.WriteLine("row: " + row + "col: " + col);

                    if (!board.IsWithinBoardInt(row, col))
                    {
                        continue;
                    }

                    if (currentSquare == new Square(row, col))
                    {
                        continue;
                    }

                    var nextSquare = new Square(row, col);
                    var nextPiece = board.GetPiece(nextSquare);

                    if (nextPiece != null && nextPiece.Player == Player)
                    {
                        break;
                    }
                    
                    if (nextPiece != null && nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                        break;
                    }
                    
                    moves.Add(nextSquare);
                }
            }
            
            
            
            //left row, column-1
            
            for (int index = 1; index <= 7; index++)
            {
                var col = currentSquare.Col - index;
                var row = currentSquare.Row;
                {
                    Console.WriteLine("row: " + row + "col: " + col);

                    if (!board.IsWithinBoardInt(row, col))
                    {
                        continue;
                    }

                    if (currentSquare == new Square(row, col))
                    {
                        continue;
                    }

                    var nextSquare = new Square(row, col);
                    var nextPiece = board.GetPiece(nextSquare);

                    if (nextPiece != null && nextPiece.Player == Player)
                    {
                        break;
                    }
                    
                    if (nextPiece != null && nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                        break;
                    }
                    
                    moves.Add(nextSquare);
                }
            }


            
            return moves;
        }
    }
}
