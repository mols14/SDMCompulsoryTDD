using System.Collections.Generic;
using System.Linq;
using SDMCompulsoryTDD.Kernel;

namespace SDMCompulsoryTDD
{
    public class Service : IService
    {
        private IReviewRepository _dataAccess;

        public Service(IReviewRepository dataAccess)
        {
            _dataAccess = dataAccess;
        }


        //On input N, what are the number of reviews from reviewer N?
        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            throw new System.NotImplementedException();
        }

        public double GetAverageRateFromReviewer(int reviewer)
        {
            var reviews = _dataAccess.GetReviewByReviewerNo(reviewer);
            var averageOfReviews = reviews.Average();
            return averageOfReviews;
        }

        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            throw new System.NotImplementedException();
        }

        public int GetNumberOfReviews(int movie)
        {
            throw new System.NotImplementedException();
        }

        public double GetAverageRateOfMovie(int movie)
        {
            throw new System.NotImplementedException();
        }

        public int GetNumberOfRates(int movie, int rate)
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetMostProductiveReviewers()
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetTopRatedMovies(int amount)
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            throw new System.NotImplementedException();
        }

    }
}