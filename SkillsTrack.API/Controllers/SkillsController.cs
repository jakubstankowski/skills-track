using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillsTrack.Core.Interfaces;

namespace SkillsTrack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillsService _skillsService;

        public SkillsController(ISkillsService skillsService)
        {
            _skillsService = skillsService;
        }

        [HttpGet]
        public IActionResult GetAllSkills()
        {
            var skills = _skillsService.GetAllSkills();

            return Ok(skills);
        }

    }
}
