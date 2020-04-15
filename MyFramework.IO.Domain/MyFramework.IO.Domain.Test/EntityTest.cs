using FluentAssertions;
using MyFramework.IO.Domain.Test.MockClass;
using System;
using Xunit;

namespace MyFramework.IO.Domain.Test
{
    public class EntityTest
    {
        public EntityTest()
        {
        }

        [Fact]
        public void Entity_When_New_Should_GenerateNewId()
        {
            //Arrange
            Foo fooEntity;

            //Act
            fooEntity = new Foo("Description 1");

            //Assert
            Assert.NotNull(fooEntity);
            Assert.NotEmpty(fooEntity.Id.ToString());
            Assert.NotEqual(Guid.Empty, fooEntity.Id);
        }

        [Fact]
        public void Entity_When_CompareObject_Should_BeFalse()
        {
            //Arrange
            Foo foo1 = new Foo("Description 1");
            Foo foo2 = null;

            //Act
            var result = foo1.Equals(foo2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Entity_When_CompareSameObjects_Should_BeTrue()
        {
            //Arrange
            Foo foo1 = new Foo("Description 1");
            Foo foo2 = foo1;

            //Act
            var result = foo1.Equals(foo2);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("Description 1", "Description 1")]
        [InlineData("Description 1", "Description 2")]
        public void Entity_When_CompareDifferentObject_Should_BeFalse(string description1, string description2)
        {
            //Arrange
            Foo foo1 = new Foo(description1);
            Foo foo2 = new Foo(description2);

            //Act
            var result = foo1.Equals(foo2);

            //Assert
            Assert.True(result);
        }
    }
}
