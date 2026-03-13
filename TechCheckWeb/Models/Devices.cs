using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechCheckWeb.Models
{
    [Table("Devices")] // SQL'deki gerçek tablo adını bildiriyorum burada.
    public class Device
    {
        // sql'deki "Devices" tablosundaki sütunların C#'taki karşılıkları:
        [Key]
        public int DeviceID { get; set; }
            public int CustomerID { get; set; }
            public string? Brand { get; set; }
            public string? Model { get; set; }
            public string? SerialNumber { get; set; }
            public DateTime? PurchaseDate { get; set; }


    }
}
