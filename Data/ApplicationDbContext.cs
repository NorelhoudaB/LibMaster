using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LibMaster.Models;

namespace LibMaster.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LibMaster.Models.Category>? Category { get; set; }
        public DbSet<LibMaster.Models.Library>? Library { get; set; }
        public DbSet<LibMaster.Models.Authors>? Authors { get; set; }
        public DbSet<LibMaster.Models.Books>? Books { get; set; }
    }
}
