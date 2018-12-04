﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Validators
{
    public class InsuranceValidator : ModelValidator
    {
        public InsuranceValidator(ModelMetadata metadata, ControllerContext context) : base(metadata, context)
        { }

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            Insurance i = (Insurance)Metadata.Model;

            List<ModelValidationResult> errors = new List<ModelValidationResult>();
            if (i.Name == "undefined" && i.Price <= 0)
            {
                errors.Add(new ModelValidationResult
                {
                    MemberName = "",
                    Message = "Unprocessable entity(Insurance)"
                });
            }
            return errors;
        }
    }
}