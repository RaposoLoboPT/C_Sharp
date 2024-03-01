using System;

// Classe que representa uma data apenas
class DateOnly
{
    public int Year { get; set; } // Propriedade para o ano
    public int Month { get; set; } // Propriedade para o mês
    public int Day { get; set; } // Propriedade para o dia

    // Construtor para inicializar a data
    public DateOnly(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    // Método para formatar a data como uma string
    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}

// Classe que representa uma pessoa
class Person
{
    public string FirstName { get; set; } // Propriedade para o primeiro nome
    public string LastName { get; set; } // Propriedade para o último nome
    public DateOnly Birthday { get; set; } // Propriedade para a data de nascimento
    public int Age { get; set; } // Propriedade para a idade
    public string Gender { get; set; } // Propriedade para o género
    public string Profession { get; set; } // Propriedade para a profissão
    public string Nationality { get; set; } // Propriedade para a nacionalidade

    // Construtor para inicializar uma pessoa
    public Person(string firstName, string lastName, DateOnly birthday, int age, string gender, string profession, string nationality)
    {
        FirstName = firstName;
        LastName = lastName;
        Birthday = birthday;
        Age = age;
        Gender = gender;
        Profession = profession;
        Nationality = nationality;
    }

    // Método para formatar as informações da pessoa como uma string
    public override string ToString()
    {
        return $"His name is {FirstName} {LastName}, his birthday is {Birthday}, he is {Age} years old, his gender is {Gender}, his profession is {Profession}, and his nationality is {Nationality}";
    }
}

class Program
{
    static void Main()
    {
        // Criar uma instância de Person
        var I = new Person("Tiago", "Lobo", new DateOnly(2010, 3, 28), 13, "Male", "Student", "Portuguese");

        // Imprimir as informações da pessoa
        Console.WriteLine(I);
    }
}