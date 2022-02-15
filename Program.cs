using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Tic-Tac-Toe!");
            TicTacToe game = new TicTacToe();
            //game.CreateBoard();
            game.Choice();
        }
    }
}
