using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPMVC.Models;

namespace ASPMVC.Pages.Guns
{
    public class DeleteModel : PageModel
    {
        private readonly ASPMVC.Models.ASPMVCContext _context;

        public DeleteModel(ASPMVC.Models.ASPMVCContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gun = await _context.Gun.FindAsync(id);

            if (Gun != null)
            {
                _context.Gun.Remove(Gun);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
