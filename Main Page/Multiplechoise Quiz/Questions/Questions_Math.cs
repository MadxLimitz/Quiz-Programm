using MainPage;

namespace MultiplechoiseQuiz;

public class Questions_Math
{
    public void QuestionsMath()
    {
        Main_Page main_Page = new Main_Page();
        Navbar navbar = new Navbar();
        Loading_Main_Page_Message main_Page_Message = new Loading_Main_Page_Message();
        Error_Message error_Message = new Error_Message();
        Dividingline dividingline = new Dividingline();

        List<IQuestion> questions = new List<IQuestion>
        {
            new Class_QuestionsHistory("Was ist die Wurzel aus 64?\n",
                new List<string>{"1. 6", "2. 8", "3. 4", "4. 10"}, "2"),

            new Class_QuestionsHistory("Welche der folgenden Zahlen ist eine Primzahl?\n",
                new List<string>{"1. 12", "2. 17", "3. 20", "4. 30"}, "2"),

            new Class_QuestionsHistory("Welche der folgenden Gleichungen beschreibt eine lineare Funktion?\n",
                new List<string>{ "1. y = 2x^2 + 3", "2. y = 3x - 5", "3. y = 4/x", "4. y = √x"}, "2"),

            new Class_QuestionsHistory("Wenn ein Dreieck alle Seiten gleicher Länge hat, ist es ein...\n",
                new List<string>{ "1. gleichseitiges Dreieck", "2. rechtwinkliges Dreieck", "3. gleichschenkliges Dreieck", "4. beliebiges Dreieck\n"}, "1"),

            new Class_QuestionsHistory("Wie viele Grad hat ein Kreis?\n",
                new List<string>{ "1. 180°", "2. 90°", "3. 360°", "4. 270°"}, "3"),

            new Class_QuestionsHistory("Welche der folgenden Zahlen ist eine irrationale Zahl?\n",
                new List<string>{ "1. 0,5", "2. 2.5", "3. 3/4", "4. √2\n"}, "4"),

            new Class_QuestionsHistory("Was ist die Fläche eines Rechtecks mit der Länge 6 und der Breite 4?\n",
                new List<string>{ "1. 12", "2. 16", "3. 24", "4. 10"}, "3"),

            new Class_QuestionsHistory("Wenn a = 5 und b = 3, was ist dann a² + b²?\n",
                new List<string>{"1. 14", "2. 25", "3. 34", "4. 64"}, "2"),

            new Class_QuestionsHistory("Welche der folgenden Funktionen ist eine Exponentialfunktion?\n",
                new List<string>{ "1. y = 3x + 2", "2. y = x^2", "3. y = √x", "4. y = 2^x"}, "4"),

            new Class_QuestionsHistory("Wenn ein Viertel einer Pizza 90 Grad entspricht, wie viele Grad entsprechen dann einem ganzen Kreis?\n",
                new List<string>{ "1. 360°", "2. 180°", "3. 270°", "4. 90°"}, "1"),
        };

        Random randomGenerator = new Random();

        questions = questions.OrderBy(frage => randomGenerator.Next()).ToList();

        int totalQuestions = questions.Count;
        int correctAnswers = 0;

        for (int i = 0; i < totalQuestions; i++)
        {
            int currentQuestionNumber = i + 1;

            dividingline.Border();
            Console.WriteLine($"Frage {currentQuestionNumber}/{totalQuestions}:\n\n{questions[i].Question}");

            foreach (var option in questions[i].AwnserOptions)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine();
            dividingline.Border();
            Console.WriteLine();

            string? userAnswer = Console.ReadLine();
            Console.WriteLine();

            if (userAnswer != null)
            {
                userAnswer = userAnswer.Trim().ToLower();

                if (userAnswer == questions[i].CorrectAwnser)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Deine Antwort ist Richtig, mach weiter so!\n");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Console.Clear();
                    correctAnswers++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Deine Antwort ist leider Falsch!\n");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            else
            {
                error_Message.ErrorMessage();
            }
        }

        Console.Clear();
        dividingline.Border();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Du hast {correctAnswers} von {totalQuestions} Fragen richtig beantwortet.\n");
        Console.ResetColor();
        dividingline.Border();
        Thread.Sleep(2500);
        navbar.Navigation();
        main_Page_Message.LoadingMainPageMessage();
        main_Page.MainPage();
    }
}