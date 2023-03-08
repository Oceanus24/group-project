using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTitanHelpDesk.Data;
using RazorPagesTitanHelpDesk.Models;

namespace RazorPagesTitanHelpDesk.Pages.Tickets
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesTitanHelpDesk.Data.RazorPagesTitanHelpDeskContext _context;

        public DetailsModel(RazorPagesTitanHelpDesk.Data.RazorPagesTitanHelpDeskContext context)
        {
            _context = context;
        }

      public Ticket Ticket { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ticket == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket.FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }
            else 
            {
                Ticket = ticket;
            }
            return Page();
        }
    }
}
