using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC_ASP.Models
{
    public class ContactModel
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Email { get; set; }
    }
}
