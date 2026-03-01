Console.WriteLine("Mostrar un patrón donde cada fila tenga el número de la fila repetido.");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}