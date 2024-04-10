namespace MainPage;

public class Loading_Main_Page_Message
{
    public void LoadingMainPageMessage()
    {
        Dividingline dividingline = new Dividingline();

        Console.Clear();

        dividingline.Border();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hauptseite wird geladen...\n");
        Console.ResetColor();

        dividingline.Border();
        Thread.Sleep(500);
        Console.Clear();
    }
}