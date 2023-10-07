while (true)
{
    Console.WriteLine("Enter a password:");
    string password = Console.ReadLine();
    PasswordValidator checkPassword = new PasswordValidator(password);
    if (checkPassword.checkValidity())
    {
        Console.WriteLine("Password is valid.");
    }
    else
    {
        Console.WriteLine("Password is invalid!!!");
    }
}


public class PasswordValidator
{
    private string _password;
    private bool _isValid;

    public PasswordValidator(string password)
    {
        _password = password;
    }

    public bool checkValidity()
    {
        if (_password.Length > 5 || _password.Length < 14)
        {
            if (_password.Contains('T') || _password.Contains('&'))
            {
                Console.WriteLine("Password can't contain T or &!!!");
                _isValid = false;
                return _isValid;
            }
            else
            {


                bool containsUpper = false;
                bool containsLower = false;
                bool containsDigit = false;

                foreach (char letter in _password)
                {
                    if (char.IsLower(letter))
                    {
                        containsLower = true;
                    }

                    if (char.IsUpper(letter))
                    {
                        containsUpper = true;
                    }

                    if (char.IsDigit(letter))
                    {
                        containsDigit = true;
                    }
                }

                if (containsDigit && containsLower && containsUpper)
                {
                    _isValid = true;
                    return _isValid;

                }
                else
                {
                    _isValid = false;
                    return _isValid;

                }
            }

        }
        else
        {
            _isValid = false;
            return _isValid;
        }

    }
}