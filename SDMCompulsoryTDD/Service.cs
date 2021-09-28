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
            var reviews = _dataAccess.GetAll();
            var rates = reviews
                .Where(r => r.Reviewer == reviewer)
                .Select(r => r.Grade).ToList();

            var numberOfRates = rates.Count;
            return numberOfRates;
        }

        public double GetAverageRateFromReviewer(int reviewer)
        {
            var reviews = _dataAccess.GetAll();
            var rates = reviews
                .Where(r => r.Reviewer == reviewer)
                .Select(r => r.Grade).ToList();

            var averageOfRates = rates.Average();
            return averageOfRates;
        }

        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            var reviewsByReviewer = _dataAccess.GetAll()
                .Where(r => r.Reviewer == reviewer)
                .Where(r => r.Grade == rate).ToList();
            var numberOfRatesByReviewer = reviewsByReviewer.Count;
            return numberOfRatesByReviewer;
        }

        public int GetNumberOfReviews(int movie)
        {
            var allReviews = _dataAccess.GetAll();
            var movieReviews = allReviews
                .Where(r => r.Movie == movie)
                .Select(r => r.Movie).ToList();
            
            var numberOfReviews = movieReviews.Count;
            return numberOfReviews;
        }

        public double GetAverageRateOfMovie(int movie)
        {
            var allReviews = _dataAccess.GetAll();
            var movieGrades = allReviews
                .Where(r => r.Movie == movie)
                .Select(r => r.Grade).ToList();

           var averageOfMovie = movieGrades.Average();

           return averageOfMovie;
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