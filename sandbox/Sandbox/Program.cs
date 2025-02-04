class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes Program!")

        Rectangle rect = new Rectangle();
        rect.Display();

        rect = new Rectangle(100, 200);
        rect.Display();
    }
}