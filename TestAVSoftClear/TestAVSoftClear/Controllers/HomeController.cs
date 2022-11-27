using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestAVSoftClear.Models;

namespace TestAVSoftClear.Controllers
{
    //Контроллер страницы вывода таблицы №2(Пункт №4 ТЗ)
    public class HomeController : Controller
    {
        DataProvider _dp;
        public HomeController(DataProvider dp)
        {
            _dp = dp;
        }
        //Метод вывода таблицы №2, использующий реализованный класс DataProvider
        [HttpGet]
        public IActionResult Index()
        {
            var variable = _dp.StatisticsTable();
            return View(variable);
        }
    }
}