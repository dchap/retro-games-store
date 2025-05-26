using RetroGames.DataAccess.Repository.IRepository;
using RetroGames.DataAccess.Data;
using RetroGames.Models;

namespace RetroGames.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
