using ToDoWebApp.Models.Enteties;

namespace ToDoWebApp.DataBase
{
    public static class InMemoryDb
    {
        private static int _todoLastId;
        public static List<Category> Categories { get; set; }
        public static List<ToDo> ToDos { get; set; }
        public static List<Status> Statuses { get; set; }

        static InMemoryDb()
        {
            LoadCategories();
            LoadStatuses();
            LoadTodos();
            _todoLastId = 3;
        }
        private static void LoadCategories()
        {

            Categories = new List<Category> {
            new Category
            {
             Id = 1,
             Name = "Home"
            },

             new Category {
             Id = 2,
             Name  = "Work"
            },

             new Category {
             Id= 3,
             Name = "Exercise"
            },
            };
        }
        private static void LoadStatuses()
        {
            Statuses = new List<Status>
            {
            new Status { Id= 1, Name="Open"},
            new Status { Id =2, Name="Closed"}
            };
        }

        private static void LoadTodos()
        {
            ToDos = new List<ToDo> {
            new ToDo { Id=1, Description = "Make coffee", CategoryId=1, StatusId=1, DueDate = DateTime.Now.AddDays(1) },
            new ToDo { Id=2, Description = "Pay bills", CategoryId=2, StatusId=1, DueDate = DateTime.Now.AddDays(1) }
            };
        }

        public static void Save(ToDo todo)
        {
            if(todo.Id == 0)
            {
               todo.Id = ++_todoLastId;
                ToDos.Add(todo);
            }
            else
            {
                var toUpdata = ToDos.Single(t => t.Id == todo.Id);
                toUpdata = todo;
            }

        }



    }
}
