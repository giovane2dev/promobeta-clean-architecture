using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PromoBeta.Application.DTOs;
using PromoBeta.Application.Interfaces;
using PromoBeta.Domain.Entities;
using PromoBeta.Domain.Interfaces;

namespace PromoBeta.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private readonly IMapper _imapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper imapper)
        {
            _categoryRepository = categoryRepository;
            _imapper = imapper;
        }

        public async Task CreateAsync(CategoryDTO category)
        {
            var categoryEntity = _imapper.Map<Category>(category);

            await _categoryRepository.CreateAsync(categoryEntity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            var categoriesEntity = await _categoryRepository.GetCategoriesAsync();

            return _imapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task<CategoryDTO> GetByIdAsync(int? id)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id);

            return _imapper.Map<CategoryDTO>(categoryEntity);
        }

        public async Task UpdateAsync(CategoryDTO category)
        {
            var categoryEntity = _imapper.Map<Category>(category);

            await _categoryRepository.UpdateAsync(categoryEntity);
        }

        public async Task DeleteAsync(CategoryDTO category)
        {
            var categoryEntity = _imapper.Map<Category>(category);

            await _categoryRepository.DeleteAsync(categoryEntity);
        }        
    }
}