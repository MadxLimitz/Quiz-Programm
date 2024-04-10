
namespace MultiplechoiseQuiz;

public class Class_QuestionsMath : IQuestion
{
    public string Question { get; set; }
    public List<string> AwnserOptions { get; set; }
    public string CorrectAwnser { get; set; }

    public Class_QuestionsMath(string question, List<string> answerOptions, string correctAnswer)
    {
        Question = question;
        AwnserOptions = answerOptions;
        CorrectAwnser = correctAnswer;
    }
}
