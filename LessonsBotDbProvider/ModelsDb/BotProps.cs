using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsBotDbProvider.ModelsDb
{
    public class BotProps
    {
        [Key]
        public long IdBot { get; set; }

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

        /// <summary>
        /// Таймер между чатами
        /// </summary>
        public int TimerChat { get; set; }

    }
}
