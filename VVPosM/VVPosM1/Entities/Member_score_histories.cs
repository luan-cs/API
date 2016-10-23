using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class Member_score_histories
    {
        public string MemberId { get; set; }
        public DateTime ScoreUsedDateTime { get; set; }
        public int CurrentScore { get; set; }
        public int ScoreUsed { get; set; }
        public int TotalScore { get; set; }

        public Member_score_histories()
        {
            MemberId = "";
            ScoreUsedDateTime = new DateTime();
            CurrentScore = 0;
            ScoreUsed = 0;
            TotalScore = 0;
        }
    }
}
