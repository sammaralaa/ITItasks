using System;
using System.Collections.Generic;
using System.Text;


   public class Post
    {
         DateTime creatDate { set; get; }
        string Title { set; get; }
        string Description { set; get; }
        private long VoteValue { set; get; }

      public  Post()
        {
            VoteValue = 0;
        }
        public void up_vote()
        {
            VoteValue += 1;
        }

        public void down_vote()
        {
            if (VoteValue > 0)
            {
                VoteValue -= 1;
            }
            else
            {
                throw (new InvalidOperationException("the vote value is 0 "));
            }
        }
        public long printVotevalue()
        {
            return VoteValue;
        }
    }

