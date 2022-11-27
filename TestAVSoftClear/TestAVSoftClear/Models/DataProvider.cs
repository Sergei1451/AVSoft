namespace TestAVSoftClear.Models
{
    //Класс DataProvaider(Пункт №2 ТЗ)
    public class DataProvider
    {
        public ApplicationContext _context;
        public DataProvider(ApplicationContext context)
        {
            _context = context;
        }
        //Запрос данных без преобразования из таблицы №1 в IQueryable(Пункт №2 ТЗ)
        public IQueryable<Counters> GetData()
        {
            IQueryable<Counters> counters = _context.Counters.OrderBy(p => p.ID);
            return counters;
        }
        //Добавление новой записи в таблицу №1(Пункт №2 ТЗ)
        public void AddData(Counters counter)
        {
            _context.Counters.Add(counter);
            _context.SaveChangesAsync();
        }
        //Запрос, возвращающий количество записей по столбцу Key и счетчик значений больше единицы(Таблица №2)(Пункт №2 ТЗ)
        public IQueryable StatisticsTable()
        {
            var Statistics = _context.Counters.GroupBy(x => x.KEY, y => y.VALUE).Select(s => new
            {
                s.Key,
                Count = s.Count(),
                CountMoreOne = s.Count(x => x > 1)
            });
            return Statistics;
        }
    }
}
