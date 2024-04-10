using MainPage;

namespace GuessNumber;

public class Choose_Difficulty
{
    public void ChooseDifficulty()
    {
        Guess_Number_Game guess_Number = new Guess_Number_Game();
        Dividingline dividingline = new Dividingline();
        Error_Message error_Message = new Error_Message();
        Choose_Difficulty choose_Difficulty = new Choose_Difficulty();
        Navbar navbar = new Navbar();

        List<string> chooseDifficultyList = new List<string>();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Willkommen bei ZAHLEN RATEN\n\n");
        Console.ResetColor();

        chooseDifficultyList.Add("Wähle deine Schwierigkeitsstufe\n");
        chooseDifficultyList.Add("1. Leicht");
        chooseDifficultyList.Add("2. Mittel");
        chooseDifficultyList.Add("3. Schwer\n");

        foreach (string difficulty in chooseDifficultyList)
        {
            Console.WriteLine(difficulty);
        }

        dividingline.Border();

        string? userInput = Console.ReadLine();

        if (userInput != null)
        {
            switch (userInput.Trim().ToLower())
            {
                case "1":
                    guess_Number.GuessNumberEasy();
                    break;

                case "2":
                    guess_Number.GuessNumberMedium();
                    break;

                case "3":
                    guess_Number.GuessNumberHard();
                    break;

                default:
                    error_Message.ErrorMessage();
                    Thread.Sleep(1000);
                    Console.Clear();
                    dividingline.Border();
                    choose_Difficulty.ChooseDifficulty();
                    break;
            }
        }
        else
        {
            error_Message.ErrorMessage();
        }

    }
}