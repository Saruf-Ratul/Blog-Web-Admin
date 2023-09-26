using CodePulseAPI.Data;
using CodePulseAPI.Models.Domain;
using CodePulseAPI.Repositories.Interface;

namespace CodePulseAPI.Repositories.Implementation
{
    public class CatagoryRepository : ICatagoryRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CatagoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Catagory> CreateAsync(Catagory catagory)
        {
            await dbContext.Catagorys.AddAsync(catagory);
            await dbContext.SaveChangesAsync();

            return catagory;
        }
    }
}
