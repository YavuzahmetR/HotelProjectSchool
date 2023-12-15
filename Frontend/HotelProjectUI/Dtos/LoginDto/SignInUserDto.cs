using System.ComponentModel.DataAnnotations;

namespace HotelProjectUI.Dtos.LoginDto
{
    public class SignInUserDto
    {
        [Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre Boş Geçilemez!")]
        public string Password { get; set; }
    }
}
