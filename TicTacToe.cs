using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class TicTacToe
    {
        public static void TikTakToe_Game()
        {
            char[] startarr = new char[10];
            for (int i = 0;i<startarr.Length;i++)
            {
                if(i==0)
                {
                    continue;
                }
                startarr[i] = ' ';

            }
            Console.WriteLine("\t|\t|*");
            Console.WriteLine("------------------------");
            Console.WriteLine("\t|\t|*");
            Console.WriteLine("------------------------");
            Console.WriteLine("\t|\t|*");
    }
}
