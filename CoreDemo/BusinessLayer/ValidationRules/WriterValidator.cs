using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Boş geçilemez").MinimumLength(2).WithMessage("En az 2 karakter olmalı");
            RuleFor(x => x.WriterEmail).NotEmpty().WithMessage("Boş geçilemez").EmailAddress().WithMessage("Geçerli Bir mail adresi giriniz");
            RuleFor(x=>x.WriterPassword)
         .NotEmpty().WithMessage("Parola alanı boş geçilemez!").Matches(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$").WithMessage("En az bir büyük-küçük harf,rakam ve sembol kullanınız");

        }
     
    }
}
