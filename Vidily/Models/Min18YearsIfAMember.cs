﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidily.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.DateOfBirth == null)
                return new ValidationResult("Date of Birth is required");

            var age = DateTime.Today.Year - customer.DateOfBirth.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("You must be 18 or over to subscribe");

        }
    }
}