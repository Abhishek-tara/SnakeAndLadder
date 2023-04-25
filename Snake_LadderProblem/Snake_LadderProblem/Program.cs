namespace Snake_LadderProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the Snake and Ladder Game");
            SnakeLadder newGame= new SnakeLadder();
            newGame.GameMethod();
        }
    }
}
