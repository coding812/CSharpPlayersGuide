Console.Title = "The Locked Door";
Console.Clear();

string password = Door.MakePassword();
Door door = new Door(password);

while (true)
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Unlock the door");
    Console.WriteLine("2. Open the door");
    Console.WriteLine("3. Close the door");
    Console.WriteLine("4. Lock the door");
    Console.WriteLine("5. Change the password");

    string choice = Console.ReadLine() ?? "6" ;

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter the password:");
            string key = Console.ReadLine() ?? "";
            door.Unlock(key);
            break;
        case "2":
            door.Open();
            break;
        case "3":
            door.Close();
            break;
        case "4":
            door.Lock();
            break;
        case "5":
            Console.WriteLine("Enter the current password:");
            string currentPassword = Console.ReadLine() ?? "";
            if (currentPassword != Door.Password)
            {
                Console.WriteLine("That Password is incorrect!");
                break;
            }
            Door.MakePassword();
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}

public class Door
{
    public bool IsLocked { get; set; }
    public bool IsOpen { get; set; }
    public static string? Password { get; set; }

    public Door(string password)
    {
        IsLocked = true;
        IsOpen = false;
        Password = password;
    }

    public void Unlock(string key)
    {
        if (key == Password)
        {
            IsLocked = false;
            Console.WriteLine("The door is unlocked!");
        }
        else
        {
            Console.WriteLine("That Password is incorrect!");
        }
    }

    public void Open()
    {
        if (IsLocked)
        {
            Console.WriteLine("The door is locked!");
        }
        else
        {
            IsOpen = true;
            Console.WriteLine("The door is open!");
        }
    }

    public void Close()
    {
        IsOpen = false;
        Console.WriteLine("The door is closed!");
    }

    public void Lock()
    {
        IsLocked = true;
        Console.WriteLine("The door is locked!");
    }

    public static string MakePassword()
    {
        if (Password == null)
        {
            Console.Write("What would you like the password to be? ");
            Password = Console.ReadLine() ?? "";
        }
        else
        {
            Console.Write("What would you like the new password to be? ");
            string newPassword = Console.ReadLine() ?? "";

            if (newPassword == "")
            {
                Console.WriteLine("The password cannot be empty!");
                MakePassword();
            }
            else if (newPassword == Password)
            {
                Console.WriteLine("The new password cannot be the same as the old password!");
                MakePassword();
            }
            else
            {
                Password = newPassword;
                Console.WriteLine("The password has been changed!");
            }
        }
        return Password!;
    }
}

    