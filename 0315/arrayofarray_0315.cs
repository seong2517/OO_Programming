using System;
class ArrayOfArray
{
    public static void Main()
    {
        int[][] arrayOfArray = new int[3][]; // declaration
        int i, j;

        for (i = 0; i < arrayOfArray.Length; i++) // creation
            arrayOfArray[i] = new int[i + 3];

        for (i = 0; i < arrayOfArray.Length; i++) // using
            for (j = 0; j < arrayOfArray[i].Length; j++)
                arrayOfArray[i][j] = i * arrayOfArray[i].Length + j;

        for (i = 0; i < arrayOfArray.Length; i++)
        { // printing
            for (j = 0; j < arrayOfArray[i].Length; j++)
                Console.Write(" " + arrayOfArray[i][j]);
            Console.WriteLine();
        }
    }
}