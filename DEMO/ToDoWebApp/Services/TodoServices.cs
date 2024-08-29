using ToDoWebApp.DataBase;
using ToDoWebApp.Models.DtoModels;

namespace ToDoWebApp.Services
{
    public class TodoServices
    {
        public List<ToDoDto> GetToDos()
        {

            var todoDtos = InMemoryDb.ToDos.Select(todo =>
            new ToDoDto
            {
                Id = todo.Id,
                Description = todo.Description,
                DueDate = todo.DueDate,
                Category = InMemoryDb.Categories.Single(c => c.Id == todo.Id).Name,
                Satatus = InMemoryDb.Statuses.Single(s => s.Id == todo.StatusId).Name
            }
            ).ToList();
            return todoDtos;
        }
    }
}
