using System.ComponentModel.DataAnnotations;

namespace UniversityAPIBackend.Models.DataModels
{
    public class Course : BaseEntity
    {
        [Required, MaxLength(50)] public string Name { get; set; } = string.Empty;
        [MaxLength(280)] public string ShortDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Level Level { get; set; } = Level.Basic;
        [Required] public ICollection<Category> Categories { get; set; } = new List<Category>();
        [Required] public Chapter Chapter { get; set; } = new Chapter();
        [Required] public ICollection<Student> Students { get; set; } = new List<Student>();
    }

    public enum Level
    {
        Basic,
        Intermediate,
        Advanced,
        Exoert
    }
}
