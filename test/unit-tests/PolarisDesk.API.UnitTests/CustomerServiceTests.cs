using PolarisDesk.API.Services;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PolarisDesk.API.UnitTests
{
    public class CustomerServiceTests
    {
        // Todo: for name choosing we can look to https://dzone.com/articles/7-popular-unit-test-naming
        [Fact]
        public async Task FeatureToBeTested()
        {
            // Assert
            var service = new CustomerService<object, object>();
            var expectedMessage = new NotImplementedException().Message;

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(() => service.Create(new object()));

            // Arrange
            exception.Message.ShouldBe(expectedMessage);
        }
    }
}
