using System;
class DataOnly
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    public DataOnly(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}
class Person
{
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public DataOnly Birthday { get; set;}
    public int Age { get; set;}
    public string Gender { get; set;}
    public string Profession { get; set;}
    public string Nacionality { get; set;}
    public Person(string firstName, string lastName, DataOnly birthday, int age, string gender, string profession, string nacionality)
    {
        FirstName = firstName;
        LastName = lastName;
        Birthday = birthday;
        Age = age;
        Gender = gender;
        Profession = profession;
        Nacionality = nacionality;
    }
    public override string ToString()
    {
        return $"His name is {FirstName} {LastName}, his birthday is {Birthday}, he is {Age} years old, his gender is {Gender}, his profession is {Profession} and his nacionality is {Nacionality}";
    }
}

class Program
{
    static void Main()
    {
        var I = new Person("Tiago", "Lobo", new DataOnly(2010, 3, 28), 13, "Male", "Student", "Portuguese"){};
        Console.WriteLine(I);

    }
}