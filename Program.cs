namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int sol = 0;
                int number1 = Convert.ToInt32(args[0]);
                string symbol = args[1];
                int number2 = Convert.ToInt32(args[2]);
                if (symbol == "+")
                {
                    sol = number1 + number2;
                }
                if (symbol == "-")
                {
                    sol = number1 - number2;
                }
                if (symbol == "/")
                {
                    sol = number1 / number2;
                }
                if (symbol == "*")
                {
                    sol = number1 * number2;
                }
                Console.WriteLine($"{args[0]} {symbol} {args[2]} = {sol}");

            }

        }

    }
}
