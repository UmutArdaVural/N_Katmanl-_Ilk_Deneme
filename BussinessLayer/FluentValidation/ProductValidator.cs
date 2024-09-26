using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.FluentValidation
{
    public  class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName)
      .NotEmpty().WithMessage("Ürün Adını boş geçemessiniz")
      .MinimumLength(3).WithMessage("Ürün Adı en az 3 harfli olmalı");

            RuleFor(x => x.ProductStock)
                .NotEmpty().WithMessage("Ürün stoğu boş geçilemez")
                .GreaterThanOrEqualTo(0).WithMessage("Ürün stoğu negatif olamaz");

            RuleFor(x => x.ProductPrice)
                .NotEmpty().WithMessage("Ürün Fiyatı boş geçilemez")
                .GreaterThan(0).WithMessage("Ürün fiyatı 0'dan büyük olmalı");

        }
    }
}
