using System.ComponentModel.DataAnnotations;
namespace TechCheckWeb.Models
{
    public class ServiceRecord
    {
        [Key]
        public int RecordID { get; set; }
        public int DeviceID {  get; set; }
        public int TechnicianID { get; set; }
        public string? FailureDescription { get; set; }
        public string? RepairDetails { get; set; }
        public string? Status { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public bool IsChronic { get; set; }
    }

}
