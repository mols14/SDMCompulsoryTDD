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
            var review4 = new BEReview()
            {
                Reviewer = 2,
                Movie = 1,
                Grade = 2,
                ReviewDate = DateTime.Today
            };
            var review5 = new BEReview()
            {
                Reviewer = 2,
                Movie = 2,
                Grade = 3,
                ReviewDate = DateTime.Today
            };
            var review6 = new BEReview()
            {
                Reviewer = 2,
                Movie = 2,
                Grade = 5,
                ReviewDate = DateTime.Today
            };
            var review7 = new BEReview()
            {
                Reviewer = 2,
                Movie = 5,
                Grade = 3,
                ReviewDate = DateTime.Today
            };
            Reviews.Add(review1);
            Reviews.Add(review2);
            Reviews.Add(review3);
            Reviews.Add(review4);
            Reviews.Add(review5);
            Reviews.Add(review6);
            Reviews.Add(review7);
            return Reviews;
        }
    }
}