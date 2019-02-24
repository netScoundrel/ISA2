using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Core
{
    public class NameValidation : ValidationAttribute
    {
        protected const string requireField = "Required field!";
        protected const string lenghtIsToBig = "Lenght should be less than 20 characters!!";
        protected const string useOnlyLetters = "Use only letters!";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return error(requireField);
            var s = value.ToString();
            if (s.Length > 20) return error(lenghtIsToBig);
            if (!onlyLetters(s)) return error(useOnlyLetters);
            return ValidationResult.Success;
        }

        protected static ValidationResult error(string s)
        {
            return new ValidationResult(s);
        }

        protected static bool onlyLetters(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            if (string.IsNullOrEmpty(s.Trim())) return false;
            return s.All(char.IsLetter);
        }
    }
}
