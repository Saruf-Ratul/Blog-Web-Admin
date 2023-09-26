using CodePulseAPI.Models.Domain;

namespace CodePulseAPI.Repositories.Interface
{
    public interface ICatagoryRepository
    {
        Task<Catagory> CreateAsync(Catagory catagory);
    }
}
