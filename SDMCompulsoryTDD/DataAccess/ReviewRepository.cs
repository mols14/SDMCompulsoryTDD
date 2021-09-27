using System;
using System.Collections.Generic;
using SDMCompulsoryTDD.BE;
using SDMCompulsoryTDD.Kernel;

namespace SDMCompulsoryTDD.DataAccess
{
    public class ReviewRepository : IReviewRepository
    {
        private MockData _mockData;
        private static List<BEReview> _reviews;

        public ReviewRepository()
        {
            _mockData = new MockData();
            _reviews = _mockData.InitData();
        }

        public IEnumerable<BEReview> GetAll()
        {
            return _reviews;
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