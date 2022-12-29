//Escribe un programa que:
//Pida datos a un cliente: Nombre, email, cupón
//Determine si un cliente tiene un cupon descuento
//Muestre un precio rebajado en función del descuento
//Muestre el precio de un producto sin descuento si no hay cupón
//Nota: puedes poner un precio fijo de un producto o uno variable.

double product = 100;
string client, email, coupon;
Console.WriteLine("Write your name: ");
client = Console.ReadLine();
Console.WriteLine("Write your email: ");
email = Console.ReadLine();
Console.WriteLine("Select: \n 1- If you have a 25% coupon \n 2 - If you don't");
coupon = Console.ReadLine();

if (coupon == "1")
{
    Console.WriteLine($"{client} have a ticket for ${product * 0.75} \n");
}
else
{
    Console.WriteLine($"{client} have a ticket for ${product} \n");
}


//Ejercicio 2 - Switch
//Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. 
//Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.
//Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.

string option;
do
{
    Console.WriteLine("Select: \n 1 - C# \n 2 - C++ \n 3 - Java \n 4 - Python \n 9 - Exit Program \n");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("\n Your language selected is C# \n");
            break;
        case "2":
            Console.WriteLine("\n Your language selected is C++ \n");
            break;
        case "3":
            Console.WriteLine("\n Your language selected is Java \n");
            break;
        case "4":
            Console.WriteLine("\n Your language selected is Python \n");
            break;
        case "9":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine(" \n Please select a valid option \n");
            break;
    }
} while (option != "9");