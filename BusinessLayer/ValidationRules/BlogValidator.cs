using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Tarif başlığını boş geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Tarif içeriğini boş geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Tarif görselini boş geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage(" Lütfen 150 karakter sınırını aşmayın!");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage(" Lütfen 5 karakter sınırını aşın!");

        }
    }
}
