using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CustomerValidator :AbstractValidator<Customer>
	{
		public CustomerValidator()
		{
			RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Ad ve Soyad kısmı boş geçilemez!");
			RuleFor(x => x.CustomerMail).NotEmpty().WithMessage("Mail adresi boş kalamaz!");
			RuleFor(x => x.CustomerPassword).NotEmpty().WithMessage("Şifre boş kalamaz!");
			RuleFor(x => x.CustomerName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın!");
			RuleFor(x => x.CustomerName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın!");



        }
	}
}
