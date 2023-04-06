// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] test = { 32, 87, 3, 45, 76, 34, 65, 85, 74, 93 };
int opcion = 0;
bool encontrado = false;

do
{
    Console.WriteLine("Ingrese un numero para ver si lo tenemos en nuestro array");
    int num = int.Parse(Console.ReadLine());

    for (int i = 0; i < test.Length; i++)
    {
        if (test[i] == num)
        {
            encontrado = true;
        }
        
    }
    if (encontrado == true)
    {
        Console.WriteLine("El valor se encuentra");
        encontrado = false;
    }
    else
    { 
        Console.WriteLine("El valor no se encuentra");
    }
    Console.WriteLine("Quiere intentarlo otra vez?\n1- Si\n2- No");
    opcion = int.Parse(Console.ReadLine()); 
} while (opcion != 2);