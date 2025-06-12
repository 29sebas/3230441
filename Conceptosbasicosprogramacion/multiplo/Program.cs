do
{
    Console.WriteLine("ingrese primer numero entero");
    var N1 = (Console.ReadLine());

    if (int.TryParse(N1, out int N1Int))
    {
        Console.Write("ingrese segundo numero entero:");
        var N2 = (Console.ReadLine());
        if (int.TryParse(N2, out int N2Int))
        {
            if (N2Int % N2Int == 0)
            {
                Console.WriteLine($"el numero: {N2}, es multiplo de:{N1} ");
            }
            else
            {
                Console.WriteLine($"el numero: {N2}, no es multiplo de:{N1} ");
            }
        } else
        {
            Console.WriteLine("debes ingresar un numero entero");
        }
    }        
    else
    {
        Console.WriteLine("debes ingresar un numero entero");
    }





















        


} while (true);
Console.WriteLine("ingrese primer numero entero");




