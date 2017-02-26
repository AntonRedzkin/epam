
namespace Dev_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeFormatInputer input = new DateTimeFormatInputer();
            NowDateTimeOutputer output = new NowDateTimeOutputer();
            DateTimeFormatSeter set = new DateTimeFormatSeter();
            string nowDateTime = string.Empty;

            set.FormatSeter(input.Input(), out nowDateTime);
            output.Output(nowDateTime);
        }
    }
}
