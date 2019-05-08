using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S00190761_CA3_JamesMcKeon.Models;
using S00190761_CA3_JamesMcKeon.Data;
using Microsoft.EntityFrameworkCore;
using S00190761_CA3_JamesMcKeon.Pages;

namespace S00190761_CA3_JamesMcKeon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ppsController : ControllerBase
    {
        private readonly ppsContext _context;

        public IList<Child> Children { get; private set; }

        public ppsController(ppsContext context)
        {
            _context = context;

            if (_context.ppsItems.Count() == 0)
            {
                foreach (var Child in Children)
                {
                    _context.ppsItems.Add(new Models.ppsItem { ppsId = $"{Child.ppsID}" });
                    _context.SaveChanges();
                }
            }
        }

        // GET: api/pps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ppsItem>>> GetppsItems()
        {
            return await _context.ppsItems.ToListAsync();
        }
    }
}