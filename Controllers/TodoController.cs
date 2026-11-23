using Microsoft.AspNetCore.Mvc;
using TodoMVC_CSharp.Data;
using TodoMVC_CSharp.Models;

namespace TodoMVC_CSharp.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoDbContext context;
        public TodoController(TodoDbContext todoDbContext)
        {
           context = todoDbContext;
        }
        public IActionResult Todos()
        {
            var todos = context.Todos.ToList();
            return View(todos);
        }

        public IActionResult AddEditTodo()
        {
            return View();
        }


        public IActionResult AddEditTodoSubmit(Todo todo)
        {
            return RedirectToAction("Todos");
        }
    }

}
