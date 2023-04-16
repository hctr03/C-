Random random = new Random(); 
int[,] numeros = new int[10, 10];

for(int x = 0; x<10; x++)
{
    for (int y = 0; y <10; y++) 
    {
        numeros[x, y] = random.Next(0,100);
    }
}
Console.WriteLine("Ingrese un numero para buscarlo en el Array: ");
int numeroPreguntado = int.Parse(Console.ReadLine());

Console.Write("Numeros que se llenaron en el array:");


for (int i = 0; i < 10; i++)
{
    Console.Write("\n");
    for (int j = 0; j < 10; j++)
    {
        Console.Write(numeros[i, j] + " ");
    }
}

Console.Write("\n");
Console.Write("\n");
Console.Write("\n");
Console.Write("\n");

bool resultado = false;
for (int i = 0; i < 10; i++)
{
    
    for (int y = 0; y < 10; y++)
    {
        if (numeros[i, y] == numeroPreguntado)
        {
            resultado = true; 
            break;
        }
    }   
}

if (resultado == true) 
{ 
    Console.WriteLine("El numero se encontraba");
}
else 
{ 
    Console.WriteLine("Numero no se encontro"); 
}


