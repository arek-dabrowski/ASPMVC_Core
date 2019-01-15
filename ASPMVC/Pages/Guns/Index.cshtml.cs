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
    public class IndexModel : PageModel
    {
        private readonly ASPMVC.Models.ASPMVCContext _context;

        public IndexModel(ASPMVC.Models.ASPMVCContext context)
        {
            _context = context;
        }

        public IList<Gun> Gun { get;set; }

        public async Task OnGetAsync()
        {
            Gun = await _context.Gun.ToListAsync();
        }
    }
}
