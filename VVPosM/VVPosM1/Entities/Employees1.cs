using System;
using System.Drawing;

namespace VVPosM1.Entities
{
    public class Employees1
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Image Image { get; set; }
        public string Notes { get; set; }
        public Decimal HourlyWages { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public Country Country { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string EmployeeCode { get; set; }

        public Employees1()
        {
            EmployeeId = "";
            EmployeeName = "";
            BirthDate = new DateTime();
            Gender = 0;
            PhoneNumber = "";
            Email = "";
            Address = "";
            Image = null;
            Notes = "";
            HourlyWages = 0;
            EmployeeType = new EmployeeType();
            Country = new Country();
            UserName = "";
            Password = "";
            IsDelete = 0;
            CreatedDate = new DateTime();
            UpdatedDate = new DateTime();
            EmployeeCode = "";
        }

        public string EmployeeTypeId { get; set; }

        public string CountryId { get; set; }
    }
}
