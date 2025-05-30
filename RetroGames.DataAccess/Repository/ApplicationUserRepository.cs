﻿using RetroGames.DataAccess.Repository.IRepository;
using RetroGames.DataAccess.Data;
using RetroGames.Models;


namespace RetroGames.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ApplicationUser applicationUser) {
            _db.ApplicationUsers.Update(applicationUser);
        }
    }
}
