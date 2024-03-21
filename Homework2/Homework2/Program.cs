namespace Homework2
{
    internal class Program
    {

        static void Main()
        {
            int[,] array = new int[,]
            {
            { 7, 3, 2 },
            { 4, 9, 6 },
            { 1, 8, 5 }
            };

            int x = array.GetLength(0);
            int y = array.GetLength(1);
            
            int[] Array2 = new int[x * y];
            int index = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Array2[index++] = array[i, j];
                }
            }

            Array.Sort(Array2);

            index = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = Array2[index++];
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}