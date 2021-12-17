using System.Runtime.Serialization;

namespace SkillsTrack.Core.Models
{
    public enum Category
    {
        [EnumMember(Value = ".NET")]
        NET,

        [EnumMember(Value = "Javascript")]
        JAVASCRIPT,

        [EnumMember(Value = "Git")]
        GIT,

        [EnumMember(Value = "Html")]
        HTML
    }
}
