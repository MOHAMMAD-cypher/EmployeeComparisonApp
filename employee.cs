using System;

// Define the Employee class
public class Employee
{
    // Property to hold the unique identifier for the employee
    public int Id { get; set; }

    // Property to hold the first name of the employee
    public string FirstName { get; set; }

    // Property to hold the last name of the employee
    public string LastName { get; set; }

    // Overload the '==' operator to compare two Employee objects by their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check for null on both sides to avoid null reference exception
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null)) return true;
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null)) return false;

        // Compare employee Ids
        return emp1.Id == emp2.Id;
    }

    // Overload the '!=' operator (must be done in pair with '==')
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2); // Simply return the negation of '=='
    }

    // Override Equals method to ensure consistency with '=='
    public override bool Equals(object obj)
    {
        // If the object is not an Employee, return false
        if (obj is not Employee) return false;

        // Cast the object and compare Ids
        return this == (Employee)obj;
    }

    // Override GetHashCode when overriding Equals
    public override int GetHashCode()
    {
        return Id.GetHashCode(); // Use Id's hash code
    }
}
