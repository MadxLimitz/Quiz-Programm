using System;
using MainPage;

namespace MultiplechoiseQuiz;

public class Questions_History
{
    public void QuestionsHistory()
    {
        Main_Page main_Page = new Main_Page();
        Navbar navbar = new Navbar();
        Loading_Main_Page_Message main_Page_Message = new Loading_Main_Page_Message();
        Error_Message error_Message = new Error_Message();
        Dividingline dividingline = new Dividingline();

        List<IQuestion> questions = new List<IQuestion>
        {
            new Class_QuestionsHistory("Wann begann der Zweite Weltkrieg?\n",
                new List<string>{"1. 1936", "2. 1939", "3. 1942", "4. 1945"}, "2"),

            new Class_QuestionsHistory("Welches Land griff Polen an und löste damit den Zweiten Weltkrieg aus?\n",
                new List<string>{"1. Deutschland", "2. Japan", "3. Italien", "4. Sovjetunion"}, "1"),
            
            new Class_QuestionsHistory("Welches Ereignis führte zur Beteiligung der USA am Zweiten Weltkrieg?\n",
                new List<string>{ "1. Angriff auf Pearl Harbor", "2. Schlacht um Stalingrad", "3. D-Day", "4. Bombardierung von London"}, "1"),

            new Class_QuestionsHistory("Welche Länder bildeten die Alliierten im Zweiten Weltkrieg?\n",
                new List<string>{ "1. Deutschland, Japan, Italien", "2. USA, Großbritannien, Sowjetunion", "3. Deutschland, Frankreich, Italien", "4. Japan, Sowjetunion, China\n"}, "2"),

            new Class_QuestionsHistory("Wann endete der Zweite Weltkrieg in Europa?\n",
                new List<string>{"1. 1943", "2. 1945", "3. 1947", "4. 1950"}, "2"),

            new Class_QuestionsHistory("Was war die Operation Overlord?\n",
                new List<string>{ "1. Die Landung der Alliierten in der Normandie", "2. Die Bombardierung von London", "3. Die Schlacht um Stalingrad", "4. Der Angriff auf Pearl Harbor\n"}, "1"),

            new Class_QuestionsHistory("Welche Stadt war das Ziel der ersten Atombombe im Zweiten Weltkrieg?\n",
                new List<string>{ "1. Tokio", "2. Berlin", "3. Hiroshima", "4. Rom"}, "3"),

            new Class_QuestionsHistory("Welches Land kapitulierte zuerst im Zweiten Weltkrieg?\n",
                new List<string>{"1. Deutschland", "2. Japan", "3. Italien", "4. Sovjetunion"}, "3"),

            new Class_QuestionsHistory("Wer war der Führer der Sowjetunion während des Zweiten Weltkriegs?\n",
                new List<string>{ "1. Joseph Stalin", "2. Vladimir Lenin", "3. Nikita Chruschtschow", "4. Mikhail Gorbatschow"}, "1"),

            new Class_QuestionsHistory("Welche Konferenz führte zur Teilung Deutschlands nach dem Zweiten Weltkrieg?\n",
                new List<string>{ "1. Yalta-Konferenz", "2. Teheran-Konferenz", "3. Jalta-Konferenz", "4. Potsdamer Konferenz"}, "4"),
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
        Console.ResetColor(); dividingline.Border();
        Thread.Sleep(2500);
        navbar.Navigation();
        main_Page_Message.LoadingMainPageMessage();
        main_Page.MainPage();
    }
}