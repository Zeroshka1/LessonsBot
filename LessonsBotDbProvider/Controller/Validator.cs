using LessonsBotDbProvider.ModelsDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsBotDbProvider.Controller
{
    internal class Validator
    {

        public static bool IsValidBot(Bot bot)
        {
            if (string.IsNullOrEmpty(bot.Token))
                return false;

            if (bot.Timer <= 1000)
                return false;

            return true;
        }

        public static bool IsValidChatTask(ChatTask task)
        {
            if (task.Type == null)
                return false;

            return true;
        }

    }
}
