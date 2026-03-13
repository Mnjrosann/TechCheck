using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TechCheckWeb.Models
{
    [Table("Users")]
    public class AppUser
    {
        [Key]

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string UserRole { get; set; }
    }
}
