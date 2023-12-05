using System;

class Project
{
    static void Main()
    {
        const int rows = 7;
        const int columns = 3;
        int[,] matInt = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matInt[i, j] = Convert.ToInt16(Console.ReadLine());
            }
        }

        // Calcular la matriz traspuesta
        int[,] traspuesta = new int[columns, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                traspuesta[j, i] = matInt[i, j];
            }
        }
        // Mostrar la matriz traspuesta
        Console.WriteLine("La matriz traspuesta es:");
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(traspuesta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
