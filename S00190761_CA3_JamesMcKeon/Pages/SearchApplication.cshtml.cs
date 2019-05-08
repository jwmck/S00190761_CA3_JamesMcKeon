using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S00190761_CA3_JamesMcKeon.Models;

namespace S00190761_CA3_JamesMcKeon.Pages
{
    public class SearchApplicationModel : PageModel
    {
        private readonly ChildContext _db;

        public SearchApplicationModel(ChildContext db)
        {
            _db = db;
        }

        [BindProperty]
        public string id1 { get; set; }


        [BindProperty]
        public Child Child { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            Child = await _db.Children.FindAsync(id1);

            if (Child != null)
            {
                return RedirectToPage("ThankYou", new { id = id1});
            }
            return Page();
        }
    }
}