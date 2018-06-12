using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vai.Data.Models.Authorization;
using Vai.Data.Models;
using Vai.Data.Models.Enums;

namespace Vai.Data
{
    public class DbSeeder
    {
        private readonly DataContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public DbSeeder(DataContext context,
            UserManager<User> userManager,
            RoleManager<Role> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async void Initialize()
        {
            var pendingMigrations = await _context.Database.GetPendingMigrationsAsync();
            if (pendingMigrations.Any())
            {
                await _context.Database.MigrateAsync();
            }
            await AddRoleIfNotExists("staff");
            await AddRoleIfNotExists("user");

            var root = await CreateUserIfNotExists("root", "root1234", new[] { "staff" });
            await AddPersonIfNotExists(root, new Person {
                FirstName = "Vasya",
                LastName = "Pupkin",
                MiddleName = "Andreyevich",
                Gender = Gender.Male,
                UserId = root.Id
            });

            var testUser = await CreateUserIfNotExists("testUser", "test1234", new[] { "user" });
            await AddPersonIfNotExists(testUser, new Person {
                FirstName = "Polikarp",
                LastName = "Pupkin",
                MiddleName = "Sergeevich",
                Gender = Gender.Male,
                UserId = testUser.Id
            });

            var testUser2 = await CreateUserIfNotExists("testUser2", "test1234", new[] { "user" });
            await AddPersonIfNotExists(testUser2, new Person {
                FirstName = "Timofey",
                LastName = "Pupkin",
                MiddleName = "Vladimirovich",
                Gender = Gender.Male,
                UserId = testUser2.Id
            });
        }

        private async Task AddRoleIfNotExists(string roleName)
        {
            if (await _roleManager.RoleExistsAsync(roleName)) return;
            await _roleManager.CreateAsync(new Role { Name = roleName });
        }

        private async Task<User> CreateUserIfNotExists(string name, string password, string[] roles = null)
        {
            var existUser = await _userManager.FindByNameAsync(name);
            if (existUser != null) return existUser;
            await _userManager.CreateAsync(new User { UserName = name }, password);
            var newUser = await _userManager.FindByNameAsync(name);
            if (roles == null) return newUser;
            await _userManager.AddToRolesAsync(newUser, roles);
            return newUser;
        }

        private async Task AddPersonIfNotExists(User user, Person person)
        {
            if (user.PersonId.HasValue) return;
            user.Person = person;
            _context.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
