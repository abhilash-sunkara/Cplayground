namespace DiceApp;

public class Dice
{
    private static Random rnd = new Random();
    private static int sides;
    private static int facingUp = 0;
    private bool? numberComp = null;

    public Dice(int s)
    {
        sides = s;
    }

    private static void Roll()
    {
        facingUp = 0;
        facingUp += rnd.Next(1, sides + 1);
    }

    public int getUp()
    {
        Roll();
        return (int)facingUp;
    }

    public int getFU()
    {
        return (int)facingUp;
    }

    private void checkWin()
    {
        int val = getUp() + getUp();
        if (val % 2 == 1)
        {
            numberComp = false;
        }
        else
        {
            numberComp = true;
        }
        Console.WriteLine(val);
    }

    public bool getWin()
    {
        checkWin();
        return (bool)numberComp;
    }

    public bool getRawWin()
    {
        return (bool)numberComp;
    }
}

    


