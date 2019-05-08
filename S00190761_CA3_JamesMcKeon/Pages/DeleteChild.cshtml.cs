using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S00190761_CA3_JamesMcKeon.Models;

namespace S00190761_CA3_JamesMcKeon.Pages
{
    public class DeleteChildModel : PageModel
    {
        private readonly ChildContext _db;

        public DeleteChildModel(ChildContext db)
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

            var child = await _db.Children.FindAsync(Child.ppsID);

            if (child != null)
            {
                _db.Children.Remove(child);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("ListApplications");
        }
    }
}