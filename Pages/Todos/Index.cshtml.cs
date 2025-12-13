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
    public class IndexModel : PageModel
    {
        private readonly MyTodoApp.Data.AppDbContext _context;

        public IndexModel(MyTodoApp.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<TodoItem> TodoItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TodoItem = await _context.TodoItems.ToListAsync();
        }
    }
}
