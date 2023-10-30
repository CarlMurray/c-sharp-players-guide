Grid game = new Grid();
game.showGrid();
game.checkState(); 

public class Grid
{
    public static char[,] _startingState = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, };
    private char[,] _state;
    private Player winner;

    public Grid()
    {
        _state = _startingState;
    }

    public void showGrid()
    {
        Console.WriteLine($" {_state[0, 0]} | {_state[0, 1]} | {_state[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {_state[1, 0]} | {_state[1, 1]} | {_state[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {_state[2, 0]} | {_state[2, 1]} | {_state[2, 2]} ");
    }
    // todo: return player type
    public void checkState()
    {
        int x = 0;
        int y = 0;

        for (int i = 0; i < 3; i++)
        {
            // check rows
            if (_state[y, x] == _state[y, x + 1] && _state[y, x + 1] == _state[y, x + 2] && _state[y, x] != ' ')
            {
                Console.WriteLine("Equal!");
            }
            if (_state[y, x] == _state[y, x + 1] && _state[y, x + 1] == _state[y, x + 2] && _state[y, x] != ' ')
            {
                Console.WriteLine("Equal!");
            }

            y++;
        }
    }
}

public class Player
{
}