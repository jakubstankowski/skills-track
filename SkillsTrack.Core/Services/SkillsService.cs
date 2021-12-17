using SkillsTrack.Core.Interfaces;
using SkillsTrack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTrack.Core.Services
{
    public class SkillsService : ISkillsService
    {
        readonly List<Skills> skills = new()
        {
            new Skills() { Category = "C#", Description = "Blazor basic architecture" }
        };

        public IEnumerable<Skills> GetAllSkills()
        {
            return skills;
        }
    }
}
