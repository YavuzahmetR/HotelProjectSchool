using System.ComponentModel.DataAnnotations;

namespace HotelProjectUI.Dtos.AppUserDto
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "İsim Alanı Boş Geçilemez!")]
        public string Name { get; set; }
        public string City { get; set; }   
        [Required(ErrorMessage = "Soyisim Alanı Boş Geçilemez!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Boş Geçilemez!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail Alanı Boş Geçilemez!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Alanı Boş Geçilemez!")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Şifre Alanı Boş Geçilemez!")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor Tekrar Deneyin!")]
        public string ConfirmPassword { get; set; }

    }
}
