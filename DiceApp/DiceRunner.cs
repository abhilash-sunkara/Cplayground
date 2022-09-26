namespace DiceApp;

public class DiceRunner
{
    private static Dice d = new Dice(6);
    
    
    static void Main()
    {
        if (d.getWin())
        {
            print(d.getRawWin());
            Console.WriteLine("Player One Wins with even numbers");
        }
        else
        {
            print(d.getRawWin());
            Console.WriteLine("Player Two Wins with odd numbers");
        }

    }

    public static void print(String s)
    {
        Console.WriteLine(s);
    }
    
    public static void print(int i)
    {
        Console.WriteLine(i);
    }
    
    public static void print(bool b)
    {
        Console.WriteLine(b);
    }
}


