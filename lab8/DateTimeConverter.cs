using lab8.Enums;
using lab8.Interfaces;
using static lab8.DateTimeInterpreter;

namespace lab8;

class DateTimeConverter
{

    public static void ConvertDate(string input, DateMods mode)
    {
        IDateTimeConvertable interpreter;

        switch (mode)
        {
            case DateMods.YYYYMMDD:
                interpreter = new YYYYMMDDInterpreter();
                break;
            case DateMods.MMDDYYYY:
                interpreter = new MMDDYYYYInterpreter();
                break;
            case DateMods.DDMMYYYY:
                interpreter = new DDMMYYYYInterpreter();
                break;
            default:
                UI.DisplayErrorMessage("Invalid mode!");
                return;
        }

        try
        {
            DateTime date = interpreter.Interpret(input);
            DisplayInterpretedDate(date);
        }
        catch (FormatException ex)
        {
            UI.DisplayErrorMessage(ex.Message);
        }
    }

    private static void DisplayInterpretedDate(DateTime date)
    {
        UI.DisplayInterpretedDate(date);
    }
}
