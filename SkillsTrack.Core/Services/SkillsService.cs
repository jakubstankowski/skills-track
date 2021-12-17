﻿using SkillsTrack.Core.Interfaces;
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
            new Skills() { Category = Category.NET, Description = "Blazor basic architecture", Date = new System.DateTime(2021, 12, 17) }
        };

        public IEnumerable<Skills> GetAllSkills()
        {
            return skills;
        }
    }
}
