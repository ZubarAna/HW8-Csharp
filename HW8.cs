/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i, j] = new Random().Next(-10, 11);
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }   
        Console.WriteLine(); 
    }
}
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Исходный массив: ");

int [,] matrix = new int [n, m];
InputMatrix(matrix);
PrintMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int a = 0; a < matrix.GetLength(1) - 1; a++)
        {
            if (matrix[i, a] < matrix[i, a + 1]) 
            {
                int temp = 0;
                temp = matrix[i, a];
                matrix[i, a] = matrix[i, a + 1];
                matrix[i, a + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с элементами в порядке убывания: ");
PrintMatrix(matrix);
*/

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
/*

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i, j] = new Random().Next(-10, 11);
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }   
        Console.WriteLine(); 
    }
}
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Исходная матрица: ");

int [,] matrix = new int [n, m];
InputMatrix(matrix);
PrintMatrix(matrix);

int line = 0;
int sum0 = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < sum0)
    {
        sum0 = sum;
        line++;
    }
}

Console.WriteLine( (line)+1 + "-я строка");
*/

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i, j] = new Random().Next(0, 5);
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }   
        Console.WriteLine(); 
    }
}
Console.Write("Введите размерность матриц: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix1 = new int [n, n];
int [,] matrix2 = new int [n, n];

InputMatrix(matrix1);
InputMatrix(matrix2);

int [,] matrix = new int [n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            matrix[i, j] = matrix[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица 1");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц 1*2");
PrintMatrix(matrix);
*/

/* ЗЗадача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i, j] = new Random().Next(0, 5);
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }   
        Console.WriteLine(); 
    }
}

Console.Write("Введите количество строк/столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, n];

InputMatrix(matrix);

int num = 1;
int i = 0;
int j = 0;

while (num <= n * n)
{
    matrix[i, j] = num;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++num;
}
Console.WriteLine("Спиральный массив: ");
PrintMatrix(matrix);
*/