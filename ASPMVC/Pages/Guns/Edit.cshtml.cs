using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPMVC.Models;

namespace ASPMVC.Pages.Guns
{
    public class EditModel : PageModel
    {
        private readonly ASPMVC.Models.ASPMVCContext _context;

        public EditModel(ASPMVC.Models.ASPMVCContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Gun Gun { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gun = await _context.Gun.FirstOrDefaultAsync(m => m.ID == id);

            if (Gun == null)
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

            _context.Attach(Gun).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GunExists(Gun.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GunExists(int id)
        {
            return _context.Gun.Any(e => e.ID == id);
        }
    }
}
