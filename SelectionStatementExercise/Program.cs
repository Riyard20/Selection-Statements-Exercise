namespace SelectionStatementExercise;

public class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        var favnumbers = random.Next(1, 11);
        int response = 0;

        while (response != favnumbers)
        {


            Console.WriteLine("Give me a number between 1 and 10:");
            response = int.Parse(Console.ReadLine());

            if (response < favnumbers)
            {
                Console.WriteLine($"Too low!\nYour guess: {response}");
            }
            else if (response > favnumbers)
            {
                Console.WriteLine($"Too high!\nYour guess: {response}");
            }
            else
            {
                Console.WriteLine($"Your guessed it!\nThe favorite number was  {favnumbers}!");
            }
        }
    }
}