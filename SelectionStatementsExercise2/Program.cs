namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string userInput = Console.ReadLine();

            switch (userInput) 
            {
                case "math":
                    Console.WriteLine("Math, that's pretty cool I guess.");
                    break;
                case "english":
                    Console.WriteLine("English? Really? I guess books are pretty cool.");
                    break;
                case "science":
                    Console.WriteLine("Science? That's a pretty stereotypical answer ngl.");
                    break;
                case "history":
                    Console.WriteLine("History? You're quite the nerd aren't you?");
                    break;
                case "art":
                    Console.WriteLine("Art, we've got an artist amongst us don't we?");
                    break;
                case "music":
                    Console.WriteLine("Music? Are you sure? Like sure sure?");
                    break;
                default:
                    Console.WriteLine("Couldn't find subject in the list, try again, maybe all lowercase?");
                    break;
            }
        }
    }
}