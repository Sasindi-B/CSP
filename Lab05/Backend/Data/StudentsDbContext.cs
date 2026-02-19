using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
