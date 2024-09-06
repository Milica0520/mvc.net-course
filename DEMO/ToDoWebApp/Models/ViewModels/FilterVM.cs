using ToDoWebApp.Models.Enteties;

namespace ToDoWebApp.Models.ViewModels
{
    public class FilterVM
    {
        public List<Category> Categories { get; set; }
        public List<Status> Statuses { get; set; }
        public int SelectedCategoryId { get; set; }
        public int SelectedStatusId { get; set; }
    }
}