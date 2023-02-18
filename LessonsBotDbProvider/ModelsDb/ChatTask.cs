using System.ComponentModel.DataAnnotations;

namespace LessonsBotDbProvider.ModelsDb
{

    public class ChatTask
    {
        [Key]
        public Guid IdTask { get; set; }

        /// <summary>
        /// ID Чата по API
        /// </summary>
        public long IdChat { get; set; }

        /// <summary>
        /// Тип задачи
        /// </summary>
        public TypeTask Type { get; set; }

        /// <summary>
        /// Значение для АПИШКИ
        /// </summary>
        public string Value { get; set; }


        public DateTime DateTimeCreateTask { get; set; }

        public ChatTask()
        {
            DateTimeCreateTask = DateTime.Now;
        }
    }
    

    /// <summary>
    /// ПЕРЕЧИСЛЕНИЕ ТИПА ЗАДАЧ
    /// </summary>
    public enum TypeTask
    {
        STUDENT, TEACHER, CABINET
    }
}
