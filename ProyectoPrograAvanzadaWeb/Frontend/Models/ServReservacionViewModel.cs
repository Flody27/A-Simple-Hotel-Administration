using System.ComponentModel;

namespace Frontend.Models
{
    public class ServReservacionViewModel
    {
        [DisplayName("Servicio Reservacion ID")]
        public int SrId { get; set; }
        [DisplayName("Reservacion ID")]
        public int? SrRsvId { get; set; }
        [DisplayName("Servicio ID")]
        public int? SrSvcId { get; set; }
    }
}
