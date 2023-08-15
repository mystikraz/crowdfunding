using AutoMapper;
using Data;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace CrowdFunding.Endpoints
{
    public class UserEndPoints : BaseEndPoint
    {
        public UserEndPoints()
        {
            url = baseUrl + "users";
        }

        public override void MapEndPoints(WebApplication app)
        {
            app.MapGet(url, Getall).Produces(StatusCodes.Status200OK);
            app.MapPost($"{url}/setup", Setup).Produces(StatusCodes.Status200OK);
        }

        private async Task<IResult> Setup(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            var adminUser = new ApplicationUser { UserName = "admin", Email = "admin@codeheaven.com" };
            var password = "randomText1#";
            var roleName = "Admin";
            var result = await userManager.CreateAsync(adminUser, password);
            if (result.Succeeded)
            {
                var role = await roleManager.FindByNameAsync(roleName);
                if (role is null)
                {
                    await roleManager.CreateAsync(new ApplicationRole { Name = roleName });
                    result= await userManager.AddToRoleAsync(adminUser, roleName);
                }
            }
            return Results.Ok(result);
        }

        private async Task<IResult> Getall(UserManager<ApplicationUser> userManager, ApplicationDbContext applicationDbContext)
        {
            return Results.Ok(await applicationDbContext.Users.ToListAsync());
        }
    }
}
