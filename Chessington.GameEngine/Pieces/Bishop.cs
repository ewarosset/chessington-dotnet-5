using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            List<Square> moves = new List<Square>();

            // rightup row-1 col+1

            for (int index = 1; index <= 7; index++)
            {
                var col = currentSquare.Col + index;
                var row = currentSquare.Row - index;

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

            return moves;
        }
    }
}