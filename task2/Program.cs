internal class Program
{

    private static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Введите кол-во элементов массива");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Введите целое число");
        }

        int[] array = CreateRandomArray(n, random);
        PrintArray(array);
        Array.Reverse(array);
        PrintArray(array);

    }

    private static int[] CreateRandomArray(int n, Random random)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next();
        }
        return array;
    }

    private static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine();
    }
}