using System.ComponentModel.DataAnnotations;
namespace TechCheckWeb.Models
{
    public class Customer
    {
        [Key] //Visual Studio'ya "Primary key" dedim
        public int CustomerID { get; set; }

        public string FullName { get; set; }

        // Bunların sonuna ? koyuyorum ki "Boş (NULL) olabilir" diyoruz.
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
