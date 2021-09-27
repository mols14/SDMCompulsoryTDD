using System;
using Moq;
using SDMCompulsoryTDD;
using SDMCompulsoryTDD.BE;
using SDMCompulsoryTDD.DataAccess;
using SDMCompulsoryTDD.Kernel;
using Xunit;

namespace SDMCompulsoryTDDTest
{
    public class ProductionCodeTest
    {
        [Theory]
        [InlineData(1, 2.5)]
        public void TestAverageRateGivenByN(int reviewer, double expectedRes)
        {
            //Arrange
            IReviewRepository repo = new ReviewRepository();
            IService service = new Service(repo);

            //Act
            var actual = service.GetAverageRateFromReviewer(reviewer);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }
    }
}