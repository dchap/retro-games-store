using RetroGames.DataAccess.Repository.IRepository;
using RetroGames.DataAccess.Data;
using RetroGames.Models;


namespace RetroGames.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository 
        {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
