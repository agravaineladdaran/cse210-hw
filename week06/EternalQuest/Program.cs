// EXCEEDING REQUIREMENTS:
// Added a level system that rewards users with titles
// based on their accumulated score.
// 0 - 499 points     = Beginner
// 500 - 999 points = Disciple
// 1000 - 1499 points = Pathfinder
// 1500+ points     = Eternal Quest Master


class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}