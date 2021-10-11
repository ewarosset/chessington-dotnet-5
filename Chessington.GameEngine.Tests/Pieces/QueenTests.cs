using System.Linq;
using Chessington.GameEngine.Pieces;
using FluentAssertions;
using NUnit.Framework;

namespace Chessington.GameEngine.Tests.Pieces
{
    [TestFixture]
    public class QueenTests
    {

        [Test]

        public void CanMoveUp()
        {
            var board = new Board();
            var queen = new Queen(Player.White);
            board.AddPiece(Square.At(4, 0), queen);

            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(3, 0));
            moves.Should().Contain(Square.At(2, 0));
            moves.Should().Contain(Square.At(1, 0));
            moves.Should().Contain(Square.At(0, 0));
        }
        
        [Test]

        public void CanMoveDown()
        {
            var board = new Board();
            var queen = new Queen(Player.White);
            board.AddPiece(Square.At(4, 0), queen);

            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(5, 0));
            moves.Should().Contain(Square.At(6, 0));
            moves.Should().Contain(Square.At(7, 0));
        }
        
        [Test]

        public void CanMoveDiagonallyRightUp()
        {
            var board = new Board();
            var queen = new Queen(Player.White);
            board.AddPiece(Square.At(4, 0), queen);

            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(3, 1));
            moves.Should().Contain(Square.At(2, 2));
            moves.Should().Contain(Square.At(1, 3));
            moves.Should().Contain(Square.At(0, 4));
        }
        
        [Test]

        public void CanMoveDiagonallyRightDown()
        {
            var board = new Board();
            var queen = new Queen(Player.White);
            board.AddPiece(Square.At(4, 0), queen);

            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(5, 1));
            moves.Should().Contain(Square.At(6, 2));
            moves.Should().Contain(Square.At(7, 3));
        }
        
        [Test]

        public void CanMoveDiagonallyLeftUp()
        {
            var board = new Board();
            var queen = new Queen(Player.White);
            board.AddPiece(Square.At(4, 2), queen);

            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(3, 1));
            moves.Should().Contain(Square.At(2, 0));

            
        }
        
        [Test]

        public void CanMoveDiagonallyLeftDown()
        {
            var board = new Board();
            var queen = new Queen(Player.White);
            board.AddPiece(Square.At(4, 2), queen);

            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(5, 1));
            moves.Should().Contain(Square.At(6, 0));


        }
        
        [Test]

        public void CanMoveRight()
        {
            var board = new Board();
            var queen = new Queen(Player.White);
            board.AddPiece(Square.At(4, 5), queen);

            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(4, 6));
            moves.Should().Contain(Square.At(4, 7));
        }
        
        [Test]

        public void CanMoveLeft()
        {
            var board = new Board();
            var queen = new Queen(Player.White);
            board.AddPiece(Square.At(5, 2), queen);

            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(5, 1));
            moves.Should().Contain(Square.At(5, 0));
        }

        [Test]

        public void Queen_BlockedByPiece()
        {
            
            var board = new Board();
            var queen = new Queen(Player.White);
            var blockingPiece = new Pawn(Player.White);
            board.AddPiece(Square.At(4, 2), queen);
            board.AddPiece(Square.At(3, 1), blockingPiece);
            board.AddPiece(Square.At(5, 1), blockingPiece);
                
            var moves = queen.GetAvailableMoves(board).ToList();

            moves.Should().NotContain(Square.At(3, 1));
            moves.Should().NotContain(Square.At(5, 1));
        }
        
        [Test]

        public void Queen_CanCapture()
        {
            
            var board = new Board();
            var queen = new Queen(Player.White);
            var firstTarget = new Pawn(Player.Black);
            var secondTarget = new Pawn(Player.Black);
            var thirdTarget = new Pawn(Player.Black);
            var fourthTarget = new Pawn(Player.Black);
            var fifthTarget = new Pawn(Player.Black);
            var sixthTarget = new Pawn(Player.Black);
            var seventhTarget = new Pawn(Player.Black);
            var eightTarget = new Pawn(Player.Black);
      
            board.AddPiece(Square.At(6, 3), queen);
            board.AddPiece(Square.At(5, 3), firstTarget);
            board.AddPiece(Square.At(6, 4), secondTarget);
            board.AddPiece(Square.At(6, 2), thirdTarget);
            board.AddPiece(Square.At(7, 3), fourthTarget);
            board.AddPiece(Square.At(5, 2), fifthTarget);
            board.AddPiece(Square.At(7, 2), sixthTarget);
            board.AddPiece(Square.At(5, 4), seventhTarget);
            board.AddPiece(Square.At(7, 4), eightTarget);

            var moves = queen.GetAvailableMoves(board).ToList();

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