using System.ComponentModel.DataAnnotations;

namespace N_Katmanlı_Ders.Models
{
    public class UserRegisterVievModel
    {
        [Required(ErrorMessage ="Lütfen İsim  giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyisim  giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyeti seçiniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı ismini  giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Email giriniz")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        [Compare("Password" ,ErrorMessage = "Lütfen şifrenin aynısını  giriniz")]

        public string ConfirmPassword { get; set; }
    }
}
