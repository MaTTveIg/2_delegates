EmailValidator emailValidator = new();

emailValidator.ValidEmail("artem@gmail.com", 
    email => Console.WriteLine($"{email} is valid"),
    email => Console.WriteLine($"{email} is invalid"),
    email => email.Contains('@'));

class EmailValidator
{
    public delegate void Callback(string email);
    public delegate bool ValidateHandler(string email);
    public void ValidEmail(string email, Callback validEmail, Callback invalidEmail, ValidateHandler validateHandler)
    {
        if (validateHandler(email))
            validEmail(email);
        else invalidEmail(email);
    }
}