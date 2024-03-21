//Даны массивы a и b, заполненные случайными числами.
// Необходимо создать массив c длиной, равной сумме
// длин массивов a и b, заполнить его элементами массивов
// a и b, отсортированными по возрастанию.

static void Main(string[] args)
{
    int[] a = new int[] { 4, 12, 6 };
    int[] b = new int[] { -2, 1, 68, 14 };
    int[] arrayResult = CreatArray(a, b);
    PrintArray(arrayResult);
    Console.WriteLine();

    Array.Sort(arrayResult);
    PrintArray(arrayResult);
}

 static int[] CreatArray(int[] a, int[] b)
{
    int[] result = new int[a.Length + b.Length];

    for (int i = 0; i < a.Length; i++)
    {
        result[i] = a[i];
    }

    for (int i = a.Length; i < result.Length; i++)
    {
        result[i] = b[i - a.Length];
    }
    return result;
}

static void PrintArray(int[] newArray)
{
    foreach (var item in newArray)
    {
        Console.Write(item + " ");
    }
}


// Дан двумерный массив.
//123
//456
//789
//Выведите его на печать перевернутым на 90 градусов
//741
//852
//963


static void Main(string[] args)
{

    int[,] array = {
{1, 2, 3},
{4, 5, 6},
{7, 8, 9}
};

    int y = array.GetLength(0);
    int x = array.GetLength(1);


    for (int i = 0; i < y; i++)
    {
        for (int j = x - 1; j >= 0; j--)
        {
            Console.Write(array[j, i]);
        }
        Console.WriteLine();
    }
}
}