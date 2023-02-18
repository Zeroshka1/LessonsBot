using LessonsBotDbProvider.ModelsDb;
using LessonsBotDbProvider.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsBotDbProvider.Controller
{
    public class Controller
    {
        protected ApplicationContext _ef;

        public Controller()
            => _ef = new ApplicationContext();

        
        /// <summary>
        /// Активация нового бота по токену
        /// </summary>
        /// <param name="token">Токен</param>
        /// <param name="timer">Время интервала перед запросами на расписание</param>
        /// <returns></returns>
        public ActionResult BotNewCreate(string token, int timer)
        {
            Bot bot = new Bot()
            {
                Token = token,
                Timer = timer
            };

            if (!Validator.IsValidBot(bot))
                return new ActionResult(ActionCodeResult.ERROR, "Бот не прошел валидацию");

            _ef.Add(bot);
            _ef.SaveChanges();

            return new ActionResult(ActionCodeResult.OK, null);
        }

        public ActionResult BotDelete(string guid_or_token)
        {
            var result = _ef.Bots
                .FirstOrDefault(x =>
                x.IdBot.ToString() == guid_or_token ||
                x.Token == guid_or_token);

            if (result == null)
                return new ActionResult(ActionCodeResult.ERROR, "Элемент не удален");

            _ef.Remove(result);
            _ef.SaveChanges();
            return new ActionResult(ActionCodeResult.OK, null);
        }

        public ActionResult ChatTaskAdd(string guid, ChatTask task) 
        {
            var result = _ef.Bots
                .FirstOrDefault(x =>
                x.IdBot.ToString() == guid);

            if (result == null)
                return new ActionResult(ActionCodeResult.ERROR, "Такой бот не найден");

            if (!Validator.IsValidChatTask(task))
                return new ActionResult(ActionCodeResult.ERROR, "Такс не прошел валидацию");

            result.ChatTasks.Add(task);
            _ef.Update(result);
            _ef.SaveChanges();

            return new ActionResult(ActionCodeResult.OK, null);
        }

        public ActionResult ChatTaskDeleteAllForChat(string guid, long id_chat)
        {
            var result = _ef.Bots
                .FirstOrDefault(x =>
                x.IdBot.ToString() == guid);

            if (result == null)
                return new ActionResult(ActionCodeResult.ERROR, "Такой бот не найден");

            foreach (var item in result.ChatTasks)
            {
                if (item.IdChat == id_chat)
                    _ef.Remove(item);
            }

            _ef.SaveChanges();

            return new ActionResult(ActionCodeResult.OK, null);
        }

    }
}
