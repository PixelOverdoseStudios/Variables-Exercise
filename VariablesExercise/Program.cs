namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string characterName = "";
            int level = 1;
            char sex = 'm';
            bool magicUser = true;
            double experiencePoints = 75;
            decimal money = 60;

            Console.WriteLine("What is your name?");
            characterName = Console.ReadLine();

            Console.WriteLine($"Your name is {characterName}. Currently you are level {level} with {experiencePoints} EXP, and {money} gold.");
        }
    }
}
