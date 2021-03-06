﻿using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace NETworkManager.Validators
{
    public class NoSpacesValidator : ValidationRule
    {        
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(!string.IsNullOrEmpty(value as string) && !(value as string).Trim().Contains(" "))            
                return ValidationResult.ValidResult;
            
            return new ValidationResult(false, Application.Current.Resources["String_ValidationError_SpacesAreNotAllowed"] as string);
        }
    }
}