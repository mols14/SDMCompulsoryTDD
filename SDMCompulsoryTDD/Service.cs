using System;
using System.Collections.Generic;
using System.Linq;
using SDMCompulsoryTDD.BE;
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
            var allMovies = _dataAccess.GetAll()
                .Where(r => r.Movie == movie)
                .Where(r => r.Grade == rate).ToList();

            var numberOfRates = allMovies.Count;
            return numberOfRates;
        }

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetMostProductiveReviewers()
        {
            var reviews = _dataAccess.GetAll()
                .OrderByDescending(g => g.Reviewer).Select(r => r.Reviewer).ToList();
            return reviews;

        }

        public List<int> GetTopRatedMovies(int amount)
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            var movies = _dataAccess.GetAll()
                .OrderByDescending(g => g.Grade)
                .ThenByDescending(d => d.ReviewDate)
                .Where(r => r.Reviewer == reviewer)
                .Select(m => m.Movie).ToList();
            
            return movies;
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            var movies = _dataAccess.GetAll()
                .Where(r => r.Movie == movie)
                .Select(r => r.Reviewer).ToList();

            return movies;

        }

        public void CreateMovie(BEReview beReview)
        {
            if (beReview.Grade < 1 || beReview.Grade > 5)
            {
                throw new ArgumentException();
            }
        }
    }
}