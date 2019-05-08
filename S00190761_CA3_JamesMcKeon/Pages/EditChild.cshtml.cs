using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using S00190761_CA3_JamesMcKeon.Models;

namespace S00190761_CA3_JamesMcKeon.Pages
{
    public class EditChildModel : PageModel
    {
        private readonly ChildContext _db;

        public EditChildModel(ChildContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Child Child { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Child = await _db.Children.FindAsync(id);

            if (Child == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(Child).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception($"Child {Child.ppsID} not found!");
            }

            return RedirectToPage("/ListApplications");
        }


    }
}