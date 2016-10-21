using PortalOgloszeniowy.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalOgloszeniowy.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailRequired")]
        [Display(ResourceType =typeof(Resources.Global),Name ="Email")]
        public string Email { get; set; }
    }
    
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "ProviderRequired")]
        public string Provider { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "CodeRequired")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(ResourceType = typeof(Resources.Global), Name = "RememberBrowser")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailRequired")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailRequired")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Email")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailValidator")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordRequired")]
        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Password")]
        public string Password { get; set; }

        [Display(ResourceType = typeof(Resources.Global), Name = "RememberMe")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailValidator")]
        [Display(ResourceType = typeof(Resources.Global), Name="Email")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordRequired")]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [StringLength(100, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordMinLenght", MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "ConfirmPassword")]
        [Compare("Password", ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "PasswordCompareFailed")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailValidator")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordRequired")]
        [StringLength(100, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordMinLenght", MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password, ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "PasswordDataType")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailValidator")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Email")]
        public string Email { get; set; }
    }
}
