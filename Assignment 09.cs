using System;

class Program
{
    static void Main()
    {
        try
        {
            // Prompt the user to enter name, email, and password
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Validate user input
            ValidateInput(name, email, password);

            // Placeholder method to simulate inserting user details into the database
            InsertUserDetails(name, email, password);

            // Display success message if input is valid and details are inserted
            Console.WriteLine("User registration success!");
        }
        catch (ValidationException ex)
        {
            // Catch the custom ValidationException and display the error message to the user
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Catch any other general Exception and display the error message to the user
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ValidateInput(string name, string email, string password)
    {
        // Check if name, email, and password are provided
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ValidationException("Name is required.");
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ValidationException("Email is required.");
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ValidationException("Password is required.");
        }

        // Check if name has at least 6 characters
        if (name.Length < 6)
        {
            throw new ValidationException("Name must have at least 6 characters.");
        }

        // Check if password has at least 8 characters
        if (password.Length < 8)
        {
            throw new ValidationException("Password must have at least 8 characters.");
        }

        // Additional validation logic can be added here if needed.
    }

    // Placeholder method to simulate inserting user details into the database
    static void InsertUserDetails(string name, string email, string password)
    {
        // Add your logic here to insert the user details into the database.
        // This method is a placeholder and does not include actual database operations.
        Console.WriteLine("User details inserted into the database.");
    }
}

// Custom exception class for validation errors
class ValidationException : Exception
{
    public ValidationException(string message) : base(message)
    {
    }
}
