using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cristea_Anamaria_Lab8.Data;
using Cristea_Anamaria_Lab8.Models;

namespace Cristea_Anamaria_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Cristea_Anamaria_Lab8.Data.Cristea_Anamaria_Lab8Context _context;

        public IndexModel(Cristea_Anamaria_Lab8.Data.Cristea_Anamaria_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
