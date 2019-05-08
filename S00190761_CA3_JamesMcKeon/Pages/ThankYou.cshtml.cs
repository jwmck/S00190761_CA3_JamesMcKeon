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
    public class ThankYouModel : PageModel
    {
        private readonly ChildContext _db;

        [TempData]
        public string MessageFull { get; set; }

        [TempData]
        public string MessageTemp { get; set; }

        public ThankYouModel(ChildContext db)
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

    }
}