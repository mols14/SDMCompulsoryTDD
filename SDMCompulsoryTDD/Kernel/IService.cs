namespace SDMCompulsoryTDD.Kernel
{
    public interface IService
    {
        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            throw new System.NotImplementedException();
        }

        public double GetAverageRateFromReviewer(int reviewer)
        {
            throw new System.NotImplementedException();
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

        public double GetNumberOfRates(int movie, int rate)
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

        public List<int> GetTopRatedMovies(int amount){}

        public List<int> GetTopMoviesByReviewer(int reviewer){}

        public List<int> GetReviewersByMovie(int movie) {}
    }
}