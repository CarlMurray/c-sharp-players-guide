Console.WriteLine("Set your passcode for the lock:");
int passcode = Convert.ToInt32(Console.ReadLine());
Door d = new Door(passcode);
playWithDoor();

void playWithDoor()
{
    Console.WriteLine("What would you like to do next?");
    Console.WriteLine("1 - Unlock");
    Console.WriteLine("2 - Lock");
    Console.WriteLine("3 - Open");
    Console.WriteLine("4 - Close");
    Console.WriteLine("5 - Change passcode");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            d.Unlock();
            break;
        case 2:
            d.Lock();
            break;
        case 3:
            d.Open();
            break;
        case 4:
            d.Close();
            break;
        case 5:
            Console.WriteLine("Enter your current passcode:");
            int currentPasscode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new passcode:");
            int newPasscode = Convert.ToInt32(Console.ReadLine());
            d.setPasscode(currentPasscode, newPasscode);
            break;
    }

    playWithDoor();
}

public class Door
{
    // stores door position - open or closed
    private DoorState _position = DoorState.Closed;
    private int _passcode = 0;

    // constructor - closed + locked
    public Door(int passcode)
    {
        Position = DoorState.Closed;
        Security = LockState.Locked;
        _passcode = passcode;
    }

    public void showPasscode()
    {
        Console.WriteLine(_passcode);
    }

    public void setPasscode(int currentPasscode, int newPasscode)
    {
        if (currentPasscode == _passcode)
        {
            _passcode = newPasscode;
            Console.WriteLine("Passcode set!");
        }
        else
        {
            Console.WriteLine("Incorrect passcode!");
        }
    }

    // defines Position 
    public DoorState Position
    {
        get { return _position; }
        set
        {
            // if the door is closed and want to open
            if (_position == DoorState.Closed && value == DoorState.Open)
            {
                // prompt to unlock first
                if (Security == LockState.Locked)
                {
                    Console.WriteLine("The door must be unlocked first!");
                }
                // open door
                else
                {
                    Console.WriteLine("The door has been opened!");
                    _position = value;
                }
            }

            else if (_position == DoorState.Open && value == DoorState.Closed)
            {
                _position = DoorState.Closed;
            }
        }
    }

    public LockState Security { get; set; }

    public void Open()
    {
        if (Position == DoorState.Closed && Security == LockState.Unlocked)
        {
            Position = DoorState.Open;
            return;
        }
        else if (Position == DoorState.Closed && Security == LockState.Locked)
        {
            Console.WriteLine("The door must be unlocked before you can open it!");
        }
        else Console.WriteLine("The door is already open!");
    }

    public void Close()
    {
        if (Position == DoorState.Open)
        {
            Position = DoorState.Closed;
            Console.WriteLine("The door has been closed.");
        }
        else Console.WriteLine("The door is already closed!");
    }

    public void Unlock()
    {
        if (Position == DoorState.Closed && Security == LockState.Locked)
        {
            Security = LockState.Unlocked;
            Console.WriteLine("The door has been unlocked.");
        }
        else if (Security == LockState.Unlocked)
        {
            Console.WriteLine("The door is already unlocked!");
        }
        else
        {
            Console.WriteLine("The door must be closed before it can be unlocked...");
        }
    }

    public void Lock()
    {
        if (Position == DoorState.Closed && Security == LockState.Unlocked)
        {
            Security = LockState.Locked;
            Console.WriteLine("The door has been locked.");
        }
        else if (Security == LockState.Locked)
        {
            Console.WriteLine("The door is already locked!");
        }
        else
        {
            Console.WriteLine("The door must be closed before it can be locked...");
        }
    }

    public enum LockState
    {
        Locked,
        Unlocked
    }

    public enum DoorState
    {
        Closed,
        Open
    };
}