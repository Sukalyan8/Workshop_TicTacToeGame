using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Play
    {
     public TicTacToe()
        {
            play();
        }
        public void play()
        {
            GameBoard gameBoard = new GameBoard();
            Player playerX = new Player('X');
            Player playerO = new player('O');
            playerX currentPlayer = playerX;
            int moveCounter = 0;
            bool play = true;

        }
     
    }

    internal class GameBoard
    {
        public GameBoard()
        {
        }
    }
}