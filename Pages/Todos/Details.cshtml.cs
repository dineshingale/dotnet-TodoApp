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
    public class DetailsModel : PageModel
    {
        private readonly MyTodoApp.Data.AppDbContext _context;

        public DetailsModel(MyTodoApp.Data.AppDbContext context)
        {
            _context = context;
        }

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
    }
}
