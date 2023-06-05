using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class IdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Test",
                    Email = "test@test.com",
                    UserName = "test",
                    Address = new Address
                    {
                        FirstName = "Test",
                        LastName = "User",
                        Street = "111",
                        City = "San Francisco",
                        State = "CA",
                        ZipCode = "94107"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}