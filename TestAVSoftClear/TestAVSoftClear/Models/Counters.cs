using System.ComponentModel.DataAnnotations.Schema;

namespace TestAVSoftClear.Models
{
    //POCO-класс модели(Пункт №1 ТЗ)
    public class Counters
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int KEY { get; set; }
        public int VALUE { get; set; }
    }

}
