using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesTitanHelpDesk.Data;
using RazorPagesTitanHelpDesk.Models;

namespace RazorPagesTitanHelpDesk.Pages.Tickets
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTitanHelpDesk.Data.RazorPagesTitanHelpDeskContext _context;

        public IndexModel(RazorPagesTitanHelpDesk.Data.RazorPagesTitanHelpDeskContext context)
        {
            _context = context;
        }

        public IList<Ticket> Ticket { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Names { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? TicketName { get; set; }



        public async Task OnGetAsync()
        {
            var tickets = from t in _context.Ticket
                         select t;
            if (!string.IsNullOrEmpty(SearchString))
            {
                tickets = tickets.Where(s => s.Name.Contains(SearchString));
            }

            Ticket = await tickets.ToListAsync();
        }
    }
}
