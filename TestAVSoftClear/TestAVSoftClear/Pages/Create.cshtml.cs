using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAVSoftClear.Models;

namespace TestAVSoftClear.Pages
{
    //Страница добавления записи в таблицу №1 (Пункт №3 ТЗ)
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        DataProvider _dp;

        [BindProperty]
        public Counters CountersVariable { get; set; } = new();
        public CreateModel(DataProvider dp)
        {
            _dp = dp;
        }
        //Метод добавления записи в таблицу №1, использующий реализованный класс DataProvider
        public IActionResult OnPostAsync()
        {
            _dp.AddData(CountersVariable);
            return RedirectToPage("Create");
        }
    }
}
