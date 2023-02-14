using Microsoft.EntityFrameworkCore;

namespace LessonsBotDbProvider.ModelsDb
{
    [Keyless]
    public class CachedCabs
    {
        public string IdCab { get; set; }
        public string Value { get; set; }
    }
}
