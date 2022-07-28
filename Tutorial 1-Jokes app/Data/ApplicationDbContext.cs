using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tutorial_1_Jokes_app.Models;

namespace Tutorial_1_Jokes_app.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tutorial_1_Jokes_app.Models.Joke>? Joke { get; set; }
    }
}