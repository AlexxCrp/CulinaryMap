using CulinaryMap.Entities;
using CulinaryMap.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CulinaryMap.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly CulinaryMapDbContext dbContext;
        private readonly DbSet<Image> imageEntities;

        public ImageRepository(CulinaryMapDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.imageEntities = dbContext.Images;
        }

        public IQueryable<Image> GetImages()
        {
            return imageEntities.AsQueryable();
        }
    }
}
