using LessonsBotDbProvider.ModelsApiSamgk;
using System.ComponentModel.DataAnnotations;

namespace LessonsBotDbProvider.ModelsDb
{
    public class CachedTeacher : TeacherApi
    {

        [Key]
        public Guid IdTeacherGuid { get; set; }
    }
}
