using System.ComponentModel.DataAnnotations;

namespace HotelProjectUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet İkonu belirtiniz !")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı belirtiniz")]
        [StringLength(100, ErrorMessage = "Hizmet Başlığı en fazla 100 karakter olabilir.")]
        public string ServiceTitle { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması belirtiniz")]
        [StringLength(200, ErrorMessage = "Hizmet Başlığı en fazla 200 karakter olabilir.")]
        public string Description { get; set; }
    }
}
