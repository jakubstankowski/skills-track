using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTrack.Core.Models
{
    public class Skill
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public Category Category { get; set; } = Category.NET;

        public string Description { get; set; }

        public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;

    }
}
