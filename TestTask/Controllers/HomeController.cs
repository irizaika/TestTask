using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new CalendarMonth
            {
                Year = 2026,
                Month = 6,
                Currency = CurrencyCodes.USD,

                Days =
                [
                    new() { Date = "2026-06-01", Positions = 2, Pnl = 120, PNLPercent = 1.2 },
                    new() { Date = "2026-06-02", Positions = 0, Pnl = 0, PNLPercent = 0 },
                    new() { Date = "2026-06-03", Positions = 1, Pnl = -50, PNLPercent = -0.5 },
                    new() { Date = "2026-06-04", Positions = 3, Pnl = 300, PNLPercent = 2.1 },
                    new() { Date = "2026-06-05", Positions = 2, Pnl = 80, PNLPercent = 0.8 },
                    new() { Date = "2026-06-07", Positions = 4, Pnl = -200, PNLPercent = -1.5 },
                    new() { Date = "2026-06-08", Positions = 1, Pnl = 40, PNLPercent = 0.3 },
                    new() { Date = "2026-06-09", Positions = 0, Pnl = 0, PNLPercent = 0 },
                    new() { Date = "2026-06-10", Positions = 2, Pnl = 150, PNLPercent = 1.1 },
                    new() { Date = "2026-06-15", Positions = 1, Pnl = 4, PNLPercent = 0.35 },
                    new() { Date = "2026-06-16", Positions = 0, Pnl = 0, PNLPercent = 0 },
                        new() { Date = "2026-06-17", Positions = 2, Pnl = 10, PNLPercent = 33 },
                        new() { Date = "2026-06-22", Positions = 1, Pnl = 4, PNLPercent = 0.35 },
                        new() { Date = "2026-06-23", Positions = 0, Pnl = 0, PNLPercent = 0 },
                        new() { Date = "2026-06-24", Positions = 2, Pnl = 10, PNLPercent = 33 },
                        new() { Date = "2026-06-28", Positions = 0},
                        new() { Date = "2026-06-29", Positions = 1, Pnl = 4, PNLPercent = 0.35 },
                        new() { Date = "2026-06-30", Positions = 0, Pnl = 0, PNLPercent = 0 }
                ]

            };

            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
