using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FixPeriodPain.Data;
using FixPeriodPain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FixPeriodPain.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FixPeriodPainContext _context;

        [BindProperty]
        public EmailSignupFormModel Email { get; set; }


        public IndexModel(ILogger<IndexModel> logger, FixPeriodPainContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            var emailSignup = new EmailSignup 
            {
                EmailAddress = Email.Email
            };
            _context.EmailSignup.Add(emailSignup);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}