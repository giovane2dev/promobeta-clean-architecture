using System;
using Xunit;
using FluentAssertions;
using PromoBeta.Domain.Entities;


namespace PromoBeta.Domain.Tests
{
    public class CategoryUnitTest
    {
        [Fact(DisplayName = "create a new category and validate parameters")]
        public void Test1()
        {
            Action action = () => new Category(1, "Geral");

            action.Should().NotThrow<PromoBeta.Domain.Validation.DomainExceptionValidation>();
        }
    }
}