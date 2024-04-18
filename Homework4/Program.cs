namespace Homework4
{
    internal class Program
    {
        //Дан массив и число.Найдите три числа в массиве сумма которых равна искомому числу.Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.
        static void Main()
        {
            int[] array = { 1, 4, 2, 6, 3, 8, 5 };
            int targetSum = 8;

            FindThreeNumbers(array, targetSum);
        }

        static void FindThreeNumbers(int[] array, int Sum)
        {
            Array.Sort(array);

            foreach (int firstNum in array)
            {
                int left = Array.IndexOf(array, firstNum) + 1;
                int right = array.Length - 1;

                while (left < right)
                {
                    int currentSum = firstNum + array[left] + array[right];

                    if (currentSum == Sum)
                    {
                        Console.WriteLine($"Числа: {firstNum}, {array[left]}, {array[right]}");
                        return;
                    }
                    else if (currentSum < Sum)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            Console.WriteLine("Три числа не найдены");
        }
    }
}
