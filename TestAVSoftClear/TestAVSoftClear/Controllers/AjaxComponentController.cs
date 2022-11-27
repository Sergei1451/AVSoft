using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Text.Json.Serialization;
using TestAVSoftClear.Models;
using System.Text.Json;

namespace TestAVSoftClear.Controllers
{
    //Контроллер страницы вывода и заполнения таблицы №1 посредством ajax-запроса(Пункт №4 ТЗ)
    public class AjaxComponentController : Controller
    {
        private ApplicationContext _context;
        public AjaxComponentController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //Get-запрос, возваращающий готовую html-разметку с данными таблицы №1 на страницу Razor-View
        [HttpGet]
        public string GetTable()
        {
            string variable = "<tr><th>ID</th><th>KEY</th><th>VALUE</th></tr>";
            foreach (var counter in _context.Counters)
            {
                variable += $"<tr><td>{counter.ID}</td><td>{counter.KEY}</td><td>{counter.VALUE}</td></tr>";
            }
            return variable;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //Метод добавления записи в таблицу №1
        public  ActionResult AddData(Counters counter)
        {
            _context.Counters.Add(counter);
            _context.SaveChanges();
            return View();
        }
    }
}
