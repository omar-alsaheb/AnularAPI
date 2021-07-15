using AngularAPI.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Helpers
{
    public static class MyIdentityDataSeed
    {

        public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

        }
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByNameAsync("Omar").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Omar";
                user.Email = "omar@gmail.com";
                user.FirstName = "Omar";
                user.LastName = "Alsaheb";
                user.Country = "Jordan";
                user.CreateDate = DateTime.Now;
                user.PhoneNumber = "0785009091";


                IdentityResult result = userManager.CreateAsync(user, "P@$$0rd").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }
    }
}
