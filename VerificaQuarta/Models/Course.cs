using System.ComponentModel.DataAnnotations;
using System.Data;

namespace VerificaQuarta.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il titolo è obbligatorio")]
        public string Title { get; set; }

        [Required(ErrorMessage = "L'autore è obbligatorio")]
        public string Author { get; set; }

        public double Rating { get; set; }

        public double CurrentPrice_Amount { get; set; }

        public string? CurrentPrice_Currency { get; set; }
    }
}
