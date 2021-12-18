using SkillsTrack.Core;
using SkillsTrack.Core.Models;

namespace SkillsTrack.Client.Interfaces
{
    public interface ISkillsService
    {
        Task<IEnumerable<Skill>> GetSkillsAsync();
    }
}
