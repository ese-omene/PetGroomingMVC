﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService      
    {

        [Key]
        public int GroomServiceID { get; set; } // primary key
        public string GroomServiceName { get; set; } // Name of service
        public double GroomServicePrice { get; set; } // Price of service
        public int GroomServiceDuratoin { get; set; } // how long the service will take

        /*
            A GroomService is a type of activity that a Groomer can do for a pet. Some examples might be nail clipping, shampoo, trim, etc.
            
            Some things that describe a GroomService
                - Service Name
                - Cost
                - Duration
         */
    }
}