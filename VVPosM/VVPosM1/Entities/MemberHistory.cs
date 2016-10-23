using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVPosM1.Entities
{
    public class MemberHistory
    {
        public int MemberHistoryId { get; set; }
        public DateTime DateToSPA { get; set; }
        public Decimal Money { get; set; }
        public int Score { get; set; }
        public Member Member { get; set; }

        public MemberHistory()
        {
            MemberHistoryId = 0;
            DateToSPA = new DateTime();
            Money = 0;
            Score = 0;
            Member = new Member();
        }
    }
}
