using CulinaryMap.Entities;

namespace CulinaryMap.Repositories.Interfaces
{
    public interface IRegionRepository
    {
        IQueryable<Region> GetRegions();
    }
}
