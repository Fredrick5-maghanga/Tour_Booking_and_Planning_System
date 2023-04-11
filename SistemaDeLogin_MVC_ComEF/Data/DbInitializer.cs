using ClassicTours.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassicTours.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            {
                using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
                {
                    context.Database.EnsureCreated();
                    // Look for any User.
                    if (context.Users.Any())
                    {
                        return;
                        // DB has been seeded
                    }
                    else
                    {
                        var users = new User { UserName = "FredMaghanga", firstName = "Fred", lastName = "Maghanga", city = "Nairobi", currentAddress = "PO BOX 111, Nairobi", permanentAddress = "111 Nairobi" };
                        context.Users.Add(users);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}

