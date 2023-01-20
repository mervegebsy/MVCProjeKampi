using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            {
                RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
                RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş geçilemez");
                RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında boş geçilemez");
                RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar ünvanı boş geçilemez");
                RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Lütfen en az üç karakter girişi yapın");
                RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakteri geçmeyiniz");



            }
        }
    }
}
