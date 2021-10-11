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
            
            for (int col = currentSquare.Col + 1; col <= 7; col++)
            {
                for (int row = currentSquare.Row - 1; row >= 0; row--)
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

                    if (nextPiece == null || nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                    }
                }
            }
            
            // rightdown row+1 col +1
            
            for (int col = currentSquare.Col + 1; col <= 7; col++)
            {
                for (int row = currentSquare.Row +1; row <= 7; row++)
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

                    if (nextPiece == null || nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                    }
                }
            }
            // leftup row-1, col-1
            
            for (int col = currentSquare.Col - 1; col >= 0; col--)
            {
                for (int row = currentSquare.Row - 1; row >= 0; row--)
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

                    if (nextPiece == null || nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                    }
                }
            }
            
            // leftdown row+1, col-1
            
            for (int col = currentSquare.Col - 1; col >= 0; col--)
            {
                for (int row = currentSquare.Row +1; row <= 7; row++)
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

                    if (nextPiece == null || nextPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                    }
                }
            }
            
            // down row+1, col

            for (int row = currentSquare.Row +1; row <= 7; row++)
            {
                var col = currentSquare.Col;
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

                if (nextPiece == null || nextPiece.Player != Player)
                {
                    moves.Add(nextSquare);
                }
            }
            
            // up row-1 col
            
            for (int row = currentSquare.Row -1; row >= 0; row--)
            {
                var col = currentSquare.Col;
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

                if (nextPiece == null || nextPiece.Player != Player)
                {
                    moves.Add(nextSquare);
                }
            }
            
            
            // right row, col+1
            
            for (int col = currentSquare.Col +1; col <= 7; col++)
            {
                
                var row = currentSquare.Row;
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

                if (nextPiece == null || nextPiece.Player != Player)
                {
                    moves.Add(nextSquare);
                }
            }
            
            
            
            //left row, column-1
            
            for (int col = currentSquare.Col -1; col >= 0; col--)
            {
                
                var row = currentSquare.Row;
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

                if (nextPiece == null || nextPiece.Player != Player)
                {
                    moves.Add(nextSquare);
                }
            }


            
            return moves;
        }
    }
}
