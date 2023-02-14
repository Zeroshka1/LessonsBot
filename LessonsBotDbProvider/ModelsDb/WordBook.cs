using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsBotDbProvider.ModelsDb
{
    public class WordBook
    {
        public List<string> Questions { get; set; }
        public List<string> Answers { get; set; }
        public List<string> Banned { get; set; }
    }
}
