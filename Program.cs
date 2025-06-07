using Newtonsoft.Json; // Import the Newtonsoft.Json library for JSON serialization/deserialization

// Define a simple Person class with Name and Age properties
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // JSON string representing a person
        string json = @"{ ""Name"": ""Alice"", ""Age"": 30 }";

        // Deserialize the JSON string into a Person object
        Person person = JsonConvert.DeserializeObject<Person>(json);

        // Output the deserialized Person object's properties
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // Create a new Person object in C#
        Person newPerson = new Person { Name = "Bob", Age = 25 };

        // Serialize the new Person object to a JSON string
        string newJson = JsonConvert.SerializeObject(newPerson);

        // Output the serialized JSON string
        Console.WriteLine($"Serialized JSON: {newJson}");
    }
}
