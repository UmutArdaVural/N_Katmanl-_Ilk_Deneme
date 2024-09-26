using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x=>x.CustomerName).NotEmpty().WithMessage("Müşteri ismi boş geçilemez");
            RuleFor(x => x.CustomerEmail).NotEmpty().WithMessage("Müşteri email boş geçilemez");
            RuleFor(x => x.CustomerId).NotEmpty().WithMessage("Müşteri idsi boş geçilemez");
            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Müşteri şehri boş geçilemez");
            RuleFor(x => x.CustomerPhone).NotEmpty().WithMessage("Müşteri telefon numarası boş geçilemez");


        }
    }
}
