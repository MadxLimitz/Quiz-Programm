namespace MainPage;

public class Creator_Information
{
    public void CreatorInformation()
    {
        Navbar navbar = new Navbar();
        Loading_Main_Page_Message main_Page_Message = new Loading_Main_Page_Message();
        Main_Page main_Page = new Main_Page();
        Dividingline dividingline = new Dividingline();
        Console.Clear();

        List<string> creatorInformation= new List<string>();

        creatorInformation.Add("Name:        Steiner Sebastian\n");
        creatorInformation.Add("Alter:       17 Jahre (Stand 10.04.2024)\n");
        creatorInformation.Add("Wohnort:     Burgenland (Österreich)\n");
        creatorInformation.Add("Hobbys:      Coding, Kraftsport und Reisen\n");
        creatorInformation.Add("Notiz:       Das ist mein Erstes eigenes Ausführliche C# Programm, das ich geschrieben habe.\n");

        // Konsolen Ausgabe Anfang
        dividingline.Border();

        foreach (string creatordata in creatorInformation)
        {
            Console.WriteLine(creatordata);
        }

        dividingline.Border();
        navbar.Navigation();
        main_Page_Message.LoadingMainPageMessage();
        main_Page.MainPage();
        // Konsolen Ausgabe Ende
    }
}