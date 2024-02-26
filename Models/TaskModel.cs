using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime BeginningDate { get; set; }
        [DataType(DataType.Date)]
        public string EndDate { get; set; }
        public string? Attendant { get; set; }
        public decimal Price { get; set; }
    }
}
