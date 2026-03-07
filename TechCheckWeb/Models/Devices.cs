namespace TechCheckWeb.Models
{
    public class Devices
    {
            // sql'deki "Devices" tablosundaki sütunların C#'taki karşılıkları:
            public int DeviceID { get; set; }
            public int CustomerID { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string SerialNumber { get; set; }
            public DateTime PurchaseDate { get; set; }


    }
}
