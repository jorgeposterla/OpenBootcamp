//Crea una estructura de datos para un cliente con estos campos:
//Nombre completo
//Teléfono
//Dirección
//Email
//Si es nuevo cliente
//Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)

Client client1 = new Client("Rick", "Morty", "123456789", "Av. EverGreen 123", "test@test.com", true);
Console.WriteLine(client1);
struct Client
{
    public Client(string name, string lastName, string phoneNumber, string address, string email, bool newClient)
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Address = address;
        Email = email;
        NewClient = newClient;
    }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public bool NewClient { get; set; }

    public override string ToString() => $"{Name} {LastName} with phone number {PhoneNumber}, lives in {Address} and has email {Email} is new client: {NewClient}";
}