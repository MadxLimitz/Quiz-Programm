using MainPage;

namespace GuessNumber;

public class Guess_Number_Game
{
    public void GuessNumberEasy()
    {
        Dividingline dividingline = new Dividingline();
        Loading_Main_Page_Message loading_Main_Page_Message = new Loading_Main_Page_Message();
        Main_Page main_Page = new Main_Page();

        Random random = new Random();
        int numberToGuess = random.Next(0, 11);
        int attempts = 0;
        bool guessedCorrectly = false;

        Console.Clear();
     
        while (!guessedCorrectly)
        {
            dividingline.Border();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ich habe eine Zahl zwischen 1 und 10 ausgewählt. Versuche, sie zu erraten!\n");
            Console.ResetColor();
            Console.Write("Gib deine Vermutung ein: \n\n");
            dividingline.Border();

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int userGuess))
            {
                attempts++;

                if (userGuess < numberToGuess)
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.WriteLine("Die gesuchte Zahl ist höher.\n");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.WriteLine("Die gesuchte Zahl ist niedriger.\n");
                }
                else
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Richtig! Du hast die Zahl {numberToGuess} in {attempts} Versuchen erraten.\n");
                    Console.ResetColor();
                    dividingline.Border();
                    Thread.Sleep(5000);
                    guessedCorrectly = true;
                }
            }
            else
            {
                Console.Clear();
                dividingline.Border();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe, Bitte gib eine ganze Zahl ein.\n");
                Console.ResetColor();
                dividingline.Border();
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
        loading_Main_Page_Message.LoadingMainPageMessage();
        main_Page.MainPage();
    }

    public void GuessNumberMedium()
    {
        Dividingline dividingline = new Dividingline();
        Loading_Main_Page_Message loading_Main_Page_Message = new Loading_Main_Page_Message();
        Main_Page main_Page = new Main_Page();

        Random random = new Random();
        int numberToGuess = random.Next(0, 51);
        int attempts = 0;
        bool guessedCorrectly = false;

        Console.Clear();

        while (!guessedCorrectly)
        {
            dividingline.Border();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ich habe eine Zahl zwischen 1 und 50 ausgewählt. Versuche, sie zu erraten!\n");
            Console.ResetColor();
            Console.Write("Gib deine Vermutung ein: \n\n");
            dividingline.Border();

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int userGuess))
            {
                attempts++;

                if (userGuess < numberToGuess)
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.WriteLine("Die gesuchte Zahl ist höher.\n");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.WriteLine("Die gesuchte Zahl ist niedriger.\n");
                }
                else
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Richtig! Du hast die Zahl {numberToGuess} in {attempts} Versuchen erraten.\n");
                    Console.ResetColor();
                    dividingline.Border();
                    Thread.Sleep(5000);
                    guessedCorrectly = true;
                }
            }
            else
            {
                Console.Clear();
                dividingline.Border();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe, Bitte gib eine ganze Zahl ein.\n");
                Console.ResetColor();
                dividingline.Border();
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
        loading_Main_Page_Message.LoadingMainPageMessage();
        main_Page.MainPage();
    }

    public void GuessNumberHard()
    {
        Dividingline dividingline = new Dividingline();
        Loading_Main_Page_Message loading_Main_Page_Message = new Loading_Main_Page_Message();
        Main_Page main_Page = new Main_Page();

        Random random = new Random();
        int numberToGuess = random.Next(0, 101);
        int attempts = 0;
        bool guessedCorrectly = false;

        Console.Clear();

        while (!guessedCorrectly)
        {
            dividingline.Border();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 ausgewählt. Versuche, sie zu erraten!\n");
            Console.ResetColor();
            Console.Write("Gib deine Vermutung ein: \n\n");
            dividingline.Border();

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int userGuess))
            {
                attempts++;

                if (userGuess < numberToGuess)
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.WriteLine("Die gesuchte Zahl ist höher.\n");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.WriteLine("Die gesuchte Zahl ist niedriger.\n");
                }
                else
                {
                    Console.Clear();
                    dividingline.Border();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Richtig! Du hast die Zahl {numberToGuess} in {attempts} Versuchen erraten.\n");
                    Console.ResetColor();
                    dividingline.Border();
                    Thread.Sleep(5000);
                    guessedCorrectly = true;
                }
            }
            else
            {
                Console.Clear();
                dividingline.Border();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe, Bitte gib eine ganze Zahl ein.\n");
                Console.ResetColor();
                dividingline.Border();
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
        loading_Main_Page_Message.LoadingMainPageMessage();
        main_Page.MainPage();
    }
}