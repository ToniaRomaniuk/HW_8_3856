// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine();
int[,] numbers = new int[rows, columns];

CreatArray(numbers);

Print(numbers);

void CreatArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            array[i, l] = new Random().Next(1, 100);
        }
    }

}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            System.Console.Write(array[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine($"Отсортированный массив: ");
SortArray(numbers);
Print(numbers);

void SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine();

int row = ReadInt("Введите количество строк: ");
int col = ReadInt("Введите количество столбцов: ");

int[,] numbers1 = new int[row, col];
CreatArray(numbers1);

Print(numbers1);

Console.WriteLine();

int minSumRow = 0;
int sum = SumElements(numbers1, 0);
for (int i = 1; i < numbers1.GetLength(0); i++)
{
  int tempSumRow = SumElements(numbers1, i);
  if (sum > tempSumRow)
  {
    sum = tempSumRow;
    minSumRow = i;
  }
}

Console.WriteLine($"{minSumRow+1} строкa с наименьшей суммой  элементов ({sum}) ");

int SumElements(int[,] array, int i)
{
  int sumElements = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumElements += array[i,j];
  }
  return sumElements;
}

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine();
int rows1 = ReadInt("Введите количество строк первой матрицы: ");
int columns1 = ReadInt("Введите количество столбцов первой матрицы: ");

Console.WriteLine();

int rows2 = ReadInt("Введите количество строк второй матрицы: ");
int columns2 = ReadInt("Введите количество столбцов второй матрицы: ");

Console.WriteLine();

int[,] firstMatrix = new int[rows1, columns1];
CreatArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
Print(firstMatrix);

Console.WriteLine();

int[,] secondMatrix = new int[rows2, columns2];
CreatArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
Print(secondMatrix);

Console.WriteLine();

int[,] resultMatrix = new int[rows1, columns2];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");

Console.WriteLine();

if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
{
  Console.WriteLine("такие матрицы умножать нельзя!");
  Console.WriteLine();
}
else
{
    Print(resultMatrix);
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    
    }
  }
}


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine($"Введите размер массива X x Y x Z:");
int x = ReadInt("Введите x: ");
int y = ReadInt("Введите y: ");
int z = ReadInt("Введите z: ");


int[,,] array3D = new int[x, y, z];
Create3DArray(array3D);
Print3DArray(array3D);

void Create3DArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void Print3DArray(int[,,] array3D)  
{
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                System.Console.Write($"{array3D[x, y, z]} ({x}, {y}, {z}) ");
            }
            System.Console.WriteLine();
        }
    }
}