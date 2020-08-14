using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConnectingToDb
{
    class Employee
    {
        
        [Key]
        public string Employeeguid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public bool Active { get; set; }
        public string Street { get; set; }
        public string Postal { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Package { get; set; }
        public string Vendor { get; set; }
        public int Phone { get; set; }
        public decimal PackageCost { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }


        ///package vendor phone   package cost    contract start  contract end

    }
}
