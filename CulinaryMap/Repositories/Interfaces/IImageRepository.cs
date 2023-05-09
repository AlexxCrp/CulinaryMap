using CulinaryMap.Entities;

namespace CulinaryMap.Repositories.Interfaces
{
    public interface IImageRepository
    {
        IQueryable<Image> GetImages();
    }
}
