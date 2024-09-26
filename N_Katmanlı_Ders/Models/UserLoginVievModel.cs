using System.ComponentModel.DataAnnotations;

namespace N_Katmanlı_Ders.Models
{
    public class UserLoginVievModel
    {
        [Required (ErrorMessage="Lütfen Kullanıcı adınızı girniz ")]
        public string UserName { get; set; }
       
        [Required(ErrorMessage = "Lütfen Kullanıcı Şifrenizi  girniz ")]
        public string Password { get; set; }


    }
}
