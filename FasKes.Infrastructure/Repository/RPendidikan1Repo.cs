using AutoMapper;
using FasKes.Domain.Entity.R;
using FasKes.Domain.Repository.R;
using FasKes.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace FasKes.Infrastructure.Repository
{
    public class RPendidikan1Repo : IRPendidikan1Repo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public RPendidikan1Repo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(RPendidikan1 rPendidikan1)
        {
            await _appDbContext.RPendidikan1.AddAsync(rPendidikan1);
            var ret = await _appDbContext.SaveChangesAsync();
            return ret;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _appDbContext.RPendidikan1.Where(c => c.Kode == id).ExecuteDeleteAsync();
        }

        public async Task<List<RPendidikan1>> GetAllAsync()
        {
            return await _appDbContext.RPendidikan1.ToListAsync();
        }

        public async Task<RPendidikan1> GetByIdAsync(int id)
        {
            return await _appDbContext.RPendidikan1.FirstOrDefaultAsync(c => c.Kode == id);
        }

        public async Task<int> UpdateAsync(int id, RPendidikan1 rPendidikan1)
        {
            var row = await _appDbContext.RPendidikan1.FindAsync(id);
            if (row != null)
            {
                _mapper.Map(rPendidikan1, row);
                // row.Kode = rPendidikan1.Kode;
                // row.Uraian = rPendidikan1.Uraian;
                _appDbContext.RPendidikan1.Update(row);
                return await _appDbContext.SaveChangesAsync();
            }
            return 0;
        }
    }
}