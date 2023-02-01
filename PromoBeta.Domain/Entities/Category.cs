using System.Collections.Generic;
using PromoBeta.Domain.Validation;

namespace PromoBeta.Domain.Entities
{
    public sealed class Category : Base
    {
        public string Name { get; private set; }

        public Category(string name)
        {
            this.ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.Check(id < 0,
                "Código da Categoria inválido!");

            Id = id;

            this.ValidateDomain(name);
        }

        public void Update(string name)
        {
            this.ValidateDomain(name);
        }

        public ICollection<Product> Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.Check(string.IsNullOrEmpty(name),
                "Informe o Nome da Categoria!");

            Name = name;
        }
    }
}