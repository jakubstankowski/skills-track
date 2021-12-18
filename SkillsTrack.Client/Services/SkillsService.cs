using SkillsTrack.Client.Interfaces;
using SkillsTrack.Core.Models;

namespace SkillsTrack.Client.Services
{
    public class SkillsService : ISkillsService
    {
        public Task<IEnumerable<Skill>> GetSkillsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
