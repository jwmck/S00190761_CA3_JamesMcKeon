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
    public class ListChildrenModel : PageModel
    {
        private readonly ChildContext _db;

        public ListChildrenModel(ChildContext db)
        {
            _db = db;
        }

        public IList<Child> Children { get; private set; }

        //gets the list of children when the page is loaded. AsNoTracking improves performance - tells the system not to track db changes
        public async Task OnGetAsync()
        {
            Children = await _db.Children.AsNoTracking().ToListAsync();
        }

    }
}