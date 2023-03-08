static void Task53()
{
    /*Задача 53: Задайте двумерный массив. Напишите программу, 
    которая поменяет местами первую и последнюю строку массива.*/


    int[,] TwoRandomArray()
    {
        Console.WriteLine("Введите количество строк двумерного массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов двумерного массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m, n];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(array[i, j] + " ");
            }
        }
        return array;
    }
       
        int[,] array = TwoRandomArray();
        System.Console.WriteLine();
        System.Console.WriteLine();
        ReadArray(ChangedRowsArray(array));


        int[,] ChangedRowsArray(int[,] array)
    {

        int m = array.GetLength(0);
        int n = array.GetLength(1);
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int tmparray = array[0,i];
            array[0, i] = array[m - 1, i];
            array[m - 1, i] = tmparray;
        }
        return array;
    }

        void ReadArray(int[,] array)
        {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
            System.Console.Write("{0:d2} ", array[i, j]);
            }
            System.Console.WriteLine();
        }
        }
}

/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

int[,] TwoRandomArray()
{
  Console.WriteLine("Введите количество строк двумерного массива: ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите количество столбцов двумерного массива: ");
  int n = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[m, n];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 11);
      Console.Write(array[i, j] + " ");
    }
  }
  return array;
}
int[,] array = TwoRandomArray();
System.Console.WriteLine("\n");
// ReadArray(ChangedRowsArray(array));
ReadArray(ChangeRowsWithColumns(array));

int[,] ChangeRowsWithColumns(int[,] array)
{
  int m = array.GetLength(0);
  int n = array.GetLength(1);

  int[,] newArray = new int[m, n];

  if (m != n)
    System.Console.WriteLine("Массив не подходит!!!");
  else
  {
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        newArray[i,j] = array[j,i];
      }
    }
  }
  return newArray;
}

int[,] ChangedRowsArray(int[,] array)
{

  int m = array.GetLength(0);
  int n = array.GetLength(1);
  for (int i = 0; i < array.GetLength(1); i++)
  {
    int tmparray = array[0, i];
    array[0, i] = array[m - 1, i];
    array[m - 1, i] = tmparray;
  }
  return array;
}

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0:d2} ", array[i, j]);
    }
    System.Console.WriteLine();
  }
}

static void task57()
{//задача с числовым дневником

int[,] TwoRandomArray()
{
  Console.WriteLine("Введите количество строк двумерного массива: ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите количество столбцов двумерного массива: ");
  int n = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[m, n];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 11);
      Console.Write(array[i, j] + " ");
    }
  }
  return array;
}
int[,] array = TwoRandomArray();
System.Console.WriteLine("\n");
// ReadArray(ChangedRowsArray(array));
// ReadArray(ChangeRowsWithColumns(array));
int[] convertedArray = ConvertedArray(array);
Array.Sort(convertedArray);
System.Console.WriteLine(String.Join(" ",convertedArray));
CountElements(convertedArray);

void CountElements(int [] sortedArray)
{
  int element = sortedArray[0];
  int count = 1;
  for (int i = 1; i < sortedArray.Length; i++)
  {
    if(element == sortedArray[i])
    count++;
    else
    {
    System.Console.WriteLine($"Элемент : {element} встретился {count} раз");
    element = sortedArray[i];
    count = 1;
    }
  }
  System.Console.WriteLine($"Элемент : {element} встретился {count} раз");
}

int[] ConvertedArray(int[,] array)
{
  int m = array.GetLength(0);
  int n = array.GetLength(1);
  int arrayIndex = 0;

  int[] newArray = new int[m * n];
  foreach (int item in array)
  {
    newArray[arrayIndex] = item;
    arrayIndex++;
  }
  return newArray;
}

int[,] ChangeRowsWithColumns(int[,] array)
{
  int m = array.GetLength(0);
  int n = array.GetLength(1);

  int[,] newArray = new int[m, n];

  if (m != n)
    System.Console.WriteLine("Массив не подходит!!!");
  else
  {
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        newArray[i, j] = array[j, i];
      }
    }
  }
  return newArray;
}

int[,] ChangedRowsArray(int[,] array)
{

  int m = array.GetLength(0);
  int n = array.GetLength(1);
  for (int i = 0; i < array.GetLength(1); i++)
  {
    int tmparray = array[0, i];
    array[0, i] = array[m - 1, i];
    array[m - 1, i] = tmparray;
  }
  return array;
}

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0:d2} ", array[i, j]);
    }
    System.Console.WriteLine();
  }
}
}

static void task59()
{
    int[,] arr = FillArray(4, 4);
    ShowDuoArray(arr);

    int[,] FillArray(int firstDimension, int secondDimension) // Заполнение двумерного массива с заданной размерностью.
    {
        int[,] arr = new int[firstDimension, secondDimension];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(0, 11);
            }
        }
        return arr;
    }

    void ShowDuoArray(int[,] arr) // Вывод массива на экран.
    {
        Console.WriteLine();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
        }
    }

    int[] indexMinValue = FindMinEl(arr);
    DeleteRowsColumns(arr, indexMinValue);

    Console.ReadLine();


    int[] FindMinEl(int[,] arr)
    {
        int minValue = arr[0, 0];
        int[] indexMinValue = new int[2];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (minValue > arr[i, j])
                {
                    minValue = arr[i, j];
                    indexMinValue[0] = i;
                    indexMinValue[1] = j;
                }

            }
        }
        return indexMinValue;
    }

    void DeleteRowsColumns(int[,] arr, int[] index)
    {
        int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
        int a = 0, b = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (index[0] == i) continue;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (index[1] == j) continue;

                newArr[a, b] = arr[i, j];
                b++;
            }
            a++;
            b = 0;
        }
        ShowDuoArray(newArr);
    }
}

task59();

