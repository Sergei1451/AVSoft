using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAVSoftClear.Models;

namespace TestAVSoftClear.Pages
{
    //�������� ���������� ������ � ������� �1 (����� �3 ��)
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
        //����� ���������� ������ � ������� �1, ������������ ������������� ����� DataProvider
        public IActionResult OnPostAsync()
        {
            _dp.AddData(CountersVariable);
            return RedirectToPage("Create");
        }
    }
}
