// See https://aka.ms/new-console-template for more information
int[] notasPerfectas = new int[10];
int[] notasMejorables = new int[10];
int x = 0;
int y = 0;
int nota = 0;

while (x < 10 || y < 10)
{
    Console.Write("Ingrese sus notas: ");
    nota = int.Parse(Console.ReadLine());
    if (nota >= 70)  // Ingresan notas mayores o iguales a 70
    {
        if (x < 10)
        {
            for (int j = x; j < notasPerfectas.Length;)
            {
                notasPerfectas[j] = nota;
                x++;
                break;
            }
        }
        else
        {
            Console.WriteLine("El array con notas mayores o iguales se encuentra lleno, porfavor ingrese notas menores a 70");
        }

    }
    else
    {
        if (y < 10)
        {
            for (int j = y; j < notasMejorables.Length;)
            {
                notasMejorables[j] = nota;
                y++;
                break;
            }
        }
        else
        {
            Console.WriteLine("El array con notas menores o iguales se encuentra lleno, porfavor ingrese notas mayores o iguales a 70");
        }
    }
}


for (int r = 0; r < notasPerfectas.Length; r++)
{
    Console.Write(" " + notasPerfectas[r] + ", ");
}

for (int r = 0; r < notasMejorables.Length; r++)
{

    Console.Write(" " + notasMejorables[r] + ", ");
}
Console.ReadLine();