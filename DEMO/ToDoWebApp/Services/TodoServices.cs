using ToDoWebApp.DataBase;
using ToDoWebApp.Models.Enteties;
using ToDoWebApp.Services.Dtos;

namespace ToDoWebApp.Services
{
    public class TodoServices
    {
        public List<TodoDto> GetToDos(int? categoryId, int? statusId)
        {

            var todos = InMemoryDb.ToDos;


            if (categoryId.HasValue && categoryId.Value != 0)
                todos = todos.Where(t => t.CategoryId == categoryId.Value).ToList();

            if (statusId.HasValue && statusId.Value != 0)
                todos = todos.Where(t => t.StatusId == statusId.Value).ToList();

            var result = todos.Select(todo =>
                 new TodoDto
                 {
                     Id = todo.Id,
                     Description = todo.Description,
                     DueDate = todo.DueDate,
                     Category = InMemoryDb.Categories.Single(c => c.Id== todo.CategoryId).Name,
                     Status = InMemoryDb.Statuses.Single(s => s.Id == todo.StatusId).Name,
                 }
             ).ToList();

            return result;
        }

        public void AddTodo(CreateTodoDto createTodoDto)
        {
            var newTodo = new ToDo
            {
                Id = 0,
                Description = createTodoDto.Description,    
                DueDate = createTodoDto.DueDate,
                CategoryId = createTodoDto.CategoryId,
                StatusId = createTodoDto.StatusId,


            };

            InMemoryDb.Save(newTodo);   
        }
        public void MarkCompleted(int id)
        {
            var todoToComplete = InMemoryDb.ToDos .Single(t => t.Id == id);
            todoToComplete.StatusId = 2;
            InMemoryDb.Save(todoToComplete);
        }

        public void RemoveCompleted()
        {
            var todosToRemove = InMemoryDb.ToDos.Where(t => t.StatusId == 2).ToList();
            foreach (var toRemove in todosToRemove)
            {
                InMemoryDb.ToDos.Remove(toRemove);
            }
        }
    }
}
