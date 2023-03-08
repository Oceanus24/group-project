using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesTitanHelpDesk.Data;
using RazorPagesTitanHelpDesk.Models;

namespace RazorPagesTitanHelpDesk.Pages.Tickets
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesTitanHelpDesk.Data.RazorPagesTitanHelpDeskContext _context;

        public CreateModel(RazorPagesTitanHelpDesk.Data.RazorPagesTitanHelpDeskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ticket Ticket { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Ticket == null || Ticket == null)
            {
                return Page();
            }

            _context.Ticket.Add(Ticket);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
