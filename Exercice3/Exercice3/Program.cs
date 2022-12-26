class Person
{
    private int Age { get; set; }
    private string Name { get; set; }
    private string PhoneNumber { get; set; }

    private static void Main(string[] args)
    {
        Person person = new Person();
        person.Age = 40;
        person.Name= "Test";
        person.PhoneNumber= "1234567890";
        Console.WriteLine($"{person.Name} is {person.Age} years old, and the phone number is {person.PhoneNumber}");
    }
}
