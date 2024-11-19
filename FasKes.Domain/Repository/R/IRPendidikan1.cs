using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FasKes.Domain.Entity.R;

namespace FasKes.Domain.Repository.R
{
    public interface IRPendidikan1
    {
        Task<List<RPendidikan1>> GetAllRPendidikan1Async();
        Task<RPendidikan1> GetRPendidikan1ByIdAsync(int id);
        Task<RPendidikan1> CreateRPendidikan1Async(RPendidikan1 pendidikan1);
        Task<RPendidikan1> UpdateRPendidikan1Async(int id, RPendidikan1 pendidikan1);
        Task<RPendidikan1> DeleteRPendidikan1Async(int id);
    }
}