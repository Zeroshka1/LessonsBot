using System.ComponentModel.DataAnnotations;

namespace LessonsBotDbProvider.ModelsDb
{
    public class WordBook
    {
        [Key]
        public long IdWord { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
