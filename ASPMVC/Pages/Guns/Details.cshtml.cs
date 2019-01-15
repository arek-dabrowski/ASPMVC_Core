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
    public class DetailsModel : PageModel
    {
        private readonly ASPMVC.Models.ASPMVCContext _context;

        public DetailsModel(ASPMVC.Models.ASPMVCContext context)
        {
            _context = context;
        }

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
    }
}
