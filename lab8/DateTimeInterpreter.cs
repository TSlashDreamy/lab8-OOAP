using lab8.Interfaces;

namespace lab8;

class DateTimeInterpreter
{
    public class YYYYMMDDInterpreter : IDateTimeConvertable
    {
        public DateTime Interpret(string date)
        {
            return DateTime.ParseExact(date, "yyyy-MM-dd", null);
        }
    }

    public class MMDDYYYYInterpreter : IDateTimeConvertable
    {
        public DateTime Interpret(string date)
        {
            return DateTime.ParseExact(date, "MM-dd-yyyy", null);
        }
    }

    public class DDMMYYYYInterpreter : IDateTimeConvertable
    {
        public DateTime Interpret(string date)
        {
            return DateTime.ParseExact(date, "dd-MM-yyyy", null);
        }
    }
}
