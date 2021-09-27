using System.Collections.Generic;

namespace SDMCompulsoryTDD.Kernel
{
    public interface IService
    {
        //On input N, what are the number of reviews from reviewer N
        public int GetNumberOfReviewsFromReviewer(int reviewer);
        
        //On input N, what is the average rate that reviewer N had given
        public double GetAverageRateFromReviewer(int reviewer);
    
        //On input N and R, how many times has reviewer N given rate R
        public int GetNumberOfRatesByReviewer(int reviewer, int rate);
    
        //On input N, how many have reviewed movie N
        public int GetNumberOfReviews(int movie);
    
        //On input N, what is the average rate the movie N had received
        public double GetAverageRateOfMovie(int movie);
        
        //On input N and R, how many times had movie N received rate R
        public int GetNumberOfRates(int movie, int rate);

        //What is the id(s) of the movie(s) with the highest number of top rates (5)
        public List<int> GetMoviesWithHighestNumberOfTopRates();
        
        //What reviewer(s) had done most reviews
        public List<int> GetMostProductiveReviewers();
        
        //On input N, what is top N of movies? The score of a movie is its average rate.
        public List<int> GetTopRatedMovies(int amount);

        //On input N, what are the movies that reviewer N has reviewed?
        //The list should be sorted decreasing by rate first, and date secondly.
        public List<int> GetTopMoviesByReviewer(int reviewer);

        //On input N, who are the reviewers that have reviewed movie N?
        //The list should be sorted decreasing by rate first, and date secondly.
        public List<int> GetReviewersByMovie(int movie);
    }
}