using LessonsBotDbProvider.ModelsApiSamgk;
using System.ComponentModel.DataAnnotations;

namespace LessonsBotDbProvider.ModelsDb
{
    public class CachedGroup : GroupApi
    {

        [Key]
        public Guid IdGroupGuid { get; set; }
    }
}
