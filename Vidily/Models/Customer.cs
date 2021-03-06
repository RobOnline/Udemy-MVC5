﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidily.Models
{
    public class Customer

    {
        public int Id { get; set; }

        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display (Name ="Membership Type")]
        public byte MembershipTypeId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display (Name ="Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }
    }
}