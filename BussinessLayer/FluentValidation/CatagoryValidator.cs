using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.FluentValidation
{
    public class CatagoryValidator : AbstractValidator<Catagory>
    {
       public CatagoryValidator ()
        {
            RuleFor(x=>x.CatagoryName).NotEmpty().WithMessage("Katagory adı boş geçilemez ");
            RuleFor(x => x.CatagoryName).NotEmpty().WithMessage("Katagory adı boş geçilemez ");

        }



    }
}
