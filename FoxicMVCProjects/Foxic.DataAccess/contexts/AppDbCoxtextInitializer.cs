using Foxic.Core.Entities;
using Foxic.Core.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Foxic.DataAccess.contexts;
//USER CREATE ELEMEK MANEGER;
public class AppDbCoxtextInitializer
{
    private readonly AppDbContext _context; // MIGRATION INIT ELEMEK UCUN
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IConfiguration _configuration; //JSON format oxumag ucun

    public AppDbCoxtextInitializer(RoleManager<IdentityRole> roleManager,
                                   UserManager<AppUser> userManager,
                                   AppDbContext context,
                                   IConfiguration configuration)
    {
        _roleManager = roleManager;
        _userManager = userManager;
        _context = context;
        _configuration = configuration;
    }

    public async Task Initialize()
    {
        await _context.Database.MigrateAsync();
    }

    public async Task CreateRole()     //Role Create Elemek
    {
        foreach (var role in Enum.GetValues(typeof(Roles)))
        {
            if (!await _roleManager.RoleExistsAsync(role.ToString()))
            {
                await _roleManager.CreateAsync(new() { Name = role.ToString() }); //Enuma new type-data elave etmek
            }
        }

    }
    public async Task CreateAdmin()
    {
        AppUser superadmin = new()
        {
            Fullname="admin",
            UserName = _configuration["SuperAdmin:Username"],
            Email = _configuration["SuperAdmin:Email"]
        };
        await _userManager.CreateAsync(superadmin, "Izzat123@"); // password hash elemek
        await _userManager.AddToRoleAsync(superadmin, Roles.SuperAdmin.ToString());
    }
}
