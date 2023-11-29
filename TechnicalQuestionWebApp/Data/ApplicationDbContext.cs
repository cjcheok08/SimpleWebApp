using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechnicalQuestionWebApp.Models;

namespace TechnicalQuestionWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TechnicalQuestionWebApp.Models.Employee> Employee { get; set; } = default!;
        public DbSet<TechnicalQuestionWebApp.Models.Department> Department { get; set; } = default!;
    }
}
