using Microsoft.EntityFrameworkCore;

namespace ISQ.NET.Models
{
    public class ProfessorModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NNumber { get; set; }
    }

    public class ProfessorDbContext : DbContext
    {
        public DbSet<ProfessorModel> Professors { get; set; }
    }
}