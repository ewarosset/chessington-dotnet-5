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
            var currentSqure = board.FindPiece(this);
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
            
            moves.Add(new Square(currentSqure.Row+(direction), currentSqure.Col));
            return moves;

        }
    }
}