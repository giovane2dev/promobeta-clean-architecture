using System.Collections.Generic;
using System.Threading.Tasks;
using PromoBeta.Domain.Entities;

namespace PromoBeta.Domain.Interfaces
{
    public interface ICategoryRepository
    {       
        Task<Category> CreateAsync(Category category);

        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetByIdAsync(int? id);

        Task<Category> UpdateAsync(Category category);
        Task<Category> DeleteAsync(Category category);
    }
}