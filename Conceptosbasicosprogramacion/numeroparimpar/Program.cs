// See https://aka.ms/new-console-tem plate for more information
using System.Diagnostics;

Console.WriteLine("Ingrese un numero:");
var numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.Write("El numero es par");

}
else
{
    Console.Write("El numero es impar");


}
