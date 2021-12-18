using SkillsTrack.Core;
using SkillsTrack.Core.Models;

namespace SkillsTrack.Client.Interfaces
{
    public interface ISkillsService
    {
        List<Skill> Skills { get; set; }

        Task<List<Skill>> GetSkillsAsync();
    }
}
