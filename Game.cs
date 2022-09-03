using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Game
    {
        public Player currentTurn;
        public Player player1;
        public Player player2;
        public Board board;
        public int turnNumber;
        public Game()
        {
            player1 = new Player(Symbol.X);
            player2 = new Player(Symbol.O);
            board = new Board();
            currentTurn = player1;
            turnNumber = 1;
        }

        public void switchTurn()
        {
            turnNumber++;
            if (currentTurn == this.player1) currentTurn = this.player2;
            else currentTurn = this.player1;
            
        }

        public bool checkWin()
        {
            //Check Horizontal
            if (this.board.getSymbol((0, 0)) == this.currentTurn.symbol && this.board.getSymbol((0, 1)) == this.currentTurn.symbol && this.board.getSymbol((0, 2)) == this.currentTurn.symbol) return true;
            if (this.board.getSymbol((1, 0)) == this.currentTurn.symbol && this.board.getSymbol((1, 1)) == this.currentTurn.symbol && this.board.getSymbol((1, 2)) == this.currentTurn.symbol) return true;
            if (this.board.getSymbol((2, 0)) == this.currentTurn.symbol && this.board.getSymbol((2, 1)) == this.currentTurn.symbol && this.board.getSymbol((2, 2)) == this.currentTurn.symbol) return true;
            // Check Vertical        
            if (this.board.getSymbol((0, 0)) == this.currentTurn.symbol && this.board.getSymbol((1, 0)) == this.currentTurn.symbol && this.board.getSymbol((2, 0)) == this.currentTurn.symbol) return true;
            if (this.board.getSymbol((0, 1)) == this.currentTurn.symbol && this.board.getSymbol((1, 1)) == this.currentTurn.symbol && this.board.getSymbol((2, 1)) == this.currentTurn.symbol) return true;
            if (this.board.getSymbol((0, 2)) == this.currentTurn.symbol && this.board.getSymbol((1, 2)) == this.currentTurn.symbol && this.board.getSymbol((2, 2)) == this.currentTurn.symbol) return true;
                                     
            // Check Diagonal        
            if (this.board.getSymbol((0, 0)) == this.currentTurn.symbol && this.board.getSymbol((1, 1)) == this.currentTurn.symbol && this.board.getSymbol((2, 2)) == this.currentTurn.symbol) return true;
            if (this.board.getSymbol((0, 2)) == this.currentTurn.symbol && this.board.getSymbol((1, 1)) == this.currentTurn.symbol && this.board.getSymbol((2, 0)) == this.currentTurn.symbol) return true;

            return false;
        }

        public bool checkDraw()
        {
            if (turnNumber >= 9) return true;
            else return false;
            
        }


        

    }
}
