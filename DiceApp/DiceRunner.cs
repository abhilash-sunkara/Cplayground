namespace DiceApp;

public class DiceRunner
{
    private static Dice d = new Dice(6);
    
    static void Main()
    {
        Console.WriteLine("Your number is " + d.getUp());


    }
}

