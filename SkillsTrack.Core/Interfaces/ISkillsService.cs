using SkillsTrack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTrack.Core.Interfaces
{
    public interface ISkillsService
    {
        public IEnumerable<Skill> GetAllSkills();

    }
}
