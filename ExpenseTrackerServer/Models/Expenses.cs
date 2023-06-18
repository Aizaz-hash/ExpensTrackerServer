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


        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Title")]
        [Required(ErrorMessage = "Title  is required ")]
        public string Title { get; set; }

        [DisplayName("Amount ")]
        [Required(ErrorMessage = "Amount is required")]
        [Precision(18, 2)]
        public string Amount { get; set; }

        [DisplayName("Date ")]
        [Required(ErrorMessage = "Date is required ")]
        public DateTime Date { get; set; }

    }
}
