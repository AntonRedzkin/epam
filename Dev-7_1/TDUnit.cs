
namespace Dev_7_1
{
    class TDUnit
    {
        public string Format { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public TDUnit(string format, int minValue, int maxValue)
        {
            this.Format = format;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
        }
    }
}
