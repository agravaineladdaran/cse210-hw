// Creativity:
// Added a session tracker that keeps count of how many
// mindfulness activities the user has completed during
// the current program session.

class Program
{
    static void Main(string[] args)
    {
        int activitiesCompleted = 0;
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();

            Console.WriteLine($"Activities completed this session: {activitiesCompleted}");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                activitiesCompleted++;
            }
            else if (choice == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                activitiesCompleted++;
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                activitiesCompleted++;
            }
        }

        Console.WriteLine($"Good job for completing {activitiesCompleted} activities today!");
    }
}