using FluentValidation;
using HotelProjectUI.Dtos.GuestDto;

namespace HotelProjectUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("İsim Alanı Boş Geçilemez!")
                .MinimumLength(2).WithMessage("İsim Alanı en az 2 karakter olmalı!")
                .MaximumLength(20).WithMessage("İsim Alanı en fazla 20 karakter olmalı!");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez!")
                .MinimumLength(2).WithMessage("Soyisim Alanı en az 2 karakter olmalı!")
                .MaximumLength(30).WithMessage("Soyisim Alanı en fazla 30 karakter olmalı!");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Şehir Alanı Boş Geçilemez!")
                .MinimumLength(3).WithMessage("Şehir Alanı en az 3 karakter olmalı!")
                .MaximumLength(15).WithMessage("Şehir Alanı en fazla 15 karakter olmalı!");
        }
    }

}
