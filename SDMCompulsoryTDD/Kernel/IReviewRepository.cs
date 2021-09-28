using System.Collections.Generic;
using SDMCompulsoryTDD.BE;

namespace SDMCompulsoryTDD.Kernel
{
    public interface IReviewRepository
    {
        IEnumerable<BEReview> GetAll();

        IEnumerable<int> GetReviewByReviewerNo(int reviewerNo);

        IEnumerable<double> GetRatesByMovieId(int movieId);

        
        void Insert(BEReview r);

        void Update(BEReview r);

        void Delete(BEReview r);
    }
}