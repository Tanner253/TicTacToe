using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        /// <summary>
        /// TEST FOR : Winners
        /// switch player works
        ///confirm position with index array
        ///1 unique test
        ///will come back to this!
        /// </summary>
        [Fact]
        public void CanCheckForWinner()
        {
            Board board = new Board();
            Player player1 = new Player();
            player1.Marker = "X";
            Player player2 = new Player();
            player1.Marker = "O";
            Game game = new Game(player1, player2);
            game.Board.GameBoard[0,0] = "O";
            game.Board.GameBoard[0,1] = "O";
            game.Board.GameBoard[0,2] = "O";
            game.CheckForWinner(game.Board);
            Assert.True(game.CheckForWinner(game.Board));
        }
        [Fact]
        public void CanSwitchPlayers()
        {
            //setup
            Board board = new Board();
            Player player1 = new Player();
            player1.Marker = "X";
            Player player2 = new Player();
            player1.Marker = "O";
            Game game = new Game(player1, player2);
            player1.IsTurn = true;
            //act
            game.SwitchPlayer();

            Assert.True(player2.IsTurn);
        }
        [Fact]
        public void ConfirmIndex()
        {
            Board board = new Board();
            Player player1 = new Player();
            player1.Marker = "X";
            Player player2 = new Player();
            player1.Marker = "O";
            Game game = new Game(player1, player2);

            Position position = Player.PositionForNumber(1);

            player1.Marker = "X";

            game.Board.GameBoard[position.Row, position.Column] = player1.Marker;
            //assert
            Assert.Equal("X", game.Board.GameBoard[0, 0]);

        }
        //draw game works 
    }
}
