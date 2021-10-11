using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player)
        {
        }

        

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            List<Square> moves = new List<Square>();

            for (int col = currentSquare.Col - 1; col <= currentSquare.Row + 1; col++)
            {
                for (int row = currentSquare.Row - 1; row <= currentSquare.Row + 1; row++)
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
            
            return moves;

        }
    }
}