using Microsoft.AspNetCore.Mvc;
using SkillsTrack.Core.Models;

namespace SkillsTrack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {

        readonly List<Skill> skills = new()
        {
            new Skill() { Category = Category.NET, Description = "Blazor basic architecture", Date = new System.DateTime(2021, 12, 17) }
        };

        [HttpGet]
        public IActionResult GetAllSkills()
        {
            return Ok(skills);
        }

    }
}
