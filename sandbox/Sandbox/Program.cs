class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes Program!");

        Rectangle rect = new Rectangle();
        rect.Display();

        rect.SetWidth(100);
        rect.SetHeight(200);
        rect.Display();

    }
}