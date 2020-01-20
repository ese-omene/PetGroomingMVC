using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PetGrooming.Models
{
    public class Groomer
    {
        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - First Name
                - Last Name
                - Date of Birth
                - Phone Number
                - Hourly Rate

            A booking must reference to a groomer
        */

        [Key]
        public int GroomerID { get; set; } //primary key
        public string GroomerFirstName { get; set; } // name of groomer (employee)
        public string GroomerLastName { get; set; } // last name of groomer (employee)
        public int GroomerPhone { get; set; } // contact info for groomer if you need to contact them,
        // only going with one phone number since majority of the people I talked to only have mobile phones
        public double GroomerRate { get; set; } // rate for groomer, different groomers might have different rates
        public DateTime GroomerDOB { get; set; } // date of birth for groomer, to have a complete profile for each groomer
         /*
         will need to add Groom Services as foreign key - each groomer can do different services
         
         */
    }
}