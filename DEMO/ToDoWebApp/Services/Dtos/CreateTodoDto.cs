namespace ToDoWebApp.Services.Dtos
{
    public class CreateTodoDto
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int CategoryId { get; set; }

        public int StatusId { get; set; }
    }
}