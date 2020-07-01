using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using YearPlanner.Models;

namespace YearPlanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var now = DateTime.UtcNow;
            var year = await GetYearData(now.Year);
            return View(year);
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

        public async Task<Year> GetYearData(int year)
        {
            var uri = $"http://morsley.io:5002/v1/year-details?year={year}";
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(uri))
                {
                    string data = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Year>(data);
                }
            }
        }
    }
}
