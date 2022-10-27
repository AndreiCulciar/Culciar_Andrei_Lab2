using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Culciar_Andrei_Lab2.Data;
using Culciar_Andrei_Lab2.Models;

namespace Culciar_Andrei_Lab2.Pages.Authorss
{
    public class IndexModel : PageModel
    {
        private readonly Culciar_Andrei_Lab2.Data.Culciar_Andrei_Lab2Context _context;

        public IndexModel(Culciar_Andrei_Lab2.Data.Culciar_Andrei_Lab2Context context)
        {
            _context = context;
        }

        public IList<Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Authors = await _context.Authors.ToListAsync();
            }
        }
    }
}
