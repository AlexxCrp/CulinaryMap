using CulinaryMap.Entities;
using CulinaryMap.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CulinaryMap.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly CulinaryMapDbContext dbContext;
        private readonly DbSet<Region> regionEntities;

        public RegionRepository(CulinaryMapDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.regionEntities = dbContext.Regions;
        }

        public IQueryable<Region> GetRegions()
        {
            return regionEntities.AsQueryable();
        }
    }
}
