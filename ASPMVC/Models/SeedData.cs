using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ASPMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ASPMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ASPMVCContext>>()))
            {
                if (context.Gun.Any())
                {
                    return;
                }

                context.Gun.AddRange(
                    new Gun
                    {
                        Name = "MP5",
                        ProductionDate = DateTime.Parse("1989-2-12"),
                        Type = "Submachine gun",
                        Caliber = "9mm",
                        Price = 1999.99M
                    },

                    new Gun
                    {
                        Name = "AK-47",
                        ProductionDate = DateTime.Parse("1989-2-12"),
                        Type = "Machine gun",
                        Caliber = "9mm",
                        Price = 1999.99M
                    },

                    new Gun
                    {
                        Name = "M1911",
                        ProductionDate = DateTime.Parse("1989-2-12"),
                        Type = "Pistol",
                        Caliber = "9mm",
                        Price = 1999.99M
                    },

                    new Gun
                    {
                        Name = "M82",
                        ProductionDate = DateTime.Parse("1989-2-12"),
                        Type = "Sniper rifle",
                        Caliber = "9mm",
                        Price = 1999.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
