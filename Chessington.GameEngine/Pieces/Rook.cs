using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            List<Square> moves = new List<Square>();

            int direction;
            int right;
            int left;
            
            if (Player == Player.White)
            {
                direction = -1;
                right = 1;
                left = -1;
            }
            else
            {
                direction = 1;
                right = -1;
                left = 1;
            }
            
            
            // moving right
            for (int index = currentSquare.Col + 1; index <= 7; index++)
            {
                var nextSquare = new Square(currentSquare.Row, index);
                var rightPiece = board.GetPiece(nextSquare);

                if (rightPiece != null)
                {
                    if (rightPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                    }

                    break;
                }
                
                moves.Add(nextSquare);
            }

            //moving left
            
            for (int index = currentSquare.Col - 1; index >= 0; index--)
            {
                var nextSquare = new Square(currentSquare.Row, index);
                var leftPiece = board.GetPiece(nextSquare);

                if (leftPiece != null)
                {
                    if (leftPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                    }

                    break;
                }
                
                moves.Add(nextSquare);
            }
            
            //moving up
            
            for (int index = currentSquare.Row - 1; index >= 0; index--)
            {
                var nextSquare = new Square(index, currentSquare.Col);
                var upPiece = board.GetPiece(nextSquare);

                if (upPiece != null)
                {
                    if (upPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                    }

                    break;
                }
                
                moves.Add(nextSquare);
            }
            
            //moving down
            
            for (int index = currentSquare.Row + 1; index <= 7; index++)
            {
                var nextSquare = new Square(index, currentSquare.Col);
                var downPiece = board.GetPiece(nextSquare);

                if (downPiece != null)
                {
                    if (downPiece.Player != Player)
                    {
                        moves.Add(nextSquare);
                    }

                    break;
                }
                
                moves.Add(nextSquare);
            }
            
            return moves;
            
            
            

        }
    }
}