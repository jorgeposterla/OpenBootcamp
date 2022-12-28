//Variables Escribe un programa que reciba datos de una persona y genera un mensaje, 
//usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
using System.Drawing;

string name = "Rick";
string lastname = "Morty";
int age = 40;
bool isDev = true;
string message = $"Name: {name} {lastname}. Age: {age}. Is developer: {isDev}";
Console.WriteLine(message);


//Operadores Determina los operadores para verificar las siguientes condiciones:
//Un número es mayor o igual a 18
//Un char es ‘a’
//Se cumplen dos conciones a la vez (ambas verdaderas)
//Se cumple una de dos condiciones a la vez (una true y otra false)
//Nota: puedes escribir estos datos por consola si prefieres verlos. 
//La idea del ejercicio es almacenar los datos en los tipos más adecuados.
//int evalNumber = 18;
Console.WriteLine("Write a number: ");
var number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write a character: ");
char a = Convert.ToChar(Console.ReadLine());

if (number >= 18 && a == 'a')
{
    Console.WriteLine("Both are right");
}
else if (number >= 18 || a == 'a')
{
    Console.WriteLine("One is right");
}
else
{
    Console.WriteLine("Both are wrong");
}


//Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
//Coche: puertas, ruedas, marca, ITV vigente
//Mesa: peso, largo, material, color
//Nota: puedes escribir estos datos por consola si prefieres verlos. 
//La idea del ejercicio es almacenar los datos en los tipos más adecuados.
class Car
{
    int doors = 4;
    int wheels = 5;
    string brand = "Rover";
    bool ITV = true;
}

class Table
{
    string material = "wood";
    double weitghKg = 10.5;
    int longCm = 120;
    int wideCm = 70;
    string color = "brown";
}