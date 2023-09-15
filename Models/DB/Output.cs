using System.ComponentModel.DataAnnotations;
#nullable disable
namespace CoreAPI_SP.Models.DB
{
    public partial class output
    {
        [Key]
        public int AppointmentId { get; set; }
        public int ReturnCode { get; set; }
        public DateTime SubmittedTime { get; set; }
    }
}
