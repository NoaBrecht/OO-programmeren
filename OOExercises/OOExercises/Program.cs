namespace OOExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!");
            Console.WriteLine("Topic van de uit te voeren oefening?");
            Console.WriteLine("1. DateTime");
            Console.WriteLine("2. Properties en access modifiers");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DateTimeExersices.ShowSubmenu();
                    break;
                default:
                    Console.WriteLine("Foutieve optie");
                    break;
            }
        }
    }
}
