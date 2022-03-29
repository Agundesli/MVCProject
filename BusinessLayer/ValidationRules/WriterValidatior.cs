using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidatior:AbstractValidator<Writer>
    {
        public WriterValidatior()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).MinimumLength(50).WithMessage("En az elli karakter girmelisiniz");
            RuleFor(x => x.WriterAbout).MaximumLength(20).WithMessage("En fazla 200 karakter girebilirsiniz");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("En az 2 karakter girebilirsiniz");
            RuleFor(x => x.WriterAbout).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz");


        }
    }
}
