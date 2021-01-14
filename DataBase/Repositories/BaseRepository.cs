using Api.Database.Contexts;

namespace Api.Database.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }   
    }
}
