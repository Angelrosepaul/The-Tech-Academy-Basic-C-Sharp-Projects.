using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class
    public class Employee
    {
        // Properties to store employee details
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for nulls to prevent NullReferenceException
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null)) return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null)) return false;

            // Compare Ids
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator to return the opposite of '=='
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals method for consistency with '=='
        public override bool Equals(object obj)
        {
            // Return false if object is null or not an Employee
            if (obj is not Employee) return false;

            return this == (Employee)obj;
        }

        // Override GetHashCode when overriding Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
