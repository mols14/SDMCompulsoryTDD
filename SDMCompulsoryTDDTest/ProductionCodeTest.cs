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
        [InlineData(1, 3)]
        public void TestNumberOfReviewsFromN(int reviewer, int expectedRes)
        {
            //Arrange
            IReviewRepository repo = new ReviewRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetNumberOfReviewsFromReviewer(reviewer);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }
        [Theory]
        [InlineData(1, 2)]
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


        [Theory]
        [InlineData(1, 2)]
        public void TestGetNumberOfReviews(int movie, int expectedRes)
        {
            //Arrange
            IReviewRepository repo = new ReviewRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetNumberOfReviews(movie);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }

        [Theory]
        [InlineData(2, 2.5)]
        public void TestAverageRateOfMovie(int movie, double expectedRes)
        {
            //Arrange
            IReviewRepository repo = new ReviewRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetAverageRateOfMovie(movie);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }
    }
}