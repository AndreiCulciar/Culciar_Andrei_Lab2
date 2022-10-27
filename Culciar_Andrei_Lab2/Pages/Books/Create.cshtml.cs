using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Culciar_Andrei_Lab2.Data;
using Culciar_Andrei_Lab2.Models;

namespace Culciar_Andrei_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Culciar_Andrei_Lab2.Data.Culciar_Andrei_Lab2Context _context;

        public CreateModel(Culciar_Andrei_Lab2.Data.Culciar_Andrei_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            ViewData["AuthorsID"] = new SelectList(_context.Set<Authors>(), "ID","AuthorsName");

            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
