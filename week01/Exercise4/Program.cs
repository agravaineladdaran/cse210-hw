using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int user_input = -1;

        while (user_input != 0)
        {
            Console.Write("Enter number: ");
            user_input = int.Parse(Console.ReadLine());

            if (user_input != 0)
            {
                numbers.Add(user_input);
            }
        }

        if (numbers.Count > 0)
        {

            int sum = 0;
            int max = numbers[0];

            foreach (int num in numbers)
            {
                sum+=num;

                if (num > max)
                {
                    max = num;
                }
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum} ");
            Console.WriteLine($"The average is: {average} ");
            Console.WriteLine($"The largest number is: {max}");
        }
    }
}