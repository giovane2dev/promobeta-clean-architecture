using System.Collections.Generic;
using System.Threading.Tasks;
using PromoBeta.Application.DTOs;

namespace PromoBeta.Application.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductDTO product);

        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int? id);

        Task UpdateAsync(ProductDTO product);
        Task DeleteAsync(ProductDTO product);
    }
}