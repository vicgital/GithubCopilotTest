// See https://aka.ms/new-console-template for more information
using System.Text.Json;

Console.WriteLine("Hello, World!");

var person = new Person
{
    FirstName = "John",
    LastName = "Doe"
};

Console.WriteLine(person.GetFullName());


public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public override string ToString() =>
     JsonSerializer.Serialize(this);


}
