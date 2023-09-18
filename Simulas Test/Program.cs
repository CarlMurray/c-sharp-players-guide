PromptUser(State.Locked);

void PromptUser(State state)
{
    string stateString = "";
    while (stateString == "")
    {
        switch (state)
        {
            case State.Closed:
                stateString = "closed";
                break;
            case State.Locked:
                stateString = "locked";
                break;
            case State.Open:
                stateString = "open";
                break;
            case State.Unlocked:
                stateString = "unlocked";
                break;
        }
    }

    Console.WriteLine($"The chest is {stateString}. What do you want to do?");

    string action = Console.ReadLine();

    switch (action)
    {
        case "unlock":
            state = State.Closed;
            break;
        case "open":
            state = State.Open;
            break;
        case "close":
            state = State.Closed;
            break;
        case "lock":
            state = State.Locked;
            break;
    }

    PromptUser(state);
}


enum State
{
    Locked,
    Unlocked,
    Closed,
    Open
};