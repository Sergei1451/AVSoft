using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAVSoftClear.Models;

namespace TestAVSoftClear.Pages
{
    //Страница вывода таблицы №1 (Пункт №3 ТЗ)
    public class IndexModel : PageModel
    {
        DataProvider _dp;
        public IQueryable<Counters> Counters { get; private set; }
        public IndexModel(DataProvider dp)
        {
            _dp = dp;
        }
        //Метод вывода таблицы №1, использующий реализованный класс DataProvider
        public void OnGet()
        {
            Counters = _dp.GetData();
        }
    }
}
