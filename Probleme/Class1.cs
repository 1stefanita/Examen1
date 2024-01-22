using System;

public class Person
{
    public string FirstName { get; }
    public string LastName { get; }
    public int YearOfBirth { get; }
    public int Age => DateTime.Now.Year - YearOfBirth;

    public Person(string firstName, string lastName, int yearOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        YearOfBirth = yearOfBirth;
    }
}
