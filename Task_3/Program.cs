// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rowsRandom = new Random().Next(2, 10);
int columnsRandom = new Random().Next(2, 10);

int[,] matrix = new int[rowsRandom, columnsRandom];

double[] average = new double[columnsRandom]; // Массив средних арифметических.

void GetArray() // Реализация функции наполнения и вывода массива.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
            SetEachColumnSum(i, j); // Вызов функции наполнения массива средних арифметических.
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SetEachColumnSum(int i, int j) // Реализация функции наполнения массива средних арифметических.
{
    average[j] += matrix[i, j]; // Пока заполняем суммой элементов столбцов.
}

GetArray(); // Вызов функции наполнения и вывода массива.

void GetEachColumnAverage() // Реализация функции определения и вывода средних арифметических.
{
    Console.Write("The average numbers of each column are: ");

    for (int i = 0; i < average.Length; i++)
    {
        average[i] = Math.Round((average[i] / rowsRandom), 1); // Определяем среднее арифметическое.
        Console.Write(average[i] + " ");
    }
}

GetEachColumnAverage(); // Вызов функции определения и вывода средних арифметических.