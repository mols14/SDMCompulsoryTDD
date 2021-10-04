using System;
using System.Collections.Generic;
using System.Linq;
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
        [InlineData(1, 2)]
        public void TestNumberOfReviewsFromN(int reviewer, int expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetNumberOfReviewsFromReviewer(reviewer);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }
        [Theory]
        [InlineData(1, 2.5)]
        public void TestAverageRateGivenByN(int reviewer, double expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);

            //Act
            var actual = service.GetAverageRateFromReviewer(reviewer);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(2, 3, 2)]
        public void TestHowManyTimesReviewerNHaveGivenRateR(int n, int r, int expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
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
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetNumberOfReviews(movie);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }

        [Theory]
        [InlineData(2, 2.5)]
        [InlineData(1, 3)]
        public void TestAverageRateOfMovie(int movie, double expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetAverageRateOfMovie(movie);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }

        [Theory]
        [InlineData(1, 5, 0)]
        [InlineData(2, 1, 2)]
        public void TestSpecificRateOnMovie(int movie, int rate, int expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetNumberOfRates(movie, rate);

            //Assert
            Assert.Equal(expectedRes, actual);
        }

        [Theory]
        [InlineData(new int[]{3,3,2,2,2,1,1})]
        public void TestMostProductiveReviewers(int[] expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetMostProductiveReviewers();
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }

        // public void TestGetTopRatedMovies(int amount, int expectedRes)
        // {
        //     //Arrange
        //     IReviewRepository repo = new DataRepository();
        //     IService service = new Service(repo);
        //     
        //     //Act
        //     var actual = service.GetTopRatedMovies(amount);
        //     
        //     //Assert
        //     Assert.Equal(expectedRes, actual);
        // }
        
        [Theory]
        [InlineData(1 ,new int[]{1,2})]
        [InlineData(2, new int[]{3, 1, 2, 3})]
        public void TestGetReviewersByMovie(int movie, int[] expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetReviewersByMovie(movie);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }

        [Theory]
        [InlineData(1, new int[]{1, 2})]
        [InlineData(2, new int[]{2, 5, 1})]
        public void TestGetTopMoviesByReviewer(int reviewer, int[] expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetTopMoviesByReviewer(reviewer);
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }
        
        [Theory]
        [InlineData(new int[]{2})]
        public void TestMoviesWithHighestNumberOfTopRates(int[] expectedRes)
        {
            //Arrange
            IReviewRepository repo = new DataRepository();
            IService service = new Service(repo);
            
            //Act
            var actual = service.GetMoviesWithHighestNumberOfTopRates(); 
            
            //Assert
            Assert.Equal(expectedRes, actual);
        }
    }
}