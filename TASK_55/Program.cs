/*
Задача 55: 
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int[,] GenerateArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);

        }
    }
    return array;
}

void PrintArray(int[,] printToArray)
{
    for (var i = 0; i < printToArray.GetLength(0); i++)
    {
        for (var j = 0; j < printToArray.GetLength(1); j++)
        {
            Console.Write($"   {printToArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int[,] ReplaceArray(int[,] replaceArray)
{
    int[,] temp = new int[replaceArray.GetLength(0), replaceArray.GetLength(1)];

    for (var i = 0; i < replaceArray.GetLength(0); i++)
    {
        for (var j = 0; j < replaceArray.GetLength(1); j++)
        {
            temp[i, j] = replaceArray[j, i];
        }
    }
    return temp;

}

var array = new int[3, 2];
int[,] result = GenerateArray(array);
PrintArray(result);

System.Console.WriteLine("------------------------------------------------");

if (result.GetLength(0) != result.GetLength(1))
{
    Console.WriteLine($"Невозможно");
}
else
{
    int[,] replaceArray = ReplaceArray(result);
    PrintArray(replaceArray);
}