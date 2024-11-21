using FasKes.Domain.Entity.R;

namespace FasKes.Domain.Repository.R
{
    public interface IRPendidikan1Repo
    {
        Task<List<RPendidikan1>> GetAllAsync();
        Task<RPendidikan1> GetByIdAsync(int id);
        Task<int> CreateAsync(RPendidikan1 pendidikan1);
        Task<int> UpdateAsync(int id, RPendidikan1 pendidikan1);
        Task<int> DeleteAsync(int id);
    }
}