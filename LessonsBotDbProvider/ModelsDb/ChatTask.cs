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
        /// Значение 
        /// </summary>
        public string Value { get; set; }
    }
    

    /// <summary>
    /// ПЕРЕЧИСЛЕНИЕ ТИПА ЗАДАЧ
    /// </summary>
    public enum TypeTask
    {
        STUDENT, TEACHER, CABINET
    }
}
