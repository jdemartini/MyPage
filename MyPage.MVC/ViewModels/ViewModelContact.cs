using System.ComponentModel.DataAnnotations;

namespace MyPage.MVC.ViewModels
{
    public class ViewModelContact
    {
        [Display(Name = "Name", Description = "Your fullname then I can call you properly.")]
        [Required(ErrorMessage = "Name is required.")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed in the name.")]
        [MaxLength(40)]
        public string Name { get; set; }

        [Display(Name = "Email", Description = "A valid email to contact you.")]
        [Required(ErrorMessage="I need an email to answer you!")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Display(Name = "Mobile phone", Description = "If you wanna to receive call, let me know your mobile phone. But that is not mandatory...")]
        public string Phone { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage="Text me then I'll know what you're thinking. Thank you!")]
        [MaxLength (4000)]
        public string Message { get; set; }
    }
}