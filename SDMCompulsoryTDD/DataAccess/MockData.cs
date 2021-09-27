using System;
using System.Collections.Generic;
using SDMCompulsoryTDD.BE;

namespace SDMCompulsoryTDD.DataAccess
{
    public class MockData
    {
        public List<BEReview> Reviews = new List<BEReview>();


        public List<BEReview> InitData()
        {
            var review1 = new BEReview()
            {
                Reviewer = 1,
                Movie = 1,
                Grade = 4,
                ReviewDate = DateTime.Today
            };
            var review3 = new BEReview()
            {
                Reviewer = 1,
                Movie = 2,
                Grade = 1,
                ReviewDate = DateTime.Today
            };
            var review2 = new BEReview()
            {
                Reviewer = 1,
                Movie = 2,
                Grade = 1,
                ReviewDate = DateTime.Today
            };
            Reviews.Add(review1);
            Reviews.Add(review2);
            return Reviews;
        }
    }
}