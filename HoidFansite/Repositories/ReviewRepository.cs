﻿using System.Collections.Generic;
using HoidFansite.Models;

namespace HoidFansite.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        static private List<UserReview> reviews = new List<UserReview>();

        public ReviewRepository()
        {
            if (reviews.Count == 0)
                reviews = new FakeReviewRepository().Reviews;
        }

        public List<UserReview> Reviews { get { return reviews; } }

        public void AddReview(UserReview Review)
        {
            reviews.Add(Review);
        }

        public List<UserReview> GetReviewsByStory(int ID)
        {
            List< UserReview> storyMatches = new List<UserReview>();
            foreach (UserReview r in reviews)
            {
                if(r.StoryID == ID)
                {
                    storyMatches.Add(r);
                }
            }
            return storyMatches;
        }
    }
}