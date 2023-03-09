using System.ComponentModel.DataAnnotations;

namespace RazorPagesTitanHelpDesk.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Problem Description")]
        [Required]
        public string? ProblemDescription { get; set; }
    }
}
