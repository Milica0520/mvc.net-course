using Microsoft.AspNetCore.Mvc;
using ToDoWebApp.DataBase;
using ToDoWebApp.Models.DtoModels;
using ToDoWebApp.Models.Enteties;
using ToDoWebApp.Services;

namespace ToDoWebApp.Controllers
{
    public class ToDoController : Controller
    {
        private TodoServices _todoServices;
        public ToDoController() { 
        _todoServices = new TodoServices();
        }
        public IActionResult Index(string status)
        {

            var result = _todoServices.GetToDos();
          
            return View(result);
        }



      
    }
}
