// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rowsRandom = new Random().Next(2, 10);
int columnsRandom = new Random().Next(2, 10);

int[,] matrix = new int[rowsRandom, columnsRandom];

void GetArray() // Реализация функции наполнения и вывода массива.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

GetArray(); // Вызов функции наполнения и вывода массива.

Console.WriteLine();

Console.WriteLine("Enter the row's number:"); // Запрос ряда от пользователя.
int rowAsk = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the column's number:"); // Запрос столбца от пользователя.
int columnAsk = Convert.ToInt32(Console.ReadLine());

bool IsValidNumber(int row, int column) // Реализация функции проверки наличия указанной позиции.
{
    if ((row > rowsRandom) || (column > columnsRandom))
    {
        Console.WriteLine("The number by this position is not exists.");
        Console.WriteLine();
        return false;
    }
    else
    {
        return true;
    }
}

IsValidNumber(rowAsk, columnAsk); // Вызов функции проверки наличия указанной позиции.

System.Console.WriteLine("Your position value is: " + matrix[rowAsk, columnAsk]);
Console.WriteLine();