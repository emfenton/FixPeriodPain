using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FixPeriodPain.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactFormModel Contact {get; set; }

        private readonly ILogger<ContactModel> _logger;

        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
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

            // create and send the mail here
            // private void SendMail(string mailbody)
            // {
            //     using (var message = new MailMessage(Contact.Email, "me@mydomain.com"))
            //     {
            //         message.To.Add(new MailAddress("me@mydomain.com"));
            //         message.From = new MailAddress(Contact.Email);
            //         message.Subject = "New E-Mail from my website";
            //         message.Body = mailbody;

            //         using (var smtpClient = new SmtpClient("mail.mydomain.com"))
            //             {
            //             smtpClient.Send(message);
            //             }
            //     }
            // }

            return RedirectToPage("Index");
        }
    }
}
