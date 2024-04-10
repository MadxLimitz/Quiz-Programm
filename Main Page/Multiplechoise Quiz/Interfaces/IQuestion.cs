namespace MultiplechoiseQuiz;

public interface IQuestion
{
    string Question { get; }
    List<string> AwnserOptions { get; }
    string CorrectAwnser { get; }
}