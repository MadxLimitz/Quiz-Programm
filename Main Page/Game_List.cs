using MultiplechoiseQuiz;
using GuessNumber;

namespace MainPage;

public class Game_List
{
    public void GameList()
    {
        Multiplechoise_Quiz_FirstPage multiplechoise_Quiz = new Multiplechoise_Quiz_FirstPage();
        Dividingline dividingline = new Dividingline();
        Game_List game_List = new Game_List();
        Error_Message error_Message = new Error_Message();
        Guess_Number_FirstPage guess_Number_FirstPage = new Guess_Number_FirstPage();

        List<string> GameList = new List<string>();

        GameList.Add("1. Multiplechoise Quiz\n");
        GameList.Add("2. Zahlen Raten\n");


        // Konsolen Ausgabe Anfang
        dividingline.Border();

        foreach (string game in GameList)
        {
            Console.WriteLine(game);
        }

        dividingline.Border();
        // Konsolen Ausgabe Anfang

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                multiplechoise_Quiz.MultiplechoiseQuiz();
                break;

            case "2":
                guess_Number_FirstPage.GuessNumberFirstPage();
                break;

            default:
                error_Message.ErrorMessage();
                Thread.Sleep(1000);
                Console.Clear();
                game_List.GameList();
                break;
        }
    }
}