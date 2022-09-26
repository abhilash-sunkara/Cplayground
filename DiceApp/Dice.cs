namespace DiceApp;

public class Dice
{
    private Random rnd = new Random();
    private int sides;
    private int? facingUp = null; 
    
    public Dice(int s)
    {
        sides = s;
    }

    private void Roll()
    {
        facingUp = rnd.Next(1, sides + 1);
    }

    public int getUp()
    {
        Roll();
        return (int)facingUp;
    }
}