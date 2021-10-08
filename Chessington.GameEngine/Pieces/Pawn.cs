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
            
            
            var nextSquare = new Square(currentSquare.Row + (direction), currentSquare.Col); 
            
            // is there piece in front of us (one space)
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
            
            // is there a piece diagonally to the right


            if ((currentSquare.Col + right) >= 0 && (currentSquare.Col + right) <= 7)
            {
                var diagonalRight = new Square(currentSquare.Row + (direction), currentSquare.Col + right);
                if (board.GetPiece(diagonalRight) != null)
                {
                    moves.Add(diagonalRight);
                }
            }
            
            // is there a piece diagonally to the left
            if ((currentSquare.Col + left) >= 0 && (currentSquare.Col + left) <= 7){
                
                var diagonalLeft = new Square(currentSquare.Row + (direction), currentSquare.Col + left);
                    if (board.GetPiece(diagonalLeft) != null)
                    {
                        moves.Add(diagonalLeft);
                    } 
            }
            
            return moves;

        }
    }
}