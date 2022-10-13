/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

 
 void pritColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,]arrayToPrint)
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

void sredneArifmet(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
   {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
        sum += arr[i, j];
        }
        Console.WriteLine($"Средне арифметическое столбца {j} = { sum / arr.GetLength(0)} ");
    }
}

int[,] twoArray = 
{
    {6,4,7,1},
    {5,9,2,3},
    {8,4,3,5}
};

print2DArray(twoArray);
Console.WriteLine();
sredneArifmet(twoArray);



      

        
       
        
