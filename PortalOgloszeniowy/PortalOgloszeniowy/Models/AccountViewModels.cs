using PortalOgloszeniowy.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalOgloszeniowy.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
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
            ErrorMessageResourceName = "FieldRequired")]
        public string Provider { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
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
            ErrorMessageResourceName = "FieldRequired")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Email")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailValidator")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
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
            ErrorMessageResourceName = "FieldRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailValidator")]
        [Display(ResourceType = typeof(Resources.Global), Name="Email")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
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
            ErrorMessageResourceName = "FieldRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailValidator")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "FieldRequired")]
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
            ErrorMessageResourceName = "FieldRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global),
            ErrorMessageResourceName = "EmailValidator")]
        [Display(ResourceType = typeof(Resources.Global), Name = "Email")]
        public string Email { get; set; }
    }
}
