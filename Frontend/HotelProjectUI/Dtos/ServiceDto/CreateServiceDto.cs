using System.ComponentModel.DataAnnotations;

namespace HotelProjectUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet İkonu belirtiniz !")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage ="Hizmet Başlığı belirtiniz")]
        [StringLength(100,ErrorMessage ="Hizmet Başlığı en fazla 100 karakter olabilir.")]
        public string ServiceTitle { get; set; }
        public string? Description { get; set; }
    }
}
