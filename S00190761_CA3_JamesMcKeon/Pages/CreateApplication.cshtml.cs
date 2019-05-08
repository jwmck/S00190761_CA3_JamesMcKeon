using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S00190761_CA3_JamesMcKeon.Models;

namespace S00190761_CA3_JamesMcKeon.Pages
{
    public class CreateApplicationModel : PageModel
    {
        private readonly ChildContext _db;

        public CreateApplicationModel(ChildContext db)
        {
            _db = db;
        }

        [TempData]
        public string MessageFull { get; set; }

        [TempData]
        public string MessageTemp { get; set; }

        [BindProperty]
        public Child Child { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (ModelState.IsValid)
            {

                _db.Children.Add(Child);
                await _db.SaveChangesAsync();
                MessageFull = $"Total Cost is €{Child.GetCostFull()} per week";
                MessageTemp = $"Total Cost is €{Child.GetCostTemp()} per week";
                return RedirectToPage("ThankYou", new { id = Child.ppsID });
            }

            else return Page();

        }
    }
}