using MainPage;

namespace GuessNumber;

public class Guess_Number_FirstPage
{
    public void GuessNumberFirstPage()
    {
        Dividingline dividingline = new Dividingline();
        Choose_Difficulty choose_Difficulty = new Choose_Difficulty();

        Console.Clear();
        dividingline.Border();
        choose_Difficulty.ChooseDifficulty();
    }
}