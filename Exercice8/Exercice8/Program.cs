//Ejercicio 1 - While
//Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:
//1 x 1 = 1
//1 x 2 = 2
//…
//1 x 10 = 10

Console.WriteLine("Write a number to mulitply: ");
var pickedNumber = Convert.ToInt32(Console.ReadLine());
var number = 0;

while (number < 10)
{
    number++;
    var result = pickedNumber * number;
    Console.WriteLine($"{pickedNumber} x {number} = {result}");
}

//Ejercicio 2 - Do while
//Escribe un programa que realice estos pasos:
//Reciba al menos un número por consola
//Determine si el número es positivo o negativo

//¿¿¿Presente un contador para cada tipo (positivo y negativo).??? ¿Contador de qué tipo? ¿De uno en uno? ¿De dos en dos? ¿Creciente o decreciente?

//Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.
var exit = "";

do
{
    Console.WriteLine("Write a number or exit: ");
    var aux = Console.ReadLine();
    if (aux != "exit")
    {
        int numberIf = Convert.ToInt32(aux);

        if (numberIf > 0)
        {
            Console.WriteLine($"The number {numberIf} is positive");
        }
        else if (numberIf < 0)
        {
            Console.WriteLine($"The number {numberIf} is negative");
        }
        else
        {
            Console.WriteLine($"The number is zero");
        }
    }
    else
    {
        exit = aux;
    }
} while (exit != "exit");

//Ejercicio 3 - For
//Escribe un programa que realice estos pasos:
//Reciba 3 datos:
//ancho
//alto
//relleno o no
//Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y
//use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
//En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
//Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla.Ejemplos:
//Input: 2,2,2, relleno = true
//Output:
//** **
//** **
//Input: 3, 4, 1, relleno = false
//Output:
//***
//* *
//* *
//***

int wide;
int height;

Console.WriteLine("Write the wide: ");
wide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write the height: ");
height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select: \n" + "1 - Full \n" + "2 - Empty");
string option = Console.ReadLine();

if (option == "1")
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= wide; j++)
        {
            Console.Write("* ", j);
        }
        Console.WriteLine(" ");
    }
else
{
    string asterisk = new string('*', wide);
    for (int i = 0; i < height; i++)
    {
        if (i == 0 || i == (height - 1))
            Console.WriteLine(asterisk);
        else
            Console.WriteLine("*{0," + (wide - 2) + "}*", ' ');
    }
}