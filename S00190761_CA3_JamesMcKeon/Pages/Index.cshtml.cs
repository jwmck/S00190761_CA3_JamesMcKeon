using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace S00190761_CA3_JamesMcKeon.Pages
{
    public class IndexModel : PageModel
    {
        public string Message;
        public void OnGet()
        {
            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions
            {
                Expires = DateTime.Now.AddYears(1)
            };

            string previousVisit = DateTime.Now.ToString();

            Response.Cookies.Append("S00190761CA3Cookie", "FirstCookie", cookieOptions);

            if (Request.Cookies["S00190761CA3Cookie"] != null)
            {
                Message = "Welcome back!";
            }

            else Message = "Welcome";
        }
    }
}
