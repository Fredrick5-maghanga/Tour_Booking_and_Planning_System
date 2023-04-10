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
                        var Users = new User[]
                        {
                            new User{ userName="FredMaghanga", firstName= "Fred", lastName="Maghanga", city="Nairobi", currentAddress="PO BOX 111, Nairobi", permanentAddress="111 Nairobi"}

                        };
                        context.Users.AddRange(Users);

                        //foreach (User s in Users)
                        //{
                        //    context.Userss.Add(s);
                        //}
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}

