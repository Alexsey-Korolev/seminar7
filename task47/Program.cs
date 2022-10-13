/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/


double[,] generate2DArray(int height, int width /*, int start, int end*/)
{
    double[,] twoDArray = new double[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            //twoDArray[i,j] = new Random().Next(start, end + 1) / 10.0;
            twoDArray[i,j] = Math.Round(((new Random().NextDouble()) * new Random().Next(-100,100)),2);
        }
    }
    return twoDArray;
}
void pritColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(double[,]arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        pritColorData(i+ "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        pritColorData(i+ "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] generatedArray = generate2DArray(3, 4 /*, -100, 100 */);
print2DArray(generatedArray);