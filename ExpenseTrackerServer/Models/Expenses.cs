using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerServer.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Title { get; set; }

        [Required]
        [Precision(18, 2)]
        public double Amount { get; set; }

        [Required]

        public DateTime Date { get; set; }

    }
}
