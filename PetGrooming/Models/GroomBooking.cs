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
    public class GroomBooking
    {
        /*
            A GroomBooking is an agreement between an owner and a groomer to provide services for a pet
            
            Some things that describe a GroomBooking
                - A date and time
                - Price
            
            A GroomBooking must reference
                - A Groomer
                - A Pet
                - An Owner
                - A list of GroomServices
                
        */

        [Key]
        public int GroomBookingID { get; set; }  //primary key

        public string GroomBookingDate { get; set; } //date for grooming service
        public DateTime GroomBookingTime { get; set; } // time for grooming service
        public double GroomBookingPrice { get; set; } // price for grooming service

        /*
         will need to add the foreign keys for 
         Groomer - since each booking needs a groomer
         GroomService - each booking can have multiple services
         Pet - you need to know which pet is getting groomed
         Owner - the owner is needed to know who to bill
         */

    }
}