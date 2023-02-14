using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsBotDbProvider.ModelsDb
{
    public class ChatTask
    {
        [Key]
        public long IdTask { get; set; }

        public long IdChat { get; set; }
        public TypeTask Type { get; set; }
        public string Value { get; set; }
      
    }
    
    public enum TypeTask
    {
        STUDENT, TEACHER, CABINET
    }
}
