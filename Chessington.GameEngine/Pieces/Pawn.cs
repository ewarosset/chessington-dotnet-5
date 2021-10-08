using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            List<Square> moves = new List<Square>();

            int direction;
            
            if (Player == Player.White)
            {
                direction = -1;
            }
            else
            {
                direction = 1;
            }
            
            // is there piece in front of us (one space)

            var nextSquare = new Square(currentSquare.Row + (direction), currentSquare.Col);
            

            if (board.GetPiece(nextSquare)== null)
            {
                moves.Add(nextSquare);
                var nextTwoSquare = new Square(currentSquare.Row + (direction * 2), currentSquare.Col);
                
                if (this.numberOfMoves == 0 && board.GetPiece(nextTwoSquare) == null)
                {
                    //we are now checking if the second square is also empty
                    moves.Add(nextTwoSquare);
                }
            }
            
            else
            {
                
            }
            return moves;

        }
    }
}