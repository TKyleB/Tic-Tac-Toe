using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Board
    {
        public Symbol[,] board = new Symbol[3, 3];

        // Update position on array to X or O
        public void updatePosition((int x, int y) coords, Symbol symbol)
        {
            this.board[coords.x, coords.y] = symbol;
        }

        // Get's the current symbol on the array
        public Symbol getSymbol((int x, int y) coords)
        {
            return this.board[coords.x, coords.y ];
        }

       // Draws the board
        public void showBoard()
        {
            Console.WriteLine($" {this.board[0, 0]} | {this.board[0, 1]} | {this.board[0, 2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {this.board[1, 0]} | {this.board[1, 1]} | {this.board[1, 2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {this.board[2, 0]} | {this.board[2, 1]} | {this.board[2, 2]}");
        }

        //Checks if a space is taken or empty
        public bool checkTakenSpace((int x, int y) coords)
        {
            if (this.getSymbol(coords) == Symbol.E) return false;
            else return true;
        }
        
    }
}
