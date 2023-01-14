using System.ComponentModel.DataAnnotations;

namespace UniversityAPIBackend.Models.DataModels
{
    public class Course
    {
        [Required, MaxLength(50)] public string Name { get; set; } = string.Empty;
        [MaxLength(280)] public string ShortDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TargetAudiences { get; set; } = string.Empty;
        public string Objectives { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public Level Level { get; set; }
    }

    public enum Level
    {
        Basic,
        Intermediate,
        Advanced
    }
}
