using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hotel
    {
        public Guid Id { get; set; }
        public string? Website { get; set; }
        public string? CompanyName { get; set; }
        public string? Address { get; set; }

        public string? City { get; set; }
        public string? Country { get; set; }
        public string? ZipCode { get; set; }
        public string? ReceptionPhoneNumber { get; set; }
        public string? ReceptionEmail { get; set; }
        public string? SalesDepartmentPhoneNumber { get; set; }
        public string? SalesDepartmentEmail { get; set; }

        public string? ManagerPhoneNumber { get; set; }
        public string? ManagerEmail { get; set; }
        public string? ManagerFirstName { get; set; }
        public string? ManagerLastName { get; set; }
    }
}
