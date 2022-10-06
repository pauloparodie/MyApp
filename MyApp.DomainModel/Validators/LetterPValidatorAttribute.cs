using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyApp.DomainModel.Validators
{
    public class LetterPValidatorAttribute : ValidationAttribute
    {
        private string _errorMessage;
        private char _letter;

        public LetterPValidatorAttribute(char letter)
        {
            _letter = letter;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            String val = Convert.ToString(value);

            if (!String.IsNullOrWhiteSpace(val) && val.Contains(_letter))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(_errorMessage);
            }
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(ErrorMessage, name, _letter);
        }
    }
}