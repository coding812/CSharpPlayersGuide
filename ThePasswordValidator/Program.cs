Console.Title = "The Password Validator";
Console.Clear();

while (true)
{
    Console.Write("Please enter a password: ");
    string password = Console.ReadLine() ?? string.Empty;

    PasswordValidator passwordValidator = new PasswordValidator(password);
    passwordValidator.ValidatePassword();
}

public class PasswordValidator
{
    private string Password;
    private string ErrorMessage = "That Password is not valid, try again.";
    private string SuccessMessage = "That Password is valid!";

    public PasswordValidator(string password)
    {
        this.Password = password;
    }

    public void ValidatePassword()
    {
        string inputPassword = Password;
        int digitCount = 0;
        int uppercaseCount = 0;
        bool forbiddenCharacter = false;

        foreach (char letter in inputPassword)
        {
            if (char.IsDigit(letter)) digitCount++;
            if (char.IsUpper(letter)) uppercaseCount++;
            if (letter == 'T' || letter == '&') forbiddenCharacter = true;
        }

        if (inputPassword.Length <= 5 || inputPassword.Length >= 14 || digitCount < 1 || uppercaseCount < 1 || forbiddenCharacter == true)
        {
            Console.WriteLine(ErrorMessage);
        }
        else
        {
            Console.WriteLine(SuccessMessage);
        }
    }
}