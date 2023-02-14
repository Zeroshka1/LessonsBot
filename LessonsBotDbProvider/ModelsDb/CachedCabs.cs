using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsBotDbProvider.ModelsDb
{
    [Keyless]
    public class CachedCabs
    {
       
        public string IdCab { get; set; }
        public string Value { get; set; }
    }
}
