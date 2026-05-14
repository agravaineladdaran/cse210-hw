using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int grade_num = int.Parse(grade);

        string letter;

        if (grade_num>=90)
        {
            letter = "A";
        }
        else if (grade_num>=80)
        {
            letter = "B";
        }
        else if (grade_num>=70)
        {
            letter = "C";
        }
        else if (grade_num>=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade_num>=70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You didn't pass this time, but progress comes with effort. Keep trying!");
        }
    }
}