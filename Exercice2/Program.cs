
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        var numeroIf = int.Parse(Console.ReadLine());

        if (numeroIf > 0)
        {
            Console.WriteLine($"The number {numeroIf} is positive");
        }
        else if (numeroIf < 0)
        {
            Console.WriteLine($"The number {numeroIf} is negative");
        }
        else
        {
            Console.WriteLine($"The number is zero");
        }

        Console.WriteLine("\n" + "Please enter a number: ");
        var numeroWhile = int.Parse(Console.ReadLine());

        while (numeroWhile < 3)
        {
            numeroWhile++;
            Console.WriteLine(numeroWhile);
        }

        Console.WriteLine("\n" + "Do While");
        var numeroDoWhile = 3;
        do
        {
            numeroWhile++;
            Console.WriteLine(numeroWhile);
        } while (numeroDoWhile != 3);

        Console.WriteLine("\n" + "For");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n" + "Please enter a season");
        var season = Console.ReadLine().ToLower();
        switch (season)
        {
            case "spring":
            case "summer":
            case "autumn":
            case "winter":
                enterSeason(season);
                break;
            default:
                Console.WriteLine($"{season} is not a valid season");
                break;
        }

        void enterSeason(string season) => Console.WriteLine($"The season is {season}");
    }
}