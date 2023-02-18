using System.ComponentModel.DataAnnotations;

namespace LessonsBotDbProvider.ModelsDb
{
    public class Bot
    {
        [Key]
        public Guid IdBot { get; set; }

        /// <summary>
        /// Токен для авторизации
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Счётчик между сессиями
        /// </summary>
        public int Timer { get; set; }

        /// <summary>
        /// Список подключенных бесед
        /// </summary>
        public List<ChatTask> ChatTasks { get; set; }


        public Bot()
        {
            ChatTasks = new();
        }
    }
}
