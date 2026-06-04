namespace TestTask.Models
{
    public class CalendarDay
    {
        public required string Date { get; set; }
        public int? Positions { get; set; }
        public double? PNLPercent { get; set; }
        public double? Pnl { get; set; }
    }
}
