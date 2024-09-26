using Microsoft.AspNetCore.Identity;

namespace N_Katmanlı_Ders.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {

       public override IdentityError PasswordTooShort(int lenght)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Parola çok kısa "
            }; 
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola  en az 1 büyük harf içermelidir "
            };
        }

        public override IdentityError PasswordRequiresLower() {
          
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parola  en az 1 küçük harf içermelidir "
            };

        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 alfanumerik karakter içermelidir."
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Parola en az bir rakam ('0'-'9') içermelidir."
            };
        }


    }
}
