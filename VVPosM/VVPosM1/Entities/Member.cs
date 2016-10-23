using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VVPosM1.Entities;

namespace VVPosM1.Entities
{
    public class Member
    {
        public string MemberId { get; set; }
        public string MemberCode { get; set; }
        public string MemberName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool birthDay { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double TotalScore { get; set; }
        public int NumberOfVissits { get; set; }
        public DateTime LastestDate { get; set; }
        public MemberType MemberType { get; set; }
        public List<MemberType> List_MemberType { get; set; }

        public Country Country { get; set; }
        public int IsLock { get; set; }
        public DateTime LockDate { get; set; }
        public int IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Employees1 Creator { get; set; }
        public int CurrentScore { get; set; }
        public string MobilePhone { get; set; }
        public string Website { get; set; }
        public string TaxCode { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public CallName CallName { get; set; }
        public string Regency { get; set; }
        public string CompanyEmail { get; set; }
        public Employees1 Curator { get; set; }
        public CategoryActions CategoryID { get; set; }

        public Member()
        {
            MemberId = "";
            MemberCode = "";
            MemberName = "";
            BirthDate = new DateTime();
            PhoneNumber = "";
            Email = "";
            Address = "";
            TotalScore = 0;
            NumberOfVissits = 0;
            LastestDate = new DateTime();
            MemberType = new MemberType();
            List_MemberType = new List<Entities.MemberType>();
            Country = new Country();
            IsLock = 0;
            LockDate = new DateTime();
            IsDelete = 0;
            CreatedDate = new DateTime();
            UpdatedDate = new DateTime();
            Creator = new Employees1();
            CurrentScore = 0;
            MobilePhone = "";
            Website = "";
            TaxCode = "";
            CompanyName = "";
            Description = "";
            CallName = new CallName();
            Regency = "";
            CompanyEmail = "";
            Curator = new Employees1();
            CategoryID = new CategoryActions();
        }
    }
}
