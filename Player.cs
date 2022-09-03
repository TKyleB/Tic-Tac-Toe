using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Player
    {
        public Symbol symbol;

        public Player(Symbol symbol)
        {
            this.symbol = symbol;
        }

        // Takes the input and converts it to coordinates
        public (int, int) convertInputToCoords(int input)
        {
            return input switch
            {
                7 => (0, 0),
                8 => (0, 1),
                9 => (0, 2),
                4 => (1, 0),
                5 => (1, 1),
                6 => (1, 2),
                1 => (2, 0),
                2 => (2, 1),
                3 => (2, 2),

            };
            
        }

    }

    enum Symbol { E, X, O}
}
