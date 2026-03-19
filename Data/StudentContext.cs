using Microsoft.EntityFrameworkCore;
using studentAPI.Models;

namespace studentAPI.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } // Table name: Students
    }
}