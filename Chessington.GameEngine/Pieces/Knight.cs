using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            List<Square> moves = new List<Square>();

            var newList1 = new List<int>() {-2, 2};
            var newList2 = new List<int>() {-1, 1};

            foreach (var twos  in newList1)
            {
                foreach (var ones in newList2)
                {
                    Console.WriteLine("Row: " + twos + "Col: " + ones);
                    Console.WriteLine("Row: " + ones + "Col: " + twos);
                    
                    Console.WriteLine("currentRow: " + currentSquare.Row + "currentCol: " + currentSquare.Col);
                    
                    

                    if (board.IsWithinBoardInt(currentSquare.Row + twos, currentSquare.Col + ones))
                    {
                        Console.WriteLine("This is not working");
                        var target1 = new Square(currentSquare.Row + twos, currentSquare.Col + ones);
                        Console.WriteLine("Row target1: " + (currentSquare.Row + twos) + "Col: " +  (currentSquare.Col + ones));
                        
                        
                        var target1Piece = board.GetPiece(target1);
                        if (target1Piece == null || target1Piece.Player != Player)
                        {
                            moves.Add(target1);
                            Console.WriteLine(moves.Count);
                        }
                    }

                    if (board.IsWithinBoardInt(currentSquare.Row + ones, currentSquare.Col + twos))
                    {
                        var target2 = new Square(currentSquare.Row + ones, currentSquare.Col + twos);
                        Console.WriteLine("Row target1: " + (currentSquare.Row + ones) + "Col: " +  (currentSquare.Col + twos));
                        
                        var target2Piece = board.GetPiece(target2);
                        
                        if (target2Piece == null || target2Piece.Player != Player)
                        {
                            moves.Add(target2);
                            Console.WriteLine(moves.Count);
                        }
                    }
                }
            }

            // Row, Col
            // left
            // row-2, col-1
            // row-1, col-2
            // row+1, col-2
            // row+2, col-1
            
            // right
            // row-2, col+1
            // row-1, col+2
            // row+1, col+2
            // row+2, col+1
            
            

            return moves;
        }
    }
}