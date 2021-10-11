using System.Linq;
using Chessington.GameEngine.Pieces;
using FluentAssertions;
using NUnit.Framework;

namespace Chessington.GameEngine.Tests.Pieces
{
    [TestFixture]
    public class KnightTests
    {
        [Test]

        public void CanMoveDiagonallyDownRight()
        {
            var board = new Board();
            var knight = new Knight(Player.White);
            board.AddPiece(Square.At(4, 0), knight);

            var moves = knight.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(6, 1));
        }

        [Test]

        public void CanMoveDiagonallySideDownRight()
        {
            var board = new Board();
            var knight = new Knight(Player.White);
            board.AddPiece(Square.At(4, 0), knight);

            var moves = knight.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(5, 2));
        }


        [Test]

        public void CanMoveDiagonallySideUpRight()
        {
            var board = new Board();
            var knight = new Knight(Player.White);
            board.AddPiece(Square.At(4, 0), knight);

            var moves = knight.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(3, 2));
        }

        [Test]

        public void CanMoveDiagonallyUpRight()
        {
            var board = new Board();
            var knight = new Knight(Player.White);
            board.AddPiece(Square.At(4, 0), knight);

            var moves = knight.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(2, 1));
        }



        [Test]

        public void CanMoveDiagonallyDownLeft()
        {
            var board = new Board();
            var knight = new Knight(Player.White);
            board.AddPiece(Square.At(3, 3), knight);

            var moves = knight.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(5, 1));

        }



        [Test]

        public void CanMoveDiagonallySideDownLeft()
        {
            var board = new Board();
            var knight = new Knight(Player.White);
            board.AddPiece(Square.At(3, 3), knight);

            var moves = knight.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(4, 1));

        }


        [Test]

        public void CanMoveDiagonallySideUpLeft()
        {
            var board = new Board();
            var knight = new Knight(Player.White);
            board.AddPiece(Square.At(3, 3), knight);

            var moves = knight.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(2, 1));

        }


        [Test]

        public void CanMoveDiagonallyUpLeft()
        {
            var board = new Board();
            var knight = new Knight(Player.White);
            board.AddPiece(Square.At(3, 3), knight);

            var moves = knight.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(1, 2));

        }


        [Test]

        public void KnightBlockedByPiece()
        {
            
            var board = new Board();
            var knight = new Knight(Player.White);
            var blockingPiece = new Pawn(Player.White);
            board.AddPiece(Square.At(1, 3), knight);
            board.AddPiece(Square.At(3, 2), blockingPiece);
            board.AddPiece(Square.At(3, 4), blockingPiece);
                
            var moves = knight.GetAvailableMoves(board).ToList();

            moves.Should().NotContain(Square.At(3, 2));
            moves.Should().NotContain(Square.At(3, 4));

        }


        [Test]

        public void KnightCanCapture()
        {
            
            var board = new Board();
            var knight = new Knight(Player.White);
            var firstTarget = new Pawn(Player.Black);
            var secondTarget = new Pawn(Player.Black);
            var thirdTarget = new Pawn(Player.Black);
            var fourthTarget = new Pawn(Player.Black);
            var fifthTarget = new Pawn(Player.Black);
            var sixthTarget = new Pawn(Player.Black);

            
            board.AddPiece(Square.At(6, 3), knight);
            board.AddPiece(Square.At(5, 1), firstTarget);
            board.AddPiece(Square.At(7, 1), secondTarget);
            board.AddPiece(Square.At(4, 2), thirdTarget);
            board.AddPiece(Square.At(4, 4), fourthTarget);
            board.AddPiece(Square.At(5, 5), fifthTarget);
            board.AddPiece(Square.At(7, 5), sixthTarget);


            var moves = knight.GetAvailableMoves(board).ToList();

            moves.Should().Contain(Square.At(6, 3));
            moves.Should().Contain(Square.At(5, 1));
            moves.Should().Contain(Square.At(7, 1));
            moves.Should().Contain(Square.At(4, 2));
            moves.Should().Contain(Square.At(4, 4));
            moves.Should().Contain(Square.At(5, 5));
            moves.Should().Contain(Square.At(7, 5));


        }
    }
}