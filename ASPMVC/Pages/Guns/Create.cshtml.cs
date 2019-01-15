using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPMVC.Models;

namespace ASPMVC.Pages.Guns
{
    public class CreateModel : PageModel
    {
        private readonly ASPMVC.Models.ASPMVCContext _context;

        public CreateModel(ASPMVC.Models.ASPMVCContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Gun Gun { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Gun.Add(Gun);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}