using System;
using TDDemo.Services;
using Tynamix.ObjectFiller;
using Xunit;

namespace TDDemo.Tests
{
    public class NameServiceTests
    {
        [Fact]
        public void ShouldReturnMrName()
        {
            // given
            string randomName = new RealNames(NameStyle.LastName).GetValue();
            string inputName = randomName;
            string expectedMrName = $"Mr. {randomName}";
            var nameService = new NameService();

            // when
            string actualMrName = nameService.GetMrName(inputName);

            // then
            Assert.Equal(expectedMrName, actualMrName);
        }

        [Fact]
        public void ShouldReturnMrsName()
        {
            string randomName = new RealNames(NameStyle.LastName).GetValue();
            string inputName = randomName;
            string expectedMrsName = $"Mrs. {randomName}";
            var nameService = new NameService();

            string actualMrsName = nameService.GetMrsName(inputName);

            Assert.Equal(expectedMrsName, actualMrsName);
        }
    }
}
