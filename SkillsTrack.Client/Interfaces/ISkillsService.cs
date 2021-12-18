using SkillsTrack.Core;
using SkillsTrack.Core.Models;

namespace SkillsTrack.Client.Interfaces
{
    public interface ISkillsService
    {
        Task<List<Skill>> GetSkillsAsync();
    }
}
