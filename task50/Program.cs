/*Задача 50. Напишите программу, которая на вход принимает позицию элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание,
  что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
5 -> 9

индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4*/

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

//int[,] twoArray = 
//{
  //  {1,4,7,2},
    //{5,9,2,3},
    //{8,4,2,4}
//};
void positionElemet(int[,] twoArray)
{
    Console.Write("Введите число позиции элемента: ");
    int position = Convert.ToInt32(Console.ReadLine());
    Console.Write($"{position} = ");
    
    if (twoArray.GetLength(0) * twoArray.GetLength(1) < position +1 )
    {
        Console.WriteLine("такой позиции в массиве нет!");
        return;
    }
    int count = 0;
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            if (count == position)
            {
                Console.WriteLine(twoArray[i, j]);
                return;
            }
            count++;
        }
    }
}

int[,] twoArray = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

print2DArray(twoArray);
positionElemet(twoArray);









