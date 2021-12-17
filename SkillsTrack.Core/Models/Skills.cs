using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTrack.Core.Models
{
    public class Skills
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Category { get; set; }

        public string Description { get; set; }

    }
}
