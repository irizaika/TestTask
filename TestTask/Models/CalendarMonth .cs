namespace TestTask.Models
{
    public class CalendarMonth
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string Currency { get; set; } = CurrencyCodes.USD;
        public List<CalendarDay> Days { get; set; } = [];
    }
}
