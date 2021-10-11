using System.Linq;
using Chessington.GameEngine.Pieces;
using FluentAssertions;
using NUnit.Framework;

namespace Chessington.GameEngine.Tests.Pieces
{
    [TestFixture]
    public class RookTests
    {

        [Test]

        public void Rook_CanMoveUp()
        {
            var board = new Board();
            var rook = new Rook(Player.White);
            
            board.AddPiece(Square.At(4, 0), rook);

            var moves = rook.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(3, 0));
            moves.Should().Contain(Square.At(2, 0));
            moves.Should().Contain(Square.At(1, 0));
            moves.Should().Contain(Square.At(0, 0));
            
        }
        [Test]
        public void Rook_CanMoveDown()
        {
            var board = new Board();
            var rook = new Rook(Player.White);
            
            board.AddPiece(Square.At(4, 0), rook);

            var moves = rook.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(5, 0));
            moves.Should().Contain(Square.At(6, 0));
            moves.Should().Contain(Square.At(7, 0));
            
        }

        [Test]
        public void Rook_CanMoveRight()
        {
            var board = new Board();
            var rook = new Rook(Player.White);
            
            board.AddPiece(Square.At(4, 4), rook);

            var moves = rook.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(4, 5));
            moves.Should().Contain(Square.At(4, 6));
            moves.Should().Contain(Square.At(4, 7));
        }
        
        [Test]
        public void Rook_CanMoveLeft()
        {
            var board = new Board();
            var rook = new Rook(Player.White);
            
            board.AddPiece(Square.At(4, 4), rook);

            var moves = rook.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(4, 3));
            moves.Should().Contain(Square.At(4, 2));
            moves.Should().Contain(Square.At(4, 1));
            moves.Should().Contain(Square.At(4, 0));
        }
        
        [Test]
        public void Rook_BlockedByPiece()
        {
            var board = new Board();
            var rook = new Rook(Player.White);
            var blockingPiece = new Pawn(Player.White);
            board.AddPiece(Square.At(1, 3), rook);
            board.AddPiece(Square.At(2, 3), blockingPiece);
 

            var moves = rook.GetAvailableMoves(board);

            moves.Should().NotContain(Square.At(2, 3));
            moves.Should().NotContain(Square.At(3, 3));
            moves.Should().NotContain(Square.At(4, 3));
        }
        
        [Test]
        public void Rook_CanCapture()
        {
            var board = new Board();
            var rook = new Rook(Player.White);
            var firstTarget = new Pawn(Player.Black);
            var secondTarget = new Pawn(Player.Black);
            var thirdTarget = new Pawn(Player.Black);
            
            board.AddPiece(Square.At(7, 3), rook);
            board.AddPiece(Square.At(6, 3), firstTarget);
            board.AddPiece(Square.At(7, 4), secondTarget);
            board.AddPiece(Square.At(7, 2), thirdTarget);

            var moves = rook.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(6, 3));
            moves.Should().Contain(Square.At(7, 4));
            moves.Should().Contain(Square.At(7, 2));
        }
        
        


    }
}