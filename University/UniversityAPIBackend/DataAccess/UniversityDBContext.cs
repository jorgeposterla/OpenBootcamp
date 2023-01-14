using Microsoft.EntityFrameworkCore;
using UniversityAPIBackend.Models.DataModels;

namespace UniversityAPIBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { }

        //Add DbSets (Tables of our database)
        public DbSet<User>? Users { get; set; }
    }
}
