using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories.Interfaces;

namespace NZWalks.API.Repositories.Implementation
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext _nzWalksDbContext;

        public RegionRepository(NZWalksDbContext nzWalksDbContext)
        {
            _nzWalksDbContext = nzWalksDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await _nzWalksDbContext.Regions.ToListAsync();
        }
    }
}
