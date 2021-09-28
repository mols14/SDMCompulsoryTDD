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
        [InlineData(1, 2, 0)]
        [InlineData(2, 3, 1)]
        public void TestHowManyTimesReviewerNHaveGivenRateR(int n, int r, int expectedRes)
        {
            //Arrange
            IReviewRepository repo = new ReviewRepository();
            IService service = new Service(repo);

            //Act
            int actualRed = service.GetNumberOfRatesByReviewer(n, r);
            
            //Assert
            Assert.Equal(expectedRes, actualRed);
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

        /*[Theory]
        [InlineData(2, 2.5)]
        [InlineData(4, 3)]
        public void TestAverageRateOfMovie()
        {
            //Arrange
            IReviewRepository repo = new ReviewRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetAverageRateOfMovie(movie);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }*/
        
        [Fact]
        public void TestNameNotEmpty()
        {
            var mockRepo = new Mock<IReviewRepository>();

            var service = new Service(mockRepo.Object);

            service.GetAverageRateOfMovie(1);
            mockRepo.Verify(m => m.GetRatesByMovieId(1), Times.Once);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(6)]
        public void CreateMovie_withStringNotCorrectLenght_ThrowsArgumentException(int grade)
        {
            IReviewRepository repo = new ReviewRepository();
            IService service = new Service(repo);
            
            Assert.Throws<ArgumentException>(() =>
            {
                service.CreateMovie(new BEReview()
                {
                    Grade = grade,
                    Movie = 1,
                    ReviewDate = DateTime.Today,
                    Reviewer = 2
                });
            });
        }
    }
}