using System.Linq;
using Chessington.GameEngine.Pieces;
using FluentAssertions;
using NUnit.Framework;

namespace Chessington.GameEngine.Tests.Pieces
{
    [TestFixture]
    public class KingTests
    {
        [Test]
        public void CanMoveUp()
        {
            var board = new Board();
            var king = new King(Player.White);
            board.AddPiece(Square.At(4, 0), king);

            var moves = king.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(3, 0));
        }

        [Test]

        public void CanMoveDown()
        {
            var board = new Board();
            var king = new King(Player.White);
            board.AddPiece(Square.At(4, 0), king);

            var moves = king.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(5, 0));
        }

        [Test]
        public void CanMoveRight()
        {
            var board = new Board();
            var king = new King(Player.White);
            board.AddPiece(Square.At(4, 0), king);

            var moves = king.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(4, 1));
        }

        [Test]
        public void CanMoveLeft()
        {
            var board = new Board();
            var king = new King(Player.White);
            board.AddPiece(Square.At(4, 4), king);

            var moves = king.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(4, 3));
        }

        [Test]
        public void CanMoveDiagonallyRightUp()
        {
            var board = new Board();
            var king = new King(Player.White);
            board.AddPiece(Square.At(4, 4), king);

            var moves = king.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(3, 5));
        }

        [Test]
        public void CanMoveDiagonallyLeftUp()
        {
            var board = new Board();
            var king = new King(Player.White);
            board.AddPiece(Square.At(4, 4), king);

            var moves = king.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(3, 3));
        }

        [Test]
        public void CanMoveDiagonallyRightDown()
        {
            var board = new Board();
            var king = new King(Player.White);
            board.AddPiece(Square.At(4, 4), king);

            var moves = king.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(5, 5));
        }

        [Test]
        public void CanMoveDiagonallyLeftDown()
        {
            var board = new Board();
            var king = new King(Player.White);
            board.AddPiece(Square.At(4, 4), king);

            var moves = king.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(5, 3));
        }

        [Test]
        public void King_BlockedByPiece()
        {
            var board = new Board();
            var king = new King(Player.White);
            var blockingPiece = new Pawn(Player.White);
            board.AddPiece(Square.At(1, 3), king);
            board.AddPiece(Square.At(2, 3), blockingPiece);
            board.AddPiece(Square.At(1, 4), blockingPiece);
                
            var moves = king.GetAvailableMoves(board).ToList();

            moves.Should().NotContain(Square.At(2, 3));
            moves.Should().NotContain(Square.At(1, 4));
        }

        [Test]

        public void King_CanCapture()
        {
            var board = new Board();
            var king = new King(Player.White);
            var firstTarget = new Pawn(Player.Black);
            var secondTarget = new Pawn(Player.Black);
            var thirdTarget = new Pawn(Player.Black);
            var fourthTarget = new Pawn(Player.Black);
            var fifthTarget = new Pawn(Player.Black);
            var sixthTarget = new Pawn(Player.Black);
            var seventhTarget = new Pawn(Player.Black);
            var eightTarget = new Pawn(Player.Black);
            
            board.AddPiece(Square.At(6, 3), king);
            board.AddPiece(Square.At(5, 3), firstTarget);
            board.AddPiece(Square.At(6, 4), secondTarget);
            board.AddPiece(Square.At(6, 2), thirdTarget);
            board.AddPiece(Square.At(7, 3), fourthTarget);
            board.AddPiece(Square.At(5, 2), fifthTarget);
            board.AddPiece(Square.At(7, 2), sixthTarget);
            board.AddPiece(Square.At(5, 4), seventhTarget);
            board.AddPiece(Square.At(7, 4), eightTarget);

            var moves = king.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(5, 3));
            moves.Should().Contain(Square.At(6, 4));
            moves.Should().Contain(Square.At(6, 2));
            moves.Should().Contain(Square.At(7, 3));
            moves.Should().Contain(Square.At(5, 2));
            moves.Should().Contain(Square.At(7, 2));
            moves.Should().Contain(Square.At(5, 4));
            moves.Should().Contain(Square.At(7, 4));
            
        }
        
    }
}