using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPMVC.Models
{
    public class ASPMVCContext : DbContext
    {
        public ASPMVCContext (DbContextOptions<ASPMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ASPMVC.Models.Gun> Gun { get; set; }
    }
}
