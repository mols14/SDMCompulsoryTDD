using System.Collections.Generic;

namespace SDMCompulsoryTDD.Kernel
{
    public interface IService
    {
        public int GetNumberOfReviewsFromReviewer(int reviewer);

        public double GetAverageRateFromReviewer(int reviewer);

        public int GetNumberOfRatesByReviewer(int reviewer, int rate);

        public int GetNumberOfReviews(int movie);

        public double GetAverageRateOfMovie(int movie);
        
        public double GetNumberOfRates(int movie, int rate);

        public List<int> GetMoviesWithHighestNumberOfTopRates();
        
        public List<int> GetMostProductiveReviewers();
        
        public List<int> GetTopRatedMovies(int amount);

        public List<int> GetTopMoviesByReviewer(int reviewer);

        public List<int> GetReviewersByMovie(int movie);
    }
}