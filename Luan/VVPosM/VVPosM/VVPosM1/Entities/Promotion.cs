using System;
using System.Drawing;

namespace VVPosM1.Entities
{
    public class Promotion
    {
        public string PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string PromotionName2 { get; set; }
        public string PromotionName3 { get; set; }
        public DateTime BeginDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public string PercentDiscount { get; set; }
        public PromotionType PromotionType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Employees1 Creator { get; set; }
        public string Product { get; set; }
        public string Type { get; set; }
        

        public Promotion()
        {
            PromotionId = "";
            PromotionName = "";
            PromotionName2 = "";
            PromotionName3 = "";
            BeginDateTime = new DateTime();
            EndDateTime = new DateTime();
            BeginTime = "";
            EndTime = "";
            PercentDiscount = "";
            PromotionType = new PromotionType();
            CreateDate = new DateTime();
            UpdateDate = new DateTime();
            Creator = new Employees1();
            Product = "";
            Type = "0";
        }
    }
}
