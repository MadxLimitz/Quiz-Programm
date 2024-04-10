namespace MainPage;

public class Description_Of_Games
{
    public void DescriptionOfGames()
    {
        Loading_Main_Page_Message main_Page_Message = new Loading_Main_Page_Message();
        Dividingline dividingline = new Dividingline();
        Navbar navbar = new Navbar();
        Main_Page main_Page = new Main_Page();
        Description_Of_Games description_Of_Games = new Description_Of_Games();

        List<string> DescriptionOfGames = new List<string>();
        
        DescriptionOfGames.Add("1. Multiplechoise Quiz\n");
        DescriptionOfGames.Add("2. Zahlen Raten\n");

        // Konsolen Ausgabe Anfang
        dividingline.Border();

        foreach (string description in DescriptionOfGames)
        {
            Console.WriteLine(description);
        }

        dividingline.Border();
        // Konsolen Ausgabe Ende

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Clear();
                dividingline.Border();

                Console.WriteLine("Beim Multiplechoise Quiz wird dir eine Frage gestellt, du hast vier Antwortmöglichkeiten,\nwähle eine Antwort aus und sehe ob du richtig liegst.\n");
                
                dividingline.Border();
                navbar.Navigation();
                main_Page_Message.LoadingMainPageMessage();
                main_Page.MainPage();
                break;

            case "2":
                Console.Clear();
                dividingline.Border();

                Console.WriteLine("Beim Spiel \"Zahlen Raten\" generiert der Computer eine zufällige Zahl die du erraten musst, \nje nach deiner letzten eingegebenen Zahl wird dir angezeigt ob du über oder unter der gesuchten Zahl bist.\n");

                dividingline.Border();
                navbar.Navigation();
                main_Page_Message.LoadingMainPageMessage();
                main_Page.MainPage();
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falsche Eingabe!");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();

                description_Of_Games.DescriptionOfGames();
                break;
        }
    }
}