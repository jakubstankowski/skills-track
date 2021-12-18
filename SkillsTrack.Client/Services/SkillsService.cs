using SkillsTrack.Client.Interfaces;
using SkillsTrack.Core.Models;
using System.Net.Http.Json;


namespace SkillsTrack.Client.Services
{
    public class SkillsService : ISkillsService
    {
        private readonly HttpClient _httpClient;

        public SkillsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Skill> Skills { get; set; } = new List<Skill>();

        public async Task<List<Skill>> GetSkillsAsync()
        {
            Skills = await _httpClient.GetFromJsonAsync<List<Skill>>("api/skills");
            return Skills;
        }
    }
}
