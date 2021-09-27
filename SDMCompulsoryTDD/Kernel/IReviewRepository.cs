using System.Collections.Generic;
using SDMCompulsoryTDD.BE;

namespace SDMCompulsoryTDD.Kernel
{
    public interface IReviewRepository
    {
        IEnumerable<BEReview> GetAll();

        BEReview GetByReviewerNo(int reviewerNo);

        void Insert(BEReview r);

        void Update(BEReview r);

        void Delete(BEReview r);
    }
}