using System;
using System.Collections.Generic;
using SDMCompulsoryTDD.BE;
using SDMCompulsoryTDD.Kernel;

namespace SDMCompulsoryTDD.DataAccess
{
    public class ReviewRepository : IReviewRepository
    {
        private MockData _mockData;
        
        public ReviewRepository()
        {
            _mockData = new MockData();
            _mockData.InitData();
        }

        public IEnumerable<BEReview> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<int> GetReviewByReviewerNo(int reviewerNo)
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