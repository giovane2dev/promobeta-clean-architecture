using System;
using Xunit;
using FluentAssertions;
using PromoBeta.Domain.Entities;


namespace PromoBeta.Domain.Tests
{
    public class ProductUnitTest
    {
        [Fact(DisplayName = "create a new product and validate parameters")]
        public void Test1()
        {
            Action action = () => new Product(1, "Geral", String.Empty, 10, String.Empty);

            action.Should().NotThrow<PromoBeta.Domain.Validation.DomainExceptionValidation>();
        }
    }
}