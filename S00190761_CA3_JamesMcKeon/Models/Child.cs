using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace S00190761_CA3_JamesMcKeon.Models
{
    public class Child
    {
        [Required]
        [Key]
        [RegularExpression(@"(\d{7})(\w{1,2})", ErrorMessage = "PPS Number must be of like: 1234567x or 1234567xx")]
        public string ppsID { get; set; } = "";

        [Required]
        [MaxLength(20, ErrorMessage = "First Name must be at most 20 characters")]
        [Display(Name = "First Name")]
        [RegularExpression(@"\S{2,}", ErrorMessage = "First Name must be at least two characters.")]
        public string FirstName { get; set; } = "";


        [Required]
        [RegularExpression(@"\S{3,}", ErrorMessage = "Last Name must be at least three characters")]
        public string LastName { get; set; } = "";


        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "First Name must be at most 20 characters")]
        [Display(Name = "Parent/Guardian First Name")]
        [RegularExpression(@"\S{2,}", ErrorMessage = "First Name must be at least two characters.")]
        public string ParentFirstName { get; set; } = "";


        [Required]
        [RegularExpression(@"\S{3,}", ErrorMessage = "Last Name must be at least three characters")]
        public string ParentLastName { get; set; } = "";

        [Required]
        [Display(Name = "Relationship to Child")]
        public string Relationship { get; set; }

        [Required]
        public bool isFullTime { get; set; }

        [Required]
        public bool isPartTime { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Compare("Email")]
        [DataType(DataType.EmailAddress)]

        public string EmailConfirm { get; set; }

        //public bool IsMondayChecked { get; set; }

        //public bool IsTuesdayChecked { get; set; }

        //public bool IsWednesdayChecked { get; set; }

        //public bool IsThursdayChecked { get; set; }

        //public bool IsFridayChecked { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "You must choose at least one day")]
        public int numDays { get; set; }

        public Child()
        {

        }

        public decimal GetCostFull()
        {
            decimal cost = 0;

            if (numDays >= 4)
            {
                decimal discount;
                discount = (35 * numDays) / 10;
                cost = (35 * numDays) - discount;
                return cost;
            }

            else
            {
                cost += (35 * numDays);
                return cost;
            }

        }

        public decimal GetCostTemp()
        {
            decimal cost = 0;

            if (numDays >= 4)
            {
                decimal discount;
                discount = (20 * numDays) / 10;
                cost = (20 * numDays) - discount;
                return cost;
            }

            else
            {
                cost += (35 * numDays);
                return cost;
            }
        }

        public string fullString = "Full Time";
        public string partString = "Part Time";

    }
}
