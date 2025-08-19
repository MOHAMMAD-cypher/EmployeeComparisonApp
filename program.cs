using System;

// Main class containing entry point
class Program
{
    static void Main(string[] args)
    {
        // Create the first employee object and assign values
        Employee employee1 = new Employee
        {
            Id = 101,
            FirstName = "John",
            LastName = "Doe"
        };

        // Create the second employee object and assign values
        Employee employee2 = new Employee
        {
            Id = 101, // Same ID as employee1 to test equality
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Compare the two employees using the overloaded '==' operator
        if (employee1 == employee2)
        {
            Console.WriteLine("Employees are equal based on their Id.");
        }
        else
        {
            Console.WriteLine("Employees are NOT equal.");
        }

        // Also show the result of the '!=' operator
        Console.WriteLine("Are the employees not equal? " + (employee1 != employee2));
    }
}
