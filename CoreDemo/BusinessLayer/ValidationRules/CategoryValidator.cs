using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
      public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("KATEGORİ ADI BOŞ GEÇİLEMEZ!!").MaximumLength(50).WithMessage("EN FAZLA 50 KARAKTER OLABİLİR!!").MinimumLength(2).WithMessage("MİNUMUM 2 KARAKTER OLABİLİR!!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("KATEGORİ AÇIKLAMASI BOŞ GEÇİLEMEZ!!");
        }
    }
}
