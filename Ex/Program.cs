/*void PrintArray(double[,]matr)
{

for (int rows=0;rows<matr.GetLength(0); rows++)
{
    for(int colums =0; colums<matr.GetLength(1); colums++)
    {
        Console.Write($"{matr[rows, colums]} ");
    }
    Console.WriteLine();
}
}

void FillArray (double[,] matr)
{
    for (int rows=0;rows<matr.GetLength(0); rows++)
    {
        for(int colums =0; colums<matr.GetLength(1); colums++)
        {
        matr[rows,colums]= (new Random().NextDouble()*(10-1))+1;
        }
    }   
    
}

double[,] matrix = new double [3,4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// от романа
/*Console.WriteLine("Введите 2 числа, чтобы задать размерность массива");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
Random random = new Random();
int [,] matrix = new int [n,m];
for(int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++) 
  {
    matrix[i, j] = random.Next(-10, 10);
  } 

}

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"__{matrix[i,j]}__");
  }
  Console.WriteLine(" ");

}
*/

// от белова
/*void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = -array[i, j];
        }
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);
*/

//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)

//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }



// Console.Write("Введите количество строк двумерного массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов двумерного массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число для поиска в массиве ");
// int value = int.Parse(Console.ReadLine()!);

// int[,] array = new int[rows, columns];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();


//     for (int i = 0; i < array.GetLength(0); i++)

//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == value)
//             {
//                 Console.WriteLine($" позиция массива искомого элемента({i}, {j}).");
                

//             }
//             else 
//             {
//                 Console.WriteLine("такого значения нет");
//             }


//         }
//     }

// еще от белова ИСПОЛЬЗОВАТЬ WRITE, WRITELINE нельзя использовать в функциях (методах)
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SearchElement(int[,] array, int number)
{
    int row = -1;
    int column = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                row = i;
                column = j;
                Console.WriteLine($"Число {number} найдено в массиве в строке {i + 1} столбца {j + 1}");
                break;
            }
        }

        if (row != -1 && column != -1) break;
    }

    if (row == -1 && column == -1)
        Console.WriteLine($"Число {number} в массиве не найдено");
}

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите число для поиска в массиве: ");
int number = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SearchElement(array, number);



// int x = ReadInt("Введите искомое число: ");
// int count = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (matrix[i, j] == x)
//         {
//             count++;
//             Console.WriteLine($"{count}-я позиция искомого элемента({i}, {j}).");
//             // если только первое вхождение то break;
//         }
//     }
// }
// if (count == 0) Console.WriteLine("В массиве нет указанного элемента");

// Console.WriteLine();