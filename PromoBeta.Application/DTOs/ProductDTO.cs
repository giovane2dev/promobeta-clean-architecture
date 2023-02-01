using PromoBeta.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PromoBeta.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Produto!")]
        [MinLength(5)]
        [MaxLength(150)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Informe o Valor do Produto!")]
        [DisplayName("Valor R$")]
        public decimal Price { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }

        [DisplayName("Categoria")]
        public Category Category { get; set; }
    }
}