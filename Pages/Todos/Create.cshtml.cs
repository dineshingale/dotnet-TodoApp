using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTodoApp.Data;
using MyTodoApp.Models;

namespace MyTodoApp.Pages_Todos
{
    public class CreateModel : PageModel
    {
        private readonly MyTodoApp.Data.AppDbContext _context;

        public CreateModel(MyTodoApp.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TodoItem TodoItem { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TodoItems.Add(TodoItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
