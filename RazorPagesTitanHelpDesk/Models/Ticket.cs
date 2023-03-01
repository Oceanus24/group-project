using System.ComponentModel.DataAnnotations;

namespace RazorPagesTitanHelpDesk.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Problem Description")]
        public string? ProblemDescription { get; set; }
    }
}
