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
    public class Owner
    {
        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)

            An owner must reference a list of pets
            
        */

        [Key]
        public int OwnerID { get; set; } // primary key
        public string OwnerFirstName { get; set; } // first name of pet owner
        public string OwnerLastName { get; set; } // last nameof pet owner
        public int  OwnerPhone { get; set; } // contact info for owner - phone number
        public string OwnerEmail { get; set; } // contact info for owner - email

        /* will add in foreign key for 
         Pet - one owner could have several pets
         */


    }
}