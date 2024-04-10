namespace MainPage;

public class Navbar
{
    public void Navigation()
    {
        Loading_Main_Page_Message main_Page_Message = new Loading_Main_Page_Message();
        Dividingline dividingline = new Dividingline();
        Error_Message error_Message = new Error_Message();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Um in das Hauptmenü zu kommen drücken Sie \"M\"");
            Console.ResetColor();

            string? userInput = Console.ReadLine();

            if (userInput != null)
            {
                userInput = userInput.ToLower();

                if (userInput == "m")
                {
                    Console.Clear();
                    main_Page_Message.LoadingMainPageMessage();
                    break;
                }

                if (userInput != "m")
                {
                    error_Message.ErrorMessage();
                    Thread.Sleep(1500);
                }
            }
            else
            {
                error_Message.ErrorMessage();
            }
        }
    }
}