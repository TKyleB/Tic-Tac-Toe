using Tic_Tac_Toe;

Console.WriteLine("Welcome to Tic-Tac-Toe!");
Console.WriteLine();
Game game = new Game();

// Game Loop
while (true)
{
    game.board.showBoard();
    Console.WriteLine();
    (int, int) position = getInput();
    
    while (game.board.checkTakenSpace(position))
    {
        Console.Clear();
        game.board.showBoard();
        Console.WriteLine();
        Console.WriteLine("That space is taken!");
        position = getInput();
    }

    game.board.updatePosition(position, game.currentTurn.symbol);
    if (game.checkWin() == true)
    {
        Console.Clear();
        game.board.showBoard();
        Console.WriteLine();
        Console.WriteLine($"{game.currentTurn.symbol} wins!");
        return;
    }
    if (game.checkDraw() == true)
    {
        Console.WriteLine("Its a draw!");
        return;
    }
    Console.Clear();
    game.switchTurn();
    
}

(int, int) getInput() {
    Console.WriteLine($"{game.currentTurn.symbol} Pick a Location: ");
    int input = Convert.ToInt32(Console.ReadLine());
    (int, int) position = game.currentTurn.convertInputToCoords(input);
    return position;

}

