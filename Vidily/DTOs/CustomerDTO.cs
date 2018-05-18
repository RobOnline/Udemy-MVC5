using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidily.Models;

namespace Vidily.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

       public MembershipTypeDto MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

      
       // [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }

    }
}