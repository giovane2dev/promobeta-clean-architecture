using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PromoBeta.Domain.Entities;
using PromoBeta.Domain.Interfaces;
using PromoBeta.Infra.Data.Context;

namespace PromoBeta.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext categoryContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            categoryContext = applicationDbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            categoryContext.Add(category);
            await categoryContext.SaveChangesAsync();

            return category;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await categoryContext.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int? id)
        {
            return await categoryContext.Categories.FindAsync(id);
        }        

        public async Task<Category> UpdateAsync(Category category)
        {
            categoryContext.Update(category);
            await categoryContext.SaveChangesAsync();

            return category;
        }

        public async Task<Category> DeleteAsync(Category category)
        {
            categoryContext.Remove(category);
            await categoryContext.SaveChangesAsync();

            return category;
        }
    }
}