using System;
using MainPage;

namespace MultiplechoiseQuiz;

public class Questions_General_Knowledge
{
    public void QuestionsGeneralKnowledge()
    {
        Main_Page main_Page = new Main_Page();
        Navbar navbar = new Navbar();
        Loading_Main_Page_Message main_Page_Message = new Loading_Main_Page_Message();
        Error_Message error_Message = new Error_Message();
        Dividingline dividingline = new Dividingline();

        List<IQuestion> questions = new List<IQuestion>
        {
            new Class_QuestionsHistory("Welcher Planet ist der vierte in unserem Sonnensystem?\n",
                new List<string>{"1. Mars", "2. Venus", "3. Jupiter", "4. Saturn"}, "1"),

            new Class_QuestionsHistory("Wer schrieb das Buch \"Der kleine Prinz\"?\n",
                new List<string>{ "1. Antoine de Saint-Exupéry", "2. Leo Tolstoi", "3. Mark Twain", "4. F. Scott Fitzgerald"}, "1"),

            new Class_QuestionsHistory("Welches Element hat die chemische Abkürzung 'O'?\n",
                new List<string>{ "1. Sauerstoff", "2. Silber", "3. Eisen", "4. Gold"}, "1"),

            new Class_QuestionsHistory("Wann endete der Zweite Weltkrieg?\n",
                new List<string>{ "1. 1945", "2. 1939", "3. 1941", "4. 1955\n"}, "1"),

            new Class_QuestionsHistory("Was ist die Hauptstadt von Japan?\n",
                new List<string>{"1. Peking", "2. Seoul", "3. Tokio", "4. Bangkok"}, "3"),

            new Class_QuestionsHistory("Wer malte die Mona Lisa?\n",
                new List<string>{ "1. Vincent van Gogh", "2. Pablo Picasso", "3. Michelangelo", "4. Leonardo da Vinci\n"}, "4"),

            new Class_QuestionsHistory("Welche berühmte Rede hielt Martin Luther King Jr. am 28. August 1963?\n",
                new List<string>{ "1. \"We Shall Overcome\"", "2. \"The Gettysburg Address\"", "3. \"I Have a Dream\"", "4. \"Give me Liberty or give me Death\""}, "3"),

            new Class_QuestionsHistory("Welcher Fluss fließt durch Rom?\n",
                new List<string>{"1. Tiber", "2. Seine", "3. Donau", "4. Rhein"}, "1"),

            new Class_QuestionsHistory("Welches Element hat die chemische Abkürzung 'Na'?\n",
                new List<string>{ "1. Natrium", "2. Neon", "3. Nickel", "4. Kalzium"}, "1"),

            new Class_QuestionsHistory("Wer schrieb das Drama \"Romeo und Julia\"?\n",
                new List<string>{ "1. William Shakespeare", "2. Charles Dickens", "3. Jane Austen", "4. George Orwell"}, "1"),
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