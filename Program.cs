/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

/*int[,] CreateRandom2dArray() // Функция по созданию двумерного массива
{
    Console.Write("Input a quartity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quartity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns]; // Выделяем память под двумерный массив

    for (int i = 0; i < rows; i++) // Логика прохождения по массиву
        for (int j = 0; j < columns; j++)

            array[i, j] = new Random().Next(min, max + 1); // Заполнение элементов случайным образом
    return array; // Возвращаем массив
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void SortLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;

                }
            }

        }
    }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
SortLine(myArray);
Show2dArray(myArray);*/


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] CreateRandom2dArray() // Функция по созданию двумерного массива
{
    Console.Write("Input a quartity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quartity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns]; // Выделяем память под двумерный массив

    for (int i = 0; i < rows; i++) // Логика прохождения по массиву
        for (int j = 0; j < columns; j++)

            array[i, j] = new Random().Next(min, max + 1); // Заполнение элементов случайным образом
    return array; // Возвращаем массив
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void SearchLineMinSum(int[,] array)
{
    int minSum = int.MaxValue; // Инициализация минимальной суммы как бесконечность
    int minSumRowIndex = 0; // Индекс строки с минимальной суммой
    
    int rows = array.GetLength(0); // Количество строк в массиве
    int columns = array.GetLength(1); // Количество столбцов в массиве
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0; // Сумма элементов строки
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        if (rowSum < minSum) // Если текущая сумма меньше минимальной суммы
        {
            minSum = rowSum; // Обновляем минимальную сумму
            minSumRowIndex = i+1; // Обновляем индекс строки с минимальной суммой
        }
    }
    Console.Write($"Row with the smallest sum of elements: " + minSumRowIndex);
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SearchLineMinSum(myArray);




/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
Чтобы найти произведение двух матриц нужно умножать последовательно 
каждый элемент каждой строки первой матрицы на каждый элемент каждого столбца второй матрицы 
и сумму этих произведений записать в соответствующем элементе матрицы-произведения.
Операция умножения двух матриц выполнима только в том случае, 
если число столбцов в первом сомножителе равно числу строк во втором
*/


int[,] CreateRandom2dArray() // Функция по созданию двумерного массива
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns]; // Выделяем память под двумерный массив

    for (int i = 0; i < rows; i++) // Логика прохождения по массиву
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1); // Заполнение элементов случайным образом

    return array; // Возвращаем массив
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] MultiplicationArrays(int[,] array1, int[,] array2) // Функция для нахождения произведения двух массивов
{
    int[,] productArrays = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < productArrays.GetLength(0); i++)
    {
        for (int j = 0; j < productArrays.GetLength(1); j++)
            for (int n = 0; n < array1.GetLength(1); n++)
            {
                productArrays[i, j] = productArrays[i, j] + (array1[i, n] * array2[n, j]);
            }

    }

    return productArrays;
}

int[,] myArray1 = CreateRandom2dArray();
Show2dArray(myArray1);
Console.WriteLine();
int[,] myArray2 = CreateRandom2dArray();
Show2dArray(myArray2);

int[,] resultArray = MultiplicationArrays(myArray1, myArray2);
Show2dArray(resultArray);


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] CreateRandom3dArray() // Функция по созданию трехмерного массива
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of depth: ");
    int depth = Convert.ToInt32(Console.ReadLine());

    int minValue = 10;
    int maxValue = 99;

    int[,,] array = new int[rows, columns, depth];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                int num = 0;
                do
                {
                    num = new Random().Next(minValue, maxValue + 1);
                } while (ControlNumber(num, array, i, j, k));

                array[i, j, k] = num;
            }

    return array;
}

bool ControlNumber(int number, int[,,] array, int rows, int columns, int depth)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                if (array[i, j, k] == number)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");

            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
    int[,,] myArray = CreateRandom3dArray();
    Show3dArray(myArray);


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    int number = 1;
    int maxValue = rows * columns;
    int minRows = 0;
    int minColumns = 0;
    int maxRows = rows - 1;
    int maxColumns = columns - 1;

    while (number <= maxValue)
    {
        if (maxColumns - minColumns > 0)
        {
            for (int j = minColumns; j <= maxColumns; j++)
            {
                array[minRows, j] = number;
                number = number + 1;
            }
            minRows = minRows + 1;
        }

        if (maxRows - minRows > 0)
        {
            for (int i = minRows; i <= maxRows; i++)
            {
                array[i, maxColumns] = number;
                number = number + 1;
            }
            maxColumns = maxColumns - 1;
        }

        if (maxColumns - minColumns > 0)
        {
            for (int j = maxColumns; j >= minColumns; j--)
            {
                array[maxRows, j] = number;
                number = number + 1;
            }
            maxRows = maxRows - 1;
        }

        if (maxRows - minRows > 0)
        {
            for (int i = maxRows; i >= minRows; i--)
            {
                array[i, minColumns] = number;
                number = number + 1;
            }
            minColumns = minColumns + 1;
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("D3") + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);