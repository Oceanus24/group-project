using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesTitanHelpDesk.Models;

namespace RazorPagesTitanHelpDesk.Data
{
    public class RazorPagesTitanHelpDeskContext : DbContext
    {
        public RazorPagesTitanHelpDeskContext (DbContextOptions<RazorPagesTitanHelpDeskContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTitanHelpDesk.Models.Ticket> Ticket { get; set; } = default!;
    }
}
