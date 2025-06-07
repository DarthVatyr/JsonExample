using Newtonsoft.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        string json = @"{ ""Name"": ""Alice"", ""Age"": 30 }";
        Person person = JsonConvert.DeserializeObject<Person>(json);

        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // Create a new Person object
        Person newPerson = new Person { Name = "Bob", Age = 25 };

        // Serialize the Person object to a JSON string
        string newJson = JsonConvert.SerializeObject(newPerson);

        Console.WriteLine($"Serialized JSON: {newJson}");
    }
}
