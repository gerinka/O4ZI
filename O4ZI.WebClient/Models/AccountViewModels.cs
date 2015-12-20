using System.ComponentModel.DataAnnotations;

namespace O4ZI.WebClient.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Потребителското име е задължително")]
        [Display(Name = "Потребителско име")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Паролата е задължителна")]
        [StringLength(100, ErrorMessage = "{0}та трябва да е дълга поне {2} символа.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Повтори паролата")]
        [Compare("Password", ErrorMessage = "Двете пароли не съвпадат.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "E-mail адресът е задължителен")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Е-mail адрес")]
        [EmailAddress(ErrorMessage = "Невалиден e-mail адрес")]
        public string Email { get; set; }

    }
}
