using System.ComponentModel.DataAnnotations;

namespace TP2.Models
{
    public class Employe
    {
        public int Id { get; set; }
        [Required, StringLength(20, ErrorMessage = "Taille max 20 characters")]
        public string Name { get; set; }
        [Required]
        public string Departement { get; set; }
        [Required]
        public int Salary { get; set; }
        public String PhotoPath { get; set; }
    }
}
