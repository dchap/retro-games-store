﻿using RetroGames.DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RetroGames.Utility;
using RetroGames.Models;

namespace RetroGames.DataAccess.DbInitializer {
    public class DbInitializer : IDbInitializer {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public DbInitializer(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db) {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }


        public void Initialize() {


            //migrations if they are not applied
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
				{
					_db.Database.Migrate();
				}
			}
            catch(Exception ex)
			{
			}

			//create roles if they are not created
			if (!_roleManager.RoleExistsAsync(SD.Role_Customer).GetAwaiter().GetResult()) {
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Company)).GetAwaiter().GetResult();


                //if roles are not created, then we will create admin user as well
                _userManager.CreateAsync(new ApplicationUser {
                    UserName = "testadmin@gmail.com",
                    Email = "testadmin@gmail.com",
                    Name = "Derek Chapman",
                    PhoneNumber = "1112223333",
                    StreetAddress = "test 123 Ave",
                    State = "IL",
                    PostalCode = "23422",
                    City = "Los Angeles"
                }, "Admin123*").GetAwaiter().GetResult();


                ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "testadmin@gmail.com");
                _userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();
            }

            return;
        }
    }
}
