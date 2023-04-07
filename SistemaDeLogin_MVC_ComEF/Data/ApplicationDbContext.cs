using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClassicTours.Models;

namespace ClassicTours.Data
{
    //
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object Reservations;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
    }
}
