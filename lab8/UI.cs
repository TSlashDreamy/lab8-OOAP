using lab8.Enums;

namespace lab8;

class UI
{
    public void Initialize()
    {
        do
        {
            DisplayModes();
            string? modeString = GetConvertMode().Trim().ToLower();
            if (modeString == "exit") break;

            Console.Write("Enter the date in the selected format: ");
            string? date = Console.ReadLine();

            if (Enum.TryParse(modeString, out DateMods mode))
            {
                DateTimeConverter.ConvertDate(date, mode);
            }
            else
            {
                DisplayErrorMessage("Invalid mode!");
            }
        } while (true);

        Console.WriteLine("Exited.");
    }

    public static void DisplayModes()
    {
        Console.WriteLine("Available date formats: (Ex: 26-02-2024)");
        foreach (DateMods mode in Enum.GetValues(typeof(DateMods)))
        {
            Console.WriteLine($"{(int)mode}. {mode}");
        }
        Console.WriteLine($"Type 'exit', to exit from the app.");
    }


    public static string GetConvertMode()
    {
        string? mode;

        do
        {
            Console.Write("Choose option: ");
            mode = Console.ReadLine();
        } while (mode != "1" && mode != "2" && mode != "3" && mode != "exit");

        return mode;
    }


    public static void DisplayInterpretedDate(DateTime date)
    {
        Console.Clear();
        Console.WriteLine($"Interpreted date: {date}\n");
    }


    public static void DisplayErrorMessage(string message)
    {
        Console.Clear();
        Console.WriteLine($"Something went wrong: {message}\n");
    }
}
