using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAVSoftClear.Models;

namespace TestAVSoftClear.Pages
{
    //�������� ������ ������� �1 (����� �3 ��)
    public class IndexModel : PageModel
    {
        DataProvider _dp;
        public IQueryable<Counters> Counters { get; private set; }
        public IndexModel(DataProvider dp)
        {
            _dp = dp;
        }
        //����� ������ ������� �1, ������������ ������������� ����� DataProvider
        public void OnGet()
        {
            Counters = _dp.GetData();
        }
    }
}
