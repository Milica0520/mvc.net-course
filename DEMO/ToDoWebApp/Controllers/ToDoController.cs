using Microsoft.AspNetCore.Mvc;

using ToDoWebApp.DataBase;
using ToDoWebApp.Models.ViewModels;
using ToDoWebApp.Services;
using ToDoWebApp.Services.Dtos;

namespace ToDoWebApp.Controllers
{
    public class ToDoController : Controller
    {
        private TodoServices _todoServices;
        public ToDoController()
        { 
        _todoServices = new TodoServices();
        }
        public IActionResult Index(int statusId, int categoryId)
        {
            ViewBag.Filter = new FilterVM
            {
                Categories = InMemoryDb.Categories,
                Statuses = InMemoryDb.Statuses,
                SelectedCategoryId = categoryId,
                SelectedStatusId = statusId,

            };
            var result = _todoServices.GetToDos(statusId,categoryId);
          
            return View(result);
        }

        [HttpGet()]
        public IActionResult AddTodo()
        {
            ViewBag.Categories = InMemoryDb.Categories;
            ViewBag.Statuses = InMemoryDb.Statuses;

            return View();
        }
        [HttpPost()]
        public IActionResult AddTodo(CreateTodoDto createTodoDto)
        {
            _todoServices.AddTodo(createTodoDto);
            return RedirectToAction("Index");
        }

        [HttpPost()]
        public IActionResult MarkCompleted(int id)
        {
            _todoServices.MarkCompleted(id);
            return RedirectToAction("Index");
        }

        [HttpPost()]
        public IActionResult RemoveCompleted()
        {
            _todoServices.RemoveCompleted();
            return RedirectToAction("Index");
        }

        

     

    }
}
