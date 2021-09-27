using System.Collections.Generic;
using SDMCompulsoryTDD.BE;
using SDMCompulsoryTDD.Kernel;

namespace SDMCompulsoryTDD.DataAccess
{
    public class ReviewRepository : IReviewRepository
    {
        public MockData _mockData;
        
        public ReviewRepository(MockData mockData)
        {
            _mockData = mockData;
            mockData.InitData();
        }

        public IEnumerable<BEReview> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public BEReview GetByReviewerNo(int reviewerNo)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(BEReview r)
        {
            throw new System.NotImplementedException();
        }

        public void Update(BEReview r)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(BEReview r)
        {
            throw new System.NotImplementedException();
        }
    }
}