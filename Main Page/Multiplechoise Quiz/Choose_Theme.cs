using MainPage;

namespace MultiplechoiseQuiz;

public class Choose_Theme
{
    public void ChooseTheme()
    {
        Questions_History questions_History = new Questions_History();
        Questions_General_Knowledge questions_General_Knowledge = new Questions_General_Knowledge();
        Dividingline dividingline = new Dividingline();
        Navbar navbar = new Navbar();
        Questions_Math questions_Math = new Questions_Math();

        List<string> ChooseTheme = new List<string>();

        ChooseTheme.Add("Thema wählen:\n");
        ChooseTheme.Add("1. Geschichte");
        ChooseTheme.Add("2. Allgemein Wissen");
        ChooseTheme.Add("3. Mathematik\n");

        // Konsolen Ausgabe Anfang
        dividingline.Border();

        foreach (string theme in ChooseTheme)
        {
            Console.WriteLine(theme);
        }
        dividingline.Border();
        // Konsolen Ausgabe Ende

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Clear();
                questions_History.QuestionsHistory();
                break;

            case "2":
                Console.Clear();
                questions_General_Knowledge.QuestionsGeneralKnowledge();
                break;

            case "3":
                Console.Clear();
                questions_Math.QuestionsMath();
                break;
        }
    }
}