
using LessonsBotDbProvider.ModelsDb;
using System.Net;
using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace LessonsBotDbProvider.CacheDownloader
{
    public class CacheController
    {

        protected ApplicationContext _ef;

        public CacheController()
            => _ef = new ApplicationContext();

        public void StartMigrate()
        {
            if (!IsNeedMigrate())
                return;

            var groups = JsonSerializer.Deserialize<List<CachedGroup>>(GetJsonResponse("https://mfc.samgk.ru/api/groups"));
            var teachers = JsonSerializer.Deserialize<List<CachedTeacher>>(GetJsonResponse("https://asu.samgk.ru/api/teachers"));
            var cabs = JsonSerializer.Deserialize<List<string>>(GetJsonResponse("https://asu.samgk.ru/api/cabs"));

            foreach (var item in groups)
            {
                if (_ef.CachedGroups.Any(x => x.name == item.name))
                    continue;
                _ef.Add(item);                   
            }

            foreach (var item in teachers)
            {
                if (_ef.CachedTeachers.Any(x => x.name == item.name))
                    continue;
                _ef.Add(item);
            }

            //foreach (var item in cabs)
            //{
            //    if (_ef.CachedCabs.Any(x => x.Value == item))
            //        continue;
            //    _ef.Add(item);
            //}

            _ef.SaveChanges();
        }

        protected bool IsNeedMigrate()
        {
            if (_ef.CachedCabs.ToList().Count <= 10)
                return true;

            if (_ef.CachedGroups.ToList().Count <= 10)
                return true;

            if (_ef.CachedTeachers.ToList().Count <= 10)
                return true;

            return false;
        }

        protected string GetJsonResponse(string url)
        {
            using (var wb = new WebClient())
            {
                wb.Headers.Set("Accept", "application/json");
                wb.Headers.Set("origin", "http://samgk.ru");
                wb.Headers.Set("Referer", "samgk.ru");
                return wb.DownloadString(url);
            }
        }

    }
}
