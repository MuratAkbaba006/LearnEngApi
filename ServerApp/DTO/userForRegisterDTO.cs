using System.ComponentModel.DataAnnotations;

namespace ServerApp.DTO
{
    public class userForRegisterDTO
    {

        [Required(ErrorMessage="name gerekli")]
        

        
        public string UserName { get; set; }
            [Required]
            [EmailAddress]
             public string Email { get; set; }
             [Required]
             public string Password { get; set; }
    }
}