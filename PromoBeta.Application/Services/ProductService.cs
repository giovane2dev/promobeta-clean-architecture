using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PromoBeta.Application.DTOs;
using PromoBeta.Application.Interfaces;
using PromoBeta.Domain.Entities;
using PromoBeta.Domain.Interfaces;

namespace PromoBeta.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _imapper;

        public ProductService(IProductRepository productRepository, IMapper imapper)
        {
            _productRepository = productRepository;
            _imapper = imapper;
        }

        public async Task CreateAsync(ProductDTO product)
        {
            var productEntity = _imapper.Map<Product>(product);

            await _productRepository.CreateAsync(productEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            var productsEntity = await _productRepository.GetProductsAsync();

            return _imapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task<ProductDTO> GetByIdAsync(int? id)
        {
            var productsEntity = await _productRepository.GetByIdAsync(id);

            return _imapper.Map<ProductDTO>(productsEntity);
        }

        public async Task UpdateAsync(ProductDTO product)
        {
            var productEntity = _imapper.Map<Product>(product);

            await _productRepository.UpdateAsync(productEntity);
        }

        public async Task DeleteAsync(ProductDTO product)
        {
            var productEntity = _imapper.Map<Product>(product);

            await _productRepository.DeleteAsync(productEntity);
        }
    }
}