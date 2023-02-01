using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PromoBeta.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome da Categoria!")]
        [MinLength(5)]
        [MaxLength(150)]
        [DisplayName("Nome")]
        public string Name { get; set; }
    }
}