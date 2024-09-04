enum Color
{
    RED, GREEN, BLUE
}

internal class Program
{
    private static void Main(string[] args)
    {
        Color color = Color.BLUE;
        switch (color)
        {
            case Color.RED:
                Console.WriteLine("RED");
                break;
            case Color.GREEN:
                Console.WriteLine("GREEN");
                break;
            case Color.BLUE:
                Console.WriteLine("BLUE");
                break;
            default:
                Console.WriteLine("Unknown color");
                break;

        }
    }
}