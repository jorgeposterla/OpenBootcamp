class Program
{
    private static void Main(string[] args)
    {
        var client1 = new Client
        {
            Age = 40,
            Name = "Client1",
            PhoneNumber = "1234567890",
            Credit = 1500
        };
        Console.WriteLine($"{client1.Name} is {client1.Age} years old, owns a {client1.Credit} credit and the phone number is {client1.PhoneNumber} \n");

        var worker1 = new Worker
        {
            Age = 36,
            Name = "Worker1",
            PhoneNumber = "0987654321",
            Salary = 2500
        };
        Console.WriteLine($"{worker1.Name} is {worker1.Age} years old, owns a {worker1.Salary} salary and the phone number is {worker1.PhoneNumber}");
    }
}
class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}
class Client : Person
{
    public double Credit { get; set; }
}

class Worker : Person
{
    public double Salary { get; set; }
}