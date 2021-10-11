using System.Linq;
using Chessington.GameEngine.Pieces;
using FluentAssertions;
using NUnit.Framework;

namespace Chessington.GameEngine.Tests.Pieces
{
    [TestFixture]
    public class BishopTests
    {
        [Test]
        public void CanMoveDiagonallyRightUp()
        {
            var board = new Board();
            var bishop = new Bishop(Player.White);
            board.AddPiece(Square.At(4, 0), bishop);

            var moves = bishop.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(3, 1));
            moves.Should().Contain(Square.At(2, 2));
            moves.Should().Contain(Square.At(1, 3));
            moves.Should().Contain(Square.At(0, 4));
        }
        
        [Test]
        public void CanMoveDiagonallyRightDown()
        {
            
            var board = new Board();
            var bishop = new Bishop(Player.White);
            board.AddPiece(Square.At(4, 0), bishop);

            var moves = bishop.GetAvailableMoves(board).ToList();
            
            moves.Should().Contain(Square.At(5, 1));
            moves.Should().Contain(Square.At(6, 2));
            moves.Should().Contain(Square.At(7, 3));
        }
        
        [Test]
        public void CanMoveDiagonallyLeftUp()
        {
            var board = new Board();
            var bishop = new Bishop(Player.White);
            board.AddPiece(Square.At(3, 2), bishop);

            var moves = bishop.GetAvailableMoves(board).ToList();
            
            moves.Should().Contain(Square.At(2, 1));
            moves.Should().Contain(Square.At(1, 0));
        }
        
        [Test]
        public void CanMoveDiagonallyLeftDown()
        {
            var board = new Board();
            var bishop = new Bishop(Player.White);
            board.AddPiece(Square.At(3, 2), bishop);

            var moves = bishop.GetAvailableMoves(board).ToList();
            
            moves.Should().Contain(Square.At(4, 1));
            moves.Should().Contain(Square.At(5, 0));
        }
        
        [Test]
        public void Bishop_BlockedByPiece()
        {
            var board = new Board();
            var bishop = new King(Player.White);
            var blockingPiece = new Pawn(Player.White);
            board.AddPiece(Square.At(1, 3), bishop);
            board.AddPiece(Square.At(0, 4), blockingPiece);
            board.AddPiece(Square.At(2, 2), blockingPiece);
                
            var moves = bishop.GetAvailableMoves(board).ToList();

            moves.Should().NotContain(Square.At(2, 2));
            moves.Should().NotContain(Square.At(0, 4));
        }
        
        [Test]
        public void Bishop_CanCapture()
        {
            var board = new Board();
            var bishop = new Bishop(Player.White);
            var firstTarget = new Pawn(Player.Black);
            var secondTarget = new Pawn(Player.Black);
            var thirdTarget = new Pawn(Player.Black);
            var fourthTarget = new Pawn(Player.Black);
      
            board.AddPiece(Square.At(6, 3), bishop);
            board.AddPiece(Square.At(5, 2), firstTarget);
            board.AddPiece(Square.At(7, 2), secondTarget);
            board.AddPiece(Square.At(5, 4), thirdTarget);
            board.AddPiece(Square.At(7, 4), fourthTarget);
 

            var moves = bishop.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(5, 2));
            moves.Should().Contain(Square.At(7, 2));
            moves.Should().Contain(Square.At(5, 4));
            moves.Should().Contain(Square.At(7, 4));
        }
    }
}