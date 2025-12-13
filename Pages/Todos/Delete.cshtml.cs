using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyTodoApp.Data;
using MyTodoApp.Models;

namespace MyTodoApp.Pages_Todos
{
    public class DeleteModel : PageModel
    {
        private readonly MyTodoApp.Data.AppDbContext _context;

        public DeleteModel(MyTodoApp.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TodoItem TodoItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoitem = await _context.TodoItems.FirstOrDefaultAsync(m => m.Id == id);

            if (todoitem is not null)
            {
                TodoItem = todoitem;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoitem = await _context.TodoItems.FindAsync(id);
            if (todoitem != null)
            {
                TodoItem = todoitem;
                _context.TodoItems.Remove(TodoItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
