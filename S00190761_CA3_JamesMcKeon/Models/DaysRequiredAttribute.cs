using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using S00190761_CA3_JamesMcKeon.Models;
using System.ComponentModel.DataAnnotations;

namespace S00190761_CA3_JamesMcKeon.Model
{
    //public class DaysRequiredAttribute : ValidationAttribute, IClientModelValidator
    //{
    //    protected override ValidationResult IsValid(object Child, ValidationContext validationContext)
    //    {
    //        Child child = (Child)validationContext.ObjectInstance;
    //        if (child.IsMondayChecked == false || child.IsTuesdayChecked == false || child.IsWednesdayChecked == false || child.IsThursdayChecked == false || child.IsFridayChecked == false)
    //        {
    //            return new ValidationResult("Please select at least one day.");
    //        }

    //        return ValidationResult.Success;

    //    }

    //    public void AddValidation(ClientModelValidationContext context)
    //    {
    //        context.Attributes.Add("data-val", "true");
    //        context.Attributes.Add("data-val-DaysRequired", "Please select at least one `day");
    //    }
    //}
}
