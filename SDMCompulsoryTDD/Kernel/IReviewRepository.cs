using System.Collections.Generic;
using SDMCompulsoryTDD.BE;

namespace SDMCompulsoryTDD.Kernel
{
    public interface IReviewRepository
    {
        IEnumerable<BEReview> GetAll();
    }
}