using System;
using System.Collections.Generic;
using SDMCompulsoryTDD.BE;

namespace SDMCompulsoryTDD.DataAccess
{
    public class MockData
    {
        public List<BEReview> Reviews = new List<BEReview>();


        public void InitData()
        {
            var review1 = new BEReview()
            {
                Reviewer = 1,
                Movie = 1,
                Grade = 5,
                ReviewDate = DateTime.Today
            };
            Reviews.Add(review1);
        }
    }
}